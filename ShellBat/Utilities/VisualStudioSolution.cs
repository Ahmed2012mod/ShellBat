namespace ShellBat.Utilities;

public class VisualStudioSolution
{
    private readonly List<VisualStudioProject> _projects = [];
    //private readonly Dictionary<string, object?> _properties = new(StringComparer.OrdinalIgnoreCase);

    private VisualStudioSolution(IComObject<DirectN.IDispatch> solution)
    {
        try
        {
            FullName = solution.Object.GetProperty<string>("FullName") ?? string.Empty;
            FileName = solution.Object.GetProperty<string>("FileName") ?? string.Empty;
            //FillProperties(solution, _properties);

            using var projects = solution.GetComObjectProperty<DirectN.IDispatch>("Projects");
            var count = projects.GetProperty<int>("Count");
            for (var i = 0; i < count; i++)
            {
                var project = projects.CallMethodComObject<DirectN.IDispatch>("Item", [i + 1]);
                if (project == null)
                    continue;

                var vsProject = new VisualStudioProject(project);
                _projects.Add(vsProject);
            }

            using var props = solution.GetComObjectProperty<DirectN.IDispatch>("Properties");
            var name = GetPropertyValue(props, "Name");
            Name = name?.ToString() ?? Path.GetFileNameWithoutExtension(FileName).Nullify() ?? Path.GetFileNameWithoutExtension(FullName).Nullify() ?? string.Empty;
        }
        finally
        {
            solution.Dispose();
        }
    }

    public string FullName { get; }
    public string FileName { get; }
    public string Name { get; }
    public IReadOnlyList<VisualStudioProject> Projects => _projects.AsReadOnly();
    //public IReadOnlyDictionary<string, object?> Properties => _properties.AsReadOnly();

    public override string ToString() => FullName;

    internal static string? GetNullifiedValue(IComObject<DirectN.IDispatch>? properties, string name)
    {
        var value = GetPropertyValue(properties, name);
        return value?.ToString().Nullify();
    }

    internal static object? GetPropertyValue(IComObject<DirectN.IDispatch>? properties, string name)
    {
        if (properties == null)
            return null;

        using var prop = properties.CallMethodComObject<DirectN.IDispatch>("Item", [name]);
        if (prop == null)
            return null;

        return prop.GetProperty<object?>("Value");
    }

    //internal static void FillProperties(IComObject<DirectN.IDispatch> disp, Dictionary<string, object?> properties)
    //{
    //    using var props = disp.GetComObjectProperty<DirectN.IDispatch>("Properties");
    //    var count = props.GetProperty<int>("Count");
    //    for (var i = 0; i < count; i++)
    //    {
    //        using var prop = props.CallMethodComObject<DirectN.IDispatch>("Item", [i + 1]);
    //        if (prop == null)
    //            continue;

    //        var name = prop.GetProperty<string>("Name");
    //        var value = prop.GetProperty<object?>("Value");
    //        if (name != null)
    //        {
    //            properties[name] = value;
    //        }
    //    }
    //}

    public static bool DetectsVisualStudioInstances()
    {
        DirectN.Functions.CreateBindCtx(0, out var ctxObj);
        if (ctxObj != null)
        {
            using var ctx = new ComObject<DirectN.IBindCtx>(ctxObj);
            foreach (var mk in RunningObjectTable.Enumerate(false))
            {
                var name = GetName(ctx.Object, mk.Object);
                if (name != null && name.StartsWith("!VisualStudio.DTE."))
                    return true;
            }
        }
        return false;
    }

    public static IEnumerable<VisualStudioSolution> Enumerate()
    {
        DirectN.Functions.CreateBindCtx(0, out var ctxObj);
        if (ctxObj == null)
            yield break;

        using var ctx = new ComObject<DirectN.IBindCtx>(ctxObj);
        foreach (var mk in RunningObjectTable.Enumerate(false))
        {
            var name = GetName(ctx.Object, mk.Object);
            if (name == null || !name.StartsWith("!VisualStudio.DTE."))
                continue;

            var unk = RunningObjectTable.GetObject(mk.Object, false);
            if (unk == 0)
                continue;

            using var envDte = ComObject.FromPointer<DirectN.IDispatch>(unk);
            if (envDte == null)
                continue;

            //var sp = envDte.As<DirectN.IServiceProvider>()!;
            //sp.Object.QueryService(typeof(IVsSolution).GUID, typeof(IVsSolution).GUID, out var solPtr);

            var solution = envDte.Object.GetComObjectProperty<DirectN.IDispatch>("Solution");
            if (solution == null)
                continue;

            yield return new VisualStudioSolution(solution);
        }
    }

    private static string? GetName(IBindCtx ctx, IMoniker mk)
    {
        mk.GetDisplayName(ctx, null!, out var namePtr);
        if (namePtr.Value == 0)
            return null;

        try
        {
            return Marshal.PtrToStringUni(namePtr.Value);
        }
        finally
        {
            Marshal.FreeCoTaskMem(namePtr.Value);
        }
    }
}
