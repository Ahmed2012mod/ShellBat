namespace ShellN.Extensions;

public sealed class KnownFolder : InterlockedComObject<IKnownFolder>
{
    private static readonly Lazy<KnownFolder> _desktop = new(() => Get(Constants.FOLDERID_Desktop)!, true);
    private static readonly Lazy<KnownFolder> _computer = new(() => Get(Constants.FOLDERID_ComputerFolder)!, true);

    public static KnownFolder Desktop => _desktop.Value;
    public static KnownFolder Computer => _computer.Value;
    public static IComObject<IKnownFolderManager> CreateKnownFolderManager() => ComObject<IKnownFolderManager>.CoCreate(Constants.KnownFolderManager)!;

    public static KnownFolder? FromObject(object? obj)
    {
        if (obj is KnownFolder kf)
            return kf;

        if (obj is IKnownFolder folder)
            return new KnownFolder(folder);

        return null;
    }

    public static IReadOnlyList<KnownFolder> GetAll()
    {
        using var kfm = CreateKnownFolderManager();
        uint count = 0;
        kfm.Object.GetFolderIds(out var pids, ref count);
        var list = new List<KnownFolder>();
        var ptr = pids;
        for (var i = 0; i < count; i++)
        {
            kfm.Object.GetFolder(pids[i], out var kf);
            if (kf != null)
            {
                var folder = new KnownFolder(kf);
                list.Add(folder);
            }
        }
        return [.. list.OrderBy(k => k.Name)];
    }

    public static KnownFolder? Get(Guid id)
    {
        if (id == Guid.Empty)
            return null;

        using var kfm = CreateKnownFolderManager();
        kfm.Object.GetFolder(id, out var kf);
        if (kf == null)
            return null;

        return new KnownFolder(kf);
    }

    public static KnownFolder? Get(string name)
    {
        ArgumentNullException.ThrowIfNull(name);
        using var kfm = CreateKnownFolderManager();
        kfm.Object.GetFolderByName(PWSTR.From(name), out var kf);
        if (kf == null)
            return null;

        return new KnownFolder(kf);
    }

    public static KnownFolder? Find(nint pidl)
    {
        if (pidl == 0)
            throw new ArgumentException(null, nameof(pidl));

        using var kfm = CreateKnownFolderManager();
        kfm.Object.FindFolderFromIDList(pidl, out var kf);
        if (kf == null)
            return null;

        return new KnownFolder(kf);
    }


    public static KnownFolder? Find(string path, FFFP_MODE mode = FFFP_MODE.FFFP_EXACTMATCH)
    {
        ArgumentNullException.ThrowIfNull(path);
        using var kfm = CreateKnownFolderManager();
        kfm.Object.FindFolderFromPath(PWSTR.From(path), mode, out var kf);
        if (kf == null)
            return null;

        return new KnownFolder(kf);
    }

    public static Guid FolderIdFromCsidl(uint csidl) => FolderIdFromCsidl((int)csidl);
    public static Guid FolderIdFromCsidl(int csidl)
    {
        using var kfm = CreateKnownFolderManager();
        kfm.Object.FolderIdFromCsidl(csidl, out var id);
        return id;
    }

    public static int FolderIdToCsidl(Guid id)
    {
        using var kfm = CreateKnownFolderManager();
        kfm.Object.FolderIdToCsidl(id, out var csidl);
        return csidl;
    }

    private KnownFolder(IKnownFolder folder)
        : base(new ComObject<IKnownFolder>(folder))
    {
        folder.GetId(out var id);
        Id = id;

        folder.GetFolderDefinition(out var def);
        Name = def.pszName.ToString()!;
        ParsingName = def.pszParsingName.ToString();
        RelativePath = def.pszRelativePath.ToString();
        Description = def.pszDescription.ToString();
        Category = def.category;
        Icon = def.pszIcon.ToString();
        LocalizedName = def.pszLocalizedName.ToString();
        Tooltip = def.pszTooltip.ToString();
        folder.GetFolderType(out var ft);
        FolderType = ft;
        DefaultPath = GetPath(KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, false);

        folder.GetRedirectionCapabilities(out var caps);
        RedirectionCapabilities = (_KF_REDIRECTION_CAPABILITIES)caps;
        Flags = (_KF_DEFINITION_FLAGS)def.kfdFlags;
        ParentId = def.fidParent;
        Security = def.pszSecurity.ToString();
        Attributes = (FileAttributes)def.dwAttributes;
    }

    public Guid Id { get; }
    public Guid ParentId { get; }
    public string? Name { get; }
    public string? ParsingName { get; }
    public FileAttributes Attributes { get; }
    public string? LocalizedName { get; }
    public string? Icon { get; }
    public string? DefaultPath { get; }
    public string? Description { get; }
    public string? RelativePath { get; }
    public string? Security { get; }
    public string? Tooltip { get; }
    public Guid FolderType { get; }
    public KF_CATEGORY Category { get; }
    public _KF_REDIRECTION_CAPABILITIES RedirectionCapabilities { get; }
    public _KF_DEFINITION_FLAGS Flags { get; }
    public KnownFolder? Parent => Get(ParentId);
    public string? DisplayName => GetName(KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, SIGDN.SIGDN_NORMALDISPLAY, false);
    public string? NameForAddressBar => GetName(KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, SIGDN.SIGDN_PARENTRELATIVEFORADDRESSBAR, false);
    public string? NameForUI => GetName(KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, SIGDN.SIGDN_PARENTRELATIVEFORUI, false);
    public string? NameForEditing => GetName(KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, SIGDN.SIGDN_PARENTRELATIVEEDITING, false);
    public string? EditingName => GetName(KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, SIGDN.SIGDN_DESKTOPABSOLUTEEDITING, false);

    public override string ToString() => Name ?? string.Empty;

    public ShellFolder? ToFolder(KNOWN_FOLDER_FLAG flags = KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, bool owned = true, bool throwOnError = true)
    {
        using var idl = GetIdList(flags, throwOnError);
        return ShellItem.FromItemIdList(idl, false, owned, throwOnError) as ShellFolder;
    }

    public string? GetName(KNOWN_FOLDER_FLAG flags = KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, SIGDN name = SIGDN.SIGDN_NORMALDISPLAY, bool throwOnError = true)
    {
        ComObject.Object.GetIDList((uint)flags, out var idl).ThrowOnError(throwOnError);
        if (idl == 0)
            return null;

        Functions.SHGetNameFromIDList(idl, name, out var path).ThrowOnError(throwOnError);
        var s = path.ToString();
        if (path.Value != 0)
            Marshal.FreeCoTaskMem(path.Value);

        return s;
    }

    public string? GetPath(KNOWN_FOLDER_FLAG flags = KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, bool throwOnError = true)
    {
        ComObject.Object.GetPath((uint)flags, out var path).ThrowOnError(throwOnError);
        var s = path.ToString();
        if (path.Value != 0)
            Marshal.FreeCoTaskMem(path.Value);

        return s;
    }

    public ItemIdList? GetIdList(KNOWN_FOLDER_FLAG flags = KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, bool throwOnError = true)
    {
        ComObject.Object.GetIDList((uint)flags, out var idl).ThrowOnError(throwOnError);
        if (idl == 0)
            return null;

        return new ItemIdList(idl, true);
    }

    public static string? GetPath(Guid id, KNOWN_FOLDER_FLAG flags = KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, bool throwOnError = false) => GetPath(id, 0, flags, throwOnError);
    public static string? GetPath(Guid id, HANDLE token, KNOWN_FOLDER_FLAG flags = KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, bool throwOnError = false)
    {
        var hr = Functions.SHGetKnownFolderPath(id, (uint)flags, token, out var path);
        if (hr != 0 && throwOnError)
            Marshal.ThrowExceptionForHR(hr);

        var s = path.ToString();
        if (path.Value != 0)
            Marshal.FreeCoTaskMem(path.Value);

        return s;
    }
}
