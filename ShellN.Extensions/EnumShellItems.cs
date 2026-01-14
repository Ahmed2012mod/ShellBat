namespace ShellN.Extensions;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class EnumShellItems : IEnumShellItems
{
    private readonly IEnumerator<IShellItem> _enumerator;

    public EnumShellItems(IEnumerable<IShellItem> items)
    {
        _enumerator = items.GetEnumerator();
    }

    unsafe HRESULT IEnumShellItems.Next(uint celt, nint[] rgelt, nint pceltFetched)
    {
        uint fetched = 0;
        while (fetched < celt && _enumerator.MoveNext())
        {
            ComObject.WithComInstanceOfType<IShellItem>(_enumerator.Current, unk =>
            {
                rgelt[fetched] = unk;
            }, createIfNeeded: true);
            fetched++;
        }

        if (pceltFetched != 0)
        {
            *(uint*)pceltFetched = fetched;
        }

        return fetched == celt ? DirectN.Constants.S_OK : DirectN.Constants.S_FALSE;
    }

    HRESULT IEnumShellItems.Clone(out IEnumShellItems ppenum)
    {
        var items = new List<IShellItem>();
        var currentEnumerator = _enumerator;
        while (currentEnumerator.MoveNext())
        {
            items.Add(currentEnumerator.Current);
        }

        ppenum = new EnumShellItems(items);
        return DirectN.Constants.S_OK;
    }

    HRESULT IEnumShellItems.Reset()
    {
        _enumerator.Reset();
        return DirectN.Constants.S_OK;
    }

    HRESULT IEnumShellItems.Skip(uint celt)
    {
        uint skipped = 0;
        while (skipped < celt && _enumerator.MoveNext())
        {
            skipped++;
        }
        return skipped == celt ? DirectN.Constants.S_OK : DirectN.Constants.S_FALSE;
    }
}
