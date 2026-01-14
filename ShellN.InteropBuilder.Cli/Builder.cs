using System.CodeDom.Compiler;
using Win32InteropBuilder;
using Win32InteropBuilder.Model;
using Win32InteropBuilder.Utilities;

namespace ShellN.InteropBuilder.Cli;

public partial class Builder : Win32InteropBuilder.Builder
{
    public const string Namespace = "ShellN";
    public const string ProjectName = "ShellN";
    public const string PropertyKeysName = "PropertyKeys";

    public override BuilderContext CreateBuilderContext(BuilderConfiguration configuration, IGenerator generator)
    {
        ArgumentNullException.ThrowIfNull(configuration);
        ArgumentNullException.ThrowIfNull(generator);

        configuration.OutputDirectoryPath = Path.GetFullPath(Path.Combine(Win32Metadata.SolutionDir, ProjectName, "Generated"));
        var context = new ShellNBuilderContext(configuration, generator);
        context.ImplicitNamespaces.Add(Namespace);
        return context;
    }

    protected override void GenerateTypes(BuilderContext context)
    {
        base.GenerateTypes(context);
        GeneratePropertyKeysType(context);
    }

    protected virtual string GeneratePropertyKeysType(BuilderContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(context.Configuration);
        ArgumentNullException.ThrowIfNull(context.Configuration.OutputDirectoryPath);

        using var writer = new StringWriter();
        context.CurrentWriter = new IndentedTextWriter(writer);
        try
        {
            GeneratePropertyKeys(context);
        }
        finally
        {
            context.CurrentWriter.Dispose();
            context.CurrentWriter = null;
        }

        var text = writer.ToString();
        var fileName = PropertyKeysName + context.Generator.FileExtension;
        var typePath = Path.Combine(context.Configuration.OutputDirectoryPath, Namespace, fileName);

        if (IOUtilities.PathIsFile(typePath))
        {
            var existingText = EncodingDetector.ReadAllText(typePath, context.Configuration.EncodingDetectorMode, out _);

            // remove ws for comparison to avoid stupid git mangling with end-of-lines
            if (text.EqualsWithoutWhitespaces(existingText))
                return typePath;
        }

        IOUtilities.FileEnsureDirectory(typePath);

        context.LogVerbose(PropertyKeysName + " => " + typePath);
        File.WriteAllText(typePath, text, context.Configuration.FinalOutputEncoding);
        return typePath;
    }

    protected virtual void GeneratePropertyKeys(BuilderContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(context.Generator);
        ArgumentNullException.ThrowIfNull(context.CurrentWriter);
        ArgumentNullException.ThrowIfNull(context.Configuration);
        ArgumentNullException.ThrowIfNull(context.Configuration.Generation);

        context.CurrentWriter.WriteLine("#nullable enable");
        context.CurrentWriter.WriteLine($"namespace {Namespace}.PropertyKeys;");
        context.CurrentWriter.WriteLine();
        foreach (var ps in DirectN.Extensions.Utilities.PropertyDescription.EnumeratePropertyDescriptions(DirectN.PROPDESC_ENUMFILTER.PDEF_SYSTEM))
        {
            var pns = PropertyNamespace.Get(ps.Namespace!);
            pns.Properties.Add(ps);
        }

        var children = PropertyNamespace.Root.Children.Values.ToArray();
        for (var i = 0; i < children.Length; i++)
        {
            children[i].WritePropertiesClass(context.CurrentWriter, i == children.Length - 1);
        }
    }

    protected override void AddMappedTypes(BuilderContext context)
    {
        base.AddMappedTypes(context);
        context.MappedTypes[TypeMappings.ITEMIDLIST] = context.AllTypes[FullName.SystemIntPtr];
    }

    protected override void ExcludeTypesFromBuild(BuilderContext context)
    {
        base.ExcludeTypesFromBuild(context);

        var alreadyIncludedTypes = new HashSet<string>();
        foreach (var type in typeof(DirectN.VARIANT).Assembly.GetTypes())
        {
            if (type.IsPublic)
            {
                alreadyIncludedTypes.Add(type.Name);
            }
        }

        var typeNamesToBuild = new Dictionary<string, List<FullName>>();
        foreach (var type in context.TypesToBuild)
        {
            var name = type.Name;
            if (type.NestedName != null)
            {
                name = name[..type.Name.IndexOf('+')];
            }

            if (!typeNamesToBuild.TryGetValue(name, out var list))
            {
                list = [];
                typeNamesToBuild[name] = list;
            }
            list.Add(type);
        }

        // the following is because of this horrible bug https://github.com/dotnet/runtime/issues/111573
        var fixBug = true;

        var excluded = new HashSet<FullName>();
        foreach (var type in alreadyIncludedTypes)
        {
            if (typeNamesToBuild.Remove(type, out var list))
            {
                foreach (var item in list)
                {
                    if (fixBug)
                    {
                        if (context.TypesToBuild.Contains(item))
                        {
                            excluded.Add(item);
                        }
                    }
                    else
                    {
                        context.TypesToBuild.Remove(item);
                    }
                }
            }
        }

        if (fixBug)
        {
            var inheritedCount = new Dictionary<FullName, HashSet<FullName>>();
            foreach (var type in context.TypesToBuild)
            {
                if (context.AllTypes[type] is InterfaceType iface)
                {
                    excludeFromShellN(iface);
                }
            }

            void excludeFromShellN(InterfaceType itype)
            {
                if (itype.Interfaces.Count == 0)
                    return;

                foreach (var iface in itype.Interfaces)
                {
                    if (excluded.Contains(iface))
                    {
                        if (!inheritedCount.TryGetValue(iface, out var list))
                        {
                            inheritedCount[iface] = [];
                        }
                        inheritedCount[iface].Add(itype.FullName);
                    }
                }

                foreach (var iface in itype.Interfaces)
                {
                    if (context.AllTypes[iface] is InterfaceType i)
                    {
                        excludeFromShellN(i);
                    }
                }
            }

            foreach (var kv in inheritedCount)
            {
                excluded.Remove(kv.Key);
            }

            foreach (var type in excluded)
            {
                context.TypesToBuild.Remove(type);
            }
        }
    }

    private sealed class PropertyNamespace(string ns)
    {
        public string Namespace { get; } = ns;
        public string Name { get { var pos = Namespace.LastIndexOf('.'); return pos < 0 ? Namespace : Namespace[(pos + 1)..]; } }
        public Dictionary<string, PropertyNamespace> Children { get; } = new(StringComparer.OrdinalIgnoreCase);
        public List<DirectN.Extensions.Utilities.PropertyDescription> Properties { get; } = [];
        public override string ToString() => Namespace;

        public static readonly PropertyNamespace Root;
        public static Dictionary<string, PropertyNamespace> All { get; } = new(StringComparer.OrdinalIgnoreCase);

        static PropertyNamespace()
        {
            Root = new PropertyNamespace(string.Empty);
            All[Root.Namespace] = Root;
        }

        public static PropertyNamespace Get(string ns)
        {
            if (All.TryGetValue(ns, out var pns))
                return pns;

            var segments = ns.Split('.');
            var current = Root;
            string? cur = null;
            for (var i = 0; i < segments.Length; i++)
            {
                cur = i == 0 ? segments[0] : cur + "." + segments[i];
                if (!current.Children.TryGetValue(cur, out pns))
                {
                    pns = new PropertyNamespace(cur);
                    All[pns.Namespace] = pns;
                    current.Children[pns.Namespace] = pns;
                }
                current = pns;
            }

            All[ns] = current;
            return current;
        }

        public void WritePropertiesClass(IndentedTextWriter iw, bool last)
        {
            iw.WriteLine($"public static class {Name}");
            CurlyIndent(iw, () =>
            {
                for (var i = 0; i < Properties.Count; i++)
                {
                    var prop = Properties[i];
                    var propName = prop.Name;
                    if (Children.Any(c => c.Value.Name.EqualsIgnoreCase(propName)))
                    {
                        propName += "Property";
                    }

                    iw.WriteLine("/// <summary>");
                    iw.WriteLine($"/// <b>{prop.CanonicalName}</b> of <b>{prop.PropertyType}</b> type.");
                    iw.WriteLine("/// </summary>");
                    iw.WriteLine($"public static PROPERTYKEY {propName} => new(new(\"{prop.PropertyKey.fmtid}\"), {prop.PropertyKey.pid});");
                    if (i != Properties.Count - 1 || Children.Count > 0)
                    {
                        iw.WriteLine();
                    }
                }

                var children = Children.Values.ToArray();
                for (var i = 0; i < children.Length; i++)
                {
                    children[i].WritePropertiesClass(iw, i == children.Length - 1);
                }
            });

            if (!last)
            {
                iw.WriteLine();
            }
        }

        public static void CurlyIndent(IndentedTextWriter writer, Action action)
        {
            writer.WriteLine("{");
            writer.Indent++;
            action();
            writer.Indent--;
            writer.WriteLine("}");
        }
    }
}
