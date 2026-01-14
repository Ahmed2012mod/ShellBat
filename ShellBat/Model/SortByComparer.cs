namespace ShellBat.Model;

public class SortByComparer(SortBy sortBy, SortDirection sortDirection, EntryEnumerateOptions options) : IComparer<Entry>
{
    public virtual int Compare(Entry? x, Entry? y)
    {
        if (x is null)
        {
            if (y is null)
                return 0;

            return 1;
        }
        else if (y is null)
            return -1;

        var xo = x.GetWebOptions(options);
        var yo = y.GetWebOptions(options);
        if (xo.HasFlag(WebEntryOptions.IsFolder))
        {
            if (!yo.HasFlag(WebEntryOptions.IsFolder))
                return -1;
        }
        else if (yo.HasFlag(WebEntryOptions.IsFolder))
            return 1;

        var result = sortBy switch
        {
            SortBy.Name => ShellN.Functions.StrCmpLogicalW(PWSTR.From(x.DisplayName), PWSTR.From(y.DisplayName)),
            SortBy.Size => x.Size.CompareTo(y.Size),
            SortBy.DateModified => Compare(x.LastWriteTime, y.LastWriteTime),
            SortBy.Extension => Entry.CompareExtensions(x, y),
            SortBy.Unspecified => 0,
            _ => throw new ShellBatException($"0006: Internal error.")

        };
        return sortDirection == SortDirection.Ascending ? result : -result;
    }

    private static int Compare(DateTime? x, DateTime? y)
    {
        if (x.HasValue)
        {
            if (y.HasValue)
                return x.Value.CompareTo(y.Value);

            return 1;
        }
        else if (y.HasValue)
            return -1;

        return 0;
    }
}
