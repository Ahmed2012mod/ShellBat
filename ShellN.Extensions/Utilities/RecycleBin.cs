namespace ShellN.Extensions.Utilities;

public sealed partial class RecycleBin : InterlockedComObject<IRecycleBin>
{
    public RecycleBin()
        : base(DirectN.Extensions.Com.ComObject.CoCreate<IRecycleBin>(Constants.CLSID_RecycleBinManager))
    {
    }

    public bool IsEmpty => NativeObject.IsEmpty().IsOk;
    public long ItemCount { get { NativeObject.GetItemCount(out var count); return count; } }
    public long UsedSpace { get { NativeObject.GetUsedSpace(out var usedSpace); return usedSpace; } }

    public static ShellFolder? GetFolder(bool owned = true)
    {
        using var kf = KnownFolder.Get(Constants.FOLDERID_RecycleBinFolder);
        return kf?.ToFolder(KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT, owned: owned);
    }

    // another (preferred) way is simply to use the standard IShellItem stuff,
    // we should get the exact same info
    public unsafe IEnumerable<RecycledItem> Enumerate(uint flags = 64 /* don't ask */, bool throwOnError = false)
    {
        NativeObject.EnumItems(flags, out var itemsObj).ThrowOnError(throwOnError);
        if (itemsObj == null)
            yield break;

        using var items = new ComObject<IEnumRecycleItems>(itemsObj);
        var deleted = new DELETEDITEM[1];
        do
        {
            if (items.Object.Next(1, deleted, 0) != 0)
                break;

            yield return new RecycledItem(deleted[0]);
        }
        while (true);
    }

    public HRESULT PurgeAll(FileOperation operation, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(operation);
        return NativeObject.PurgeAll(operation.NativeObject).ThrowOnError(throwOnError);
    }

    public HRESULT RestoreAll(Func<FileOperation>? getOperation = null, bool throwOnError = true)
    {
        using var folder = GetFolder();
        if (folder == null)
            return DirectN.Constants.E_FAIL;

        getOperation ??= () => new FileOperation();
        var items = folder.EnumerateChildren().ToArray();
        try
        {
            using var op = getOperation();
            var hr = RestoreItems(items, op, throwOnError);
            if (hr.IsError)
                return hr;

            return op.PerformOperations(throwOnError);
        }
        finally
        {
            items.Dispose();
        }
    }

    public HRESULT RestoreItem(ShellItem item, FileOperation operation, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(item);
        ArgumentNullException.ThrowIfNull(operation);
        return NativeObject.RestoreItem(item.NativeObject, operation.NativeObject).ThrowOnError(throwOnError);
    }

    public HRESULT RestoreItems(IEnumerable<ShellItem> items, FileOperation operation, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(items);
        ArgumentNullException.ThrowIfNull(operation);
        using var array = items.ToShellItemArray(throwOnError);
        if (array == null)
            return DirectN.Constants.E_FAIL;

        return NativeObject.RestoreItems(array.Object, operation.NativeObject).ThrowOnError(throwOnError);
    }
}
