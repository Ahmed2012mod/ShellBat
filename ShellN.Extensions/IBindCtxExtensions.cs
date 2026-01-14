namespace ShellN.Extensions;

public static partial class IBindCtxExtensions
{
    private static readonly string[] _bindCtxParams =
    [
        "Allow binding to Internet shell folder handlers and negate STR_PARSE_PREFER_WEB_BROWSING",
        "Avoid Drive Restriction Policy",
        "DelegateNamedProperties",
        "Do not bind to Internet shell folder handlers",
        "Do not require validated URLs",
        "Don't Resolve Link",
        "ExplicitAssociationSuccessful",
        "ExplicitAssociationApp",
        "ExplicitProgid",
        "Delegate Object Creation",
        "Don't Parse Relative",
        "File System Bind Data",
        "Force Folder Shortcut Resolve",
        "Folder Enum Mode",
        "Folders As Read Only",
        "GetAsyncHandler",
        "GPS_HANDLERPROPERTIESONLY",
        "GPS_FASTPROPERTIESONLY",
        "GPS_OPENSLOWITEM",
        "GPS_DELAYCREATION",
        "GPS_BESTEFFORT",
        "GPS_NO_OPLOCK",
        "Internal Navigation",
        "ItemCacheContext",
        "NoValidateFilenameChars",
        "ParseWithProperties",
        "Parse Prefer Folder Browsing",
        "Parse Shell Protocol To File Objects",
        "Parse Translate Aliases",
        "ParseAndCreateItem",
        "ParseOriginalItem",
        "Skip Binding CLSID",
        "SHBindCtxPropertyBag",
        "SHCONTF",
        "Skip Net Resource Cache",
        "Show network diagnostics UI",
        "Validate URL",
        "Win7FileSystemIdList",
     ];

#pragma warning disable IDE1006 // Naming Styles
    private const string STR_FILE_SYS_BIND_DATA = "File System Bind Data";
#pragma warning restore IDE1006 // Naming Styles

    public static unsafe HWND GetHwnd(this IBindCtx ctx)
    {
        if (ctx == null)
            return 0;

        var op = new BIND_OPTS3();
        var ptr = (void*)&op;
        ctx.GetBindOptions(ref Unsafe.AsRef<BIND_OPTS>(ptr));
        return op.hwnd;
    }

    private static IEnumerable<string> ManualEnumObjectParams(IBindCtx ctx)
    {
        foreach (var name in _bindCtxParams)
        {
            ctx.GetObjectParam(PWSTR.From(name), out var unk);
            if (unk != 0)
                yield return name;
        }
    }

    public static IEnumerable<string> EnumObjectParams(this IBindCtx ctx)
    {
        if (ctx == null)
            yield break;

        ctx.EnumObjectParam(out var enumString);
        if (enumString == null)
        {
            foreach (var name in ManualEnumObjectParams(ctx))
            {
                yield return name;
            }
            yield break;
        }

        var strings = new PWSTR[1];
        do
        {

            if (enumString.Next(1, strings, 0) != 0)
                break;

            var str = strings[0];
            if (str.Value != 0)
                yield return str.ToString()!;
        }
        while (true);
    }

    public static unsafe IComObject<IBindCtx>? CreateBindCtx(STGM? mode = null, bool throwOnError = true)
    {
        var hr = DirectN.Functions.CreateBindCtx(0, out var ctx).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        if (mode.HasValue)
        {
            var opts3 = new BIND_OPTS3
            {
                Base = new BIND_OPTS2
                {
                    Base = new BIND_OPTS
                    {
                        cbStruct = (uint)sizeof(BIND_OPTS3),
                        grfMode = (uint)mode.Value
                    }
                }
            };

            var opts = *(BIND_OPTS*)&opts3;
            ctx.SetBindOptions(opts).ThrowOnError(throwOnError);
        }
        return new ComObject<IBindCtx>(ctx);
    }

    public static HRESULT AddToBindCtx(this IBindCtx bindContext, string name, object value, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(bindContext);
        ArgumentNullException.ThrowIfNull(name);
        var hr = bindContext.EnsureBindCtxPropertyBag(out var bag, throwOnError);
        if (hr != 0)
            return hr;

        using var variant = new Variant(value);
        return bag!.Write(PWSTR.From(name), variant.Detached).ThrowOnError(throwOnError);
    }

    public static IComObject<IPropertyBag>? EnsureBindCtxPropertyBag(this IComObject<IBindCtx> bindContext, bool getBag = false)
    {
        EnsureBindCtxPropertyBag(bindContext?.Object!, getBag, out var bag, true);
        if (bag == null)
            return null;

        return new ComObject<IPropertyBag>(bag);
    }

    public static HRESULT EnsureBindCtxPropertyBag(this IBindCtx bindContext, bool throwOnError = true) => EnsureBindCtxPropertyBag(bindContext, false, out _, throwOnError);
    public static HRESULT EnsureBindCtxPropertyBag(this IBindCtx bindContext, out IPropertyBag? bag, bool throwOnError) => EnsureBindCtxPropertyBag(bindContext, true, out bag, throwOnError);
    private static HRESULT EnsureBindCtxPropertyBag(this IBindCtx bindContext, bool getBag, out IPropertyBag? bag, bool throwOnError)
    {
        ArgumentNullException.ThrowIfNull(bindContext);

        const string STR_PROPERTYBAG_PARAM = "SHBindCtxPropertyBag";
        bindContext.GetObjectParam(PWSTR.From(STR_PROPERTYBAG_PARAM), out var unk);
        if (unk != 0)
        {
            if (getBag)
            {
                bag = (IPropertyBag)ComObject.ComWrappers.GetOrCreateObjectForComInstance(unk, CreateObjectFlags.UniqueInstance);
                Marshal.Release(unk);
                return DirectN.Constants.S_OK;
            }

            bag = null;
            return DirectN.Constants.S_OK;
        }

        var hr = Functions.PSCreateMemoryPropertyStore(typeof(IPropertyStore).GUID, out var psUnk).ThrowOnError(throwOnError);
        if (psUnk == 0)
        {
            bag = null;
            return hr;
        }

        try
        {
            hr = bindContext.RegisterObjectParam(PWSTR.From(STR_PROPERTYBAG_PARAM), psUnk).ThrowOnError(throwOnError);
            bag = (IPropertyBag)ComObject.ComWrappers.GetOrCreateObjectForComInstance(psUnk, CreateObjectFlags.UniqueInstance);
            return hr;
        }
        finally
        {
            Marshal.Release(psUnk);
        }
    }

    public static IComObject<IBindCtx>? CreateBindCtx(
        string name,
        STGM? mode = null,
        long? length = null,
        FileAttributes? attributes = null,
        DateTime? lastWriteTime = null,
        DateTime? creationTime = null,
        DateTime? lastAccessTime = null,
        bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(name);
        var data = new WIN32_FIND_DATAW { cFileName = Path.GetFileName(name) };

        if (length.HasValue)
        {
            data.nFileSizeHigh = (uint)(length.Value >> 32);
            data.nFileSizeLow = (uint)(length.Value & 0xFFFFFFFF);
        }

        if (attributes.HasValue)
        {
            data.dwFileAttributes = (uint)attributes.Value;
        }

        if (lastWriteTime.HasValue)
        {
            data.ftLastWriteTime = Conversions.ToPositiveFILETIME(lastWriteTime.Value);
        }

        if (creationTime.HasValue)
        {
            data.ftCreationTime = Conversions.ToPositiveFILETIME(creationTime.Value);
        }

        if (lastAccessTime.HasValue)
        {
            data.ftLastAccessTime = Conversions.ToPositiveFILETIME(lastAccessTime.Value);
        }

        var bindData = new FileSystemBindData2();
        bindData.SetFindData(data);
        var ctx = CreateBindCtx(mode, throwOnError);
        if (ctx != null)
        {
            var unk = ComObject.GetOrCreateComInstance(bindData);
            try
            {
                ctx.Object.RegisterObjectParam(PWSTR.From(STR_FILE_SYS_BIND_DATA), unk).ThrowOnError(throwOnError);
            }
            finally
            {
                Marshal.Release(unk);
            }
        }
        return ctx;
    }

    [System.Runtime.InteropServices.Marshalling.GeneratedComClass]
    private sealed partial class FileSystemBindData2 : IFileSystemBindData2
    {
        private WIN32_FIND_DATAW _data;
        private long _fileId;
        private Guid _clsid;

        public HRESULT SetFindData(in WIN32_FIND_DATAW data)
        {
            _data = data;
            return DirectN.Constants.S_OK;
        }

        public HRESULT GetFindData(out WIN32_FIND_DATAW data)
        {
            data = _data;
            return DirectN.Constants.S_OK;
        }

        public HRESULT SetFileID(long fileID)
        {
            _fileId = fileID;
            return DirectN.Constants.S_OK;
        }

        public HRESULT GetFileID(out long fileId)
        {
            fileId = _fileId;
            return DirectN.Constants.S_OK;
        }

        public HRESULT SetJunctionCLSID(in Guid clsid)
        {
            _clsid = clsid;
            return DirectN.Constants.S_OK;
        }

        public HRESULT GetJunctionCLSID(out Guid clsid)
        {
            clsid = _clsid;
            return DirectN.Constants.S_OK;
        }
    }
}
