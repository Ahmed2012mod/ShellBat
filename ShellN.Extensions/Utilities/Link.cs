namespace ShellN.Extensions.Utilities;

public class Link(IComObject<IShellLinkW> comObject) : InterlockedComObject<IShellLinkW>(comObject)
{
    private readonly IComObject<IPersistFile> _file = comObject.As<IPersistFile>(throwOnError: true)!;
    private readonly Lazy<PropertyStore?> _properties = new(() =>
    {
        var ps = comObject.As<IPropertyStore>();
        if (ps == null)
            return null;

        return new PropertyStore(ps);
    });

    public bool IsDirty => _file.Object.IsDirty() == DirectN.Constants.S_OK;
    public string? CurrentFileName { get { _file.Object.GetCurFile(out var file); return file.ToString(); } }
    public PropertyStore? Properties => _properties.Value;
    public string? ParsingPath => Properties?.GetNullifiedStringValue(PropertyKeys.System.ParsingPath);
    public string? ItemNameDisplay => Properties?.GetNullifiedStringValue(PropertyKeys.System.ItemNameDisplay);
    public string? ItemType => Properties?.GetNullifiedStringValue(PropertyKeys.System.ItemType);
    public string? ItemTypeType => Properties?.GetNullifiedStringValue(PropertyKeys.System.ItemTypeText);

    public virtual ItemIdList? TargetIdList
    {
        get
        {
            NativeObject.GetIDList(out var pidl);
            if (pidl == nint.Zero)
                return null;

            return ItemIdList.FromPointer(pidl, true);
        }
        set
        {
            NativeObject.SetIDList(value?.Pointer ?? 0).ThrowOnError(true);
        }
    }

    public virtual string? TargetPath
    {
        get
        {
            var data = new WIN32_FIND_DATAW();
            var p = new AllocPwstr(65536);
            NativeObject.GetPath(p, (int)p.SizeInChars, ref data, 0);
            return p.ToString();
        }
        set => NativeObject.SetPath(PWSTR.From(value)).ThrowOnError(true);
    }

    public virtual string? Description
    {
        get
        {
            var p = new AllocPwstr(65536);
            NativeObject.GetDescription(p, (int)p.SizeInChars);
            return p.ToString();
        }
        set => NativeObject.SetDescription(PWSTR.From(value)).ThrowOnError(true);
    }

    public virtual string? WorkingDirectory
    {
        get
        {
            var p = new AllocPwstr(65536);
            NativeObject.GetWorkingDirectory(p, (int)p.SizeInChars);
            return p.ToString();
        }
        set => NativeObject.SetWorkingDirectory(PWSTR.From(value)).ThrowOnError(true);
    }

    public virtual string? Arguments
    {
        get
        {
            var p = new AllocPwstr(65536);
            NativeObject.GetArguments(p, (int)p.SizeInChars);
            return p.ToString();
        }
        set => NativeObject.SetArguments(PWSTR.From(value)).ThrowOnError(true);
    }

    public virtual ushort Hotkey
    {
        get
        {
            NativeObject.GetHotkey(out var value);
            return value;
        }
        set => NativeObject.SetHotkey(value).ThrowOnError(true);
    }

    public virtual SHOW_WINDOW_CMD ShowCommand
    {
        get
        {
            NativeObject.GetShowCmd(out var value);
            return value;
        }
        set => NativeObject.SetShowCmd(value).ThrowOnError(true);
    }

    public Guid Clsid
    {
        get
        {
            _file.Object.GetClassID(out var clsid);
            return clsid;
        }
    }

    public override string ToString() => TargetPath ?? TargetIdList?.ToString() ?? string.Empty;

    public virtual HRESULT SetIconLocation(string? path, int index, bool throwOnError = true) => NativeObject.SetIconLocation(PWSTR.From(path), index).ThrowOnError(throwOnError);
    public virtual HRESULT GetIconLocation(out string? path, out int index, bool throwOnError = false)
    {
        var p = new AllocPwstr(1024);
        var hr = NativeObject.GetIconLocation(p, (int)p.SizeInChars, out index).ThrowOnError(throwOnError);
        if (hr != 0)
        {
            path = null;
            return hr;
        }

        path = p.ToString();
        return 0;
    }

    public virtual HRESULT SetRelativePath(string? path, bool throwOnError = true) => NativeObject.SetRelativePath(PWSTR.From(path), 0).ThrowOnError(throwOnError);
    public virtual HRESULT Save(string? absolutePath = null, bool throwOnError = true)
    {
        absolutePath ??= CurrentFileName;
        if (absolutePath == null)
            throw new ArgumentNullException(nameof(absolutePath), "Path cannot be null when the link has not been previously saved.");

        // note path must be absolute here
        return _file.Object.Save(PWSTR.From(absolutePath), false).ThrowOnError(throwOnError);
    }

    public static Link? FromNativeObject(object? obj = null)
    {
        if (obj is Link l)
            return l;

        if (obj is IShellLinkW linkObj)
            return new Link(new ComObject<IShellLinkW>(linkObj));

        if (obj is null)
        {
            var link = DirectN.Extensions.Com.ComObject.CoCreate<IShellLinkW>(Constants.ShellLink);
            if (link == null)
                return null;

            return new Link(link);
        }
        return null;
    }

    public static Link? Load(string path, STGM mode = STGM.STGM_READ, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(path);
        var file = DirectN.Extensions.Com.ComObject.CoCreate<IPersistFile>(Constants.ShellLink);
        if (file == null)
            return null;

        var hr = file.Object.Load(PWSTR.From(path), mode).ThrowOnError(throwOnError);
        if (hr != 0)
            return null;

        var link = file.As<IShellLinkW>(throwOnError: throwOnError);
        if (link == null)
            return null;

        return new Link(link);
    }
}
