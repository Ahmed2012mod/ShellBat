namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebPropertyGrid : DispatchObject
{
    private readonly List<WebPropertyGridProperty> _properties = [];

    public IList<WebPropertyGridProperty> Properties => _properties;
    public WebPropertyGridInstance Instance { get; } = new WebPropertyGridInstance();
    public WebPropertyGridOptions Options { get; set; } = new WebPropertyGridOptions();
    public object? InstanceObject { get; protected set; }

    public event CancelEventHandler? Saving;
    public event EventHandler? Saved;

    public virtual void SortProperties() => _properties.Sort();

    public virtual bool Save()
    {
        if (!Instance.HasChanges)
            return false;

        var e = new CancelEventArgs();
        OnSaving(this, e);
        if (e.Cancel)
            return false;

        Instance.ChangedPropertyNames.Clear();
        OnSaved(this, EventArgs.Empty);
        return true;
    }

    public virtual bool ApplyChanges<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] T>(T instance)
    {
        ArgumentNullException.ThrowIfNull(instance);
        var changed = false;
        foreach (var propName in Instance.ChangedPropertyNames)
        {
            var propInfo = typeof(T).GetProperty(propName, BindingFlags.Public | BindingFlags.Instance);
            if (propInfo == null || !propInfo.CanWrite)
                continue;

            var oldValue = propInfo.GetValue(instance);
            var newRawValue = Instance.GetValue(propName);
            var newValue = Conversions.ChangeObjectType(newRawValue, propInfo.PropertyType);
            if (Equals(oldValue, newValue))
                continue;

            propInfo.SetValue(instance, newValue);
            changed = true;
        }
        return changed;
    }

    protected virtual void OnSaving(object sender, CancelEventArgs e) => Saving?.Invoke(sender, e);
    protected virtual void OnSaved(object sender, EventArgs e) => Saved?.Invoke(sender, e);

    public static WebPropertyGrid Reflect<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] T>(
        T instance,
        WebPropertyGridReflectOptions options = WebPropertyGridReflectOptions.None)
    {
        ArgumentNullException.ThrowIfNull(instance);
        var pg = new WebPropertyGrid { InstanceObject = instance };

        string? instancingCategory = null;
        if (ShellBatInstance.Current.IsUnspecified)
        {
            instancingCategory = Res.ResourceManager.GetString(Settings.InstancingCategoryName) ?? Settings.InstancingCategoryName;
        }

        foreach (var prop in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            if (!prop.CanRead)
                continue;

            var browsable = prop.GetCustomAttribute<BrowsableAttribute>();
            if (browsable != null && !browsable.Browsable)
                continue;

            var ro = prop.GetCustomAttribute<ReadOnlyAttribute>();

            var pgProp = new WebPropertyGridProperty
            {
                Key = prop.Name,
                IsReadOnly = ro?.IsReadOnly == true || !prop.CanWrite || prop.SetMethod?.IsPublic == false,
            };

            if (prop.PropertyType.IsNullable())
            {
                pgProp.Editor = $"Nullable{prop.PropertyType.GenericTypeArguments[0].Name}";
            }
            else
            {
                pgProp.Editor = prop.PropertyType.Name;
            }

            var def = prop.GetCustomAttribute<DefaultValueAttribute>();
            if (def != null)
            {
                pgProp.HasDefault = true;
                pgProp.DefaultValue = def.Value;
            }

            var cat = prop.GetCustomAttribute<CategoryAttribute>();
            if (cat != null)
            {
                // hide per instancing category if we're running as unspecified/global instance
                if (instancingCategory != null && cat.Category.EqualsIgnoreCase(instancingCategory))
                    continue;

                pgProp.CategoryName = cat.Category;
            }

            var dn = prop.GetCustomAttribute<DisplayNameAttribute>();
            if (dn != null)
            {
                pgProp.DisplayName = dn.DisplayName;
            }
            else
            {
                pgProp.DisplayName = Conversions.Decamelize(prop.Name);
            }

            var desc = prop.GetCustomAttribute<DescriptionAttribute>();
            if (desc != null)
            {
                pgProp.Tooltip = desc.Description;
            }

            var dt = prop.GetCustomAttribute<WebPropertyGridPropertyAttribute>();
            if (dt != null)
            {
                if (dt.Windows11Only)
                {
                    var kv = WindowsVersionUtilities.KernelVersion;
                    if (kv.Build < 22000)
                        continue;
                }

                pgProp.IsHidden = dt.IsHidden;
                pgProp.IsHtml = dt.IsHtml;

                if (dt.EnumProvider != EnumProvider.None)
                {
                    object? provider = null;
                    switch (dt.EnumProvider)
                    {
                        case EnumProvider.ImageFormat:
                            provider = new ImageFormatEnumProvider();
                            break;
                    }

                    if (provider is not IEnumProvider enumProvider)
                        continue;

                    pgProp.IsEnum = true;
                    pgProp.IsFlagsEnum = enumProvider.IsFlags;
                    pgProp.EnumValues = enumProvider.Values;
                    pgProp.Editor = null;
                }
                else
                {
                    pgProp.BaseClassName = dt.BaseClassName;
                }
            }

            if (prop.PropertyType == typeof(IEnumerable<KeyValuePair<string, object?>>))
            {
                if (prop.GetValue(instance) is IEnumerable<KeyValuePair<string, object?>> subProperties)
                {
                    foreach (var kv in subProperties)
                    {
                        var subValue = kv.Value;
                        if (subValue == null && options.HasFlag(WebPropertyGridReflectOptions.RemoveNullValues))
                            continue;

                        if (subValue is string s2 && string.IsNullOrWhiteSpace(s2) && options.HasFlag(WebPropertyGridReflectOptions.RemoveEmptyStringValues))
                            continue;

                        var pgp = new WebPropertyGridProperty()
                        {
                            CategoryName = pgProp.CategoryName,
                            IsReadOnly = true,
                            Editor = subValue?.GetType().Name,
                            Key = prop.Name + "." + kv.Key,
                            DisplayName = kv.Key,
                        };

                        pg.Properties.Add(pgp);
                        pg.Instance.SetValue(pgp.Key, subValue);
                    }
                }
                continue;
            }

            if (prop.PropertyType.IsEnum)
            {
                pgProp.IsEnum = true;
                pgProp.IsFlagsEnum = prop.PropertyType.GetCustomAttribute<FlagsAttribute>() != null;
                var enumValues = prop.PropertyType.GetEnumValuesAsUnderlyingType();
                var commonPrefix = ShellBatExtensions.GetEnumCommonPrefix(prop.PropertyType);
                pgProp.EnumValues = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
                foreach (var enumValue in enumValues)
                {
                    var enumName = Enum.GetName(prop.PropertyType, enumValue);
                    if (enumName != null)
                    {
                        if (commonPrefix != null)
                        {
                            enumName = enumName[commonPrefix.Length..];
                        }

                        var name = Conversions.Decamelize(enumName, DecamelizeOptions.ForceRestLower) ?? enumName;
                        pgProp.EnumValues[name] = enumValue;
                    }
                }
            }

            var value = prop.GetValue(instance);
            if (value == null && options.HasFlag(WebPropertyGridReflectOptions.RemoveNullValues))
                continue;

            if (value is string s && string.IsNullOrWhiteSpace(s) && options.HasFlag(WebPropertyGridReflectOptions.RemoveEmptyStringValues))
                continue;

            if (dt != null && dt.NeedsRestart)
            {
                if (pgProp.Tooltip != null)
                {
                    pgProp.Tooltip += $" ({Res.NeedsRestart})";
                }

                if (pgProp.DisplayName != null)
                {
                    pgProp.DisplayName += $" ({Res.NeedsRestart})";
                }
            }

            pg.Properties.Add(pgProp);
            pg.Instance.SetValue(prop.Name, value);
        }

        pg.Instance.ChangedPropertyNames.Clear();
        return pg;
    }
}
