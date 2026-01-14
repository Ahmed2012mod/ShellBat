namespace ShellN.Extensions;

public static class IShellItemArrayExtensions
{
    public static IEnumerable<ShellItem> Enumerate(this IComObject<IShellItemArray>? array, bool noFolder = false, bool owned = true, bool throwOnError = false) => Enumerate(array?.Object, noFolder, owned, throwOnError);
    public static IEnumerable<ShellItem> Enumerate(this IShellItemArray? array, bool noFolder = false, bool owned = true, bool throwOnError = false)
    {
        if (array == null)
            yield break;

        array.GetCount(out var count).ThrowOnError(throwOnError);
        for (uint i = 0; i < count; i++)
        {
            array.GetItemAt(i, out var item).ThrowOnError(throwOnError);
            if (item != null)
            {
                var si = ShellItem.FromObject(item, noFolder, owned);
                if (si != null)
                    yield return si;
            }
        }
    }

    public unsafe static IComObject<IShellItemArray>? ToShellItemArray(this IEnumerable<ShellItem> items, bool throwOnError = false)
    {
        ArgumentNullException.ThrowIfNull(items);
        var idLists = new List<ItemIdList>();
        var pidls = new List<nint>();
        foreach (var item in items)
        {
            var idl = item.GetIdList()!;
            idLists.Add(idl);
            pidls.Add(idl.Pointer);
        }

        try
        {
            var hr = Functions.SHCreateShellItemArrayFromIDLists(pidls.Length(), [.. pidls], out var arrayObj).ThrowOnError(throwOnError);
            if (hr.IsError)
                return null;

            return new ComObject<IShellItemArray>(arrayObj)!;
        }
        finally
        {
            idLists.Dispose();
        }
    }
}
