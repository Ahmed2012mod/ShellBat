namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebFolder(ShellBatWindow window, Entry entry) : DispatchObject
{
    private List<Entry>? _entries;

#pragma warning disable CA1822 // Mark members as static
    public Entry Entry { get; } = entry ?? throw new ArgumentNullException(nameof(entry));
    public string ParsingName => entry.ParsingName;
    public string DisplayName => entry.DisplayName;
    public string EditName => entry.EditName;
    public string? UpParsingName => entry.Parent?.ParsingName;
    public string? UpFullDisplayName => entry.Parent?.FullDisplayName;
    public string? BackFullDisplayName
    {
        get
        {
            var entry = History.Current.PreviousEntry;
            if (entry == null)
                return null;

            return Entry.Get(null, entry.ParsingName, ShellItemParsingOptions.DontThrowOnError)?.FullDisplayName;
        }
    }

    public string? ForwardFullDisplayName
    {
        get
        {
            var entry = History.Current.NextEntry;
            if (entry == null)
                return null;

            return Entry.Get(null, entry.ParsingName, ShellItemParsingOptions.DontThrowOnError)?.FullDisplayName;
        }
    }

    private List<Entry> GetEntries()
    {
        // add a view info as first element
        var entries = new List<Entry>();
        foreach (var entry in Entry.EnumerateChildren(EntryEnumerateOptions.IncludeHidden | EntryEnumerateOptions.IncludeSystem))
        {
            entries.Add(entry);
            if ((entries.Count % 100) == 0)
            {
                window.ShowLoading(true);
            }
        }
        return entries;
    }

    public unsafe VARIANT GetChildrenView(
        EntryViewType view,
        EntryEnumerateOptions options = EntryEnumerateOptions.None,
        SortBy sortBy = SortBy.Unspecified,
        SortDirection sortDirection = SortDirection.Ascending,
        string? viewFilter = null,
        int startIndex = 0,
        int pageSize = 0)
    {
        var sp = Stopwatch.StartNew();
        if (pageSize <= 0)
        {
            pageSize = int.MaxValue;
        }

        if (options.HasFlag(EntryEnumerateOptions.DontUseCache) || _entries == null)
        {
            _entries = GetEntries();
            //Application.TraceVerbose($"WebFolder.GetChildrenView('{ParsingName}') loaded {_entries.Count} entries in {sp.ElapsedMilliseconds} ms");
            sp.Restart();
        }

        if (startIndex == 0)
        {
            _entries.Sort(new SortByComparer(sortBy, sortDirection, options));
            //Application.TraceVerbose($"WebFolder.GetChildrenView('{ParsingName}') sorted {_entries.Count} entries in {sp.ElapsedMilliseconds} ms");
            sp.Restart();
        }

        // an array is the fastest way to communicate a big list of things to WebView2
        var imagesOnly = options.HasFlag(EntryEnumerateOptions.ImagesOnly);

        // special cases for shell:appsFolder
        if (Entry.IsApplications)
        {
            sortBy = SortBy.Name;
        }

        // add a view info as first element
        var entries = new List<Entry>();
        foreach (var entry in _entries.Skip(startIndex).Take(pageSize))
        {
            if (!options.HasFlag(EntryEnumerateOptions.IncludeHidden) && entry.IsHidden)
                continue;

            if (!options.HasFlag(EntryEnumerateOptions.IncludeSystem) && entry.IsSystem)
                continue;

            if (options.HasFlag(EntryEnumerateOptions.ExcludeFolders) && entry.IsFolder)
                continue;

            if (options.HasFlag(EntryEnumerateOptions.ExcludeFiles) && !entry.IsFolder)
                continue;

            if (viewFilter != null &&
                !entry.DisplayName.Contains(viewFilter, StringComparison.OrdinalIgnoreCase))
                continue;

            // we need to display folders for navigation
            if (view == EntryViewType.Images &&
                imagesOnly &&
                !entry.IsFolder &&
                !entry.Extension.IsImage)
                continue;

            entries.Add(entry);
            var name = entry.DisplayName;
            if ((entries.Count % 100) == 0)
            {
                window.ShowLoading(true);
            }
        }

        var list = new List<Entry>();
        var info = new ViewInfo
        {
            IsLast = entries.Count < pageSize
        };

        foreach (var entry in entries)
        {
            list.Add(entry);
            var name = entry.DisplayName;
            if (name.Length > info.MaxNameLength)
            {
                info.MaxNameLength = name.Length;
            }

            var size = entry.FormattedSize;
            if (size.Length > info.MaxSizeLength)
            {
                info.MaxSizeLength = size.Length;
            }

            if ((list.Count % 100) == 0)
            {
                window.ShowLoading(true);
            }
        }

        var bounds = new SAFEARRAYBOUND { cElements = list.Length() + 1 };
        var sa = DirectN.Functions.SafeArrayCreate(VARENUM.VT_VARIANT, 1, bounds);
        if (sa == 0)
            throw new OutOfMemoryException();

        var psa = (SAFEARRAY*)sa;
        try
        {
            DirectN.Functions.SafeArrayAccessData(*psa, out var data).ThrowOnError();
            var vptr = (VARIANT*)data;

            var va = new Variant(info, VARENUM.VT_DISPATCH);
            vptr[0] = va.Detach();

            for (var i = 0; i < list.Count + 0; i++)
            {
                var v = GetViewVARIANT(list[i], view, options);
                vptr[i + 1] = v;

                if ((entries.Count % 100) == 0)
                {
                    window.ShowLoading(true);
                }
            }
        }
        catch
        {
            ShellBatInstance.LogError($"Failed to get children for WebFolder '{ParsingName}'");
            DirectN.Functions.SafeArrayDestroy(*psa);
            throw;
        }
        finally
        {
            window.ShowLoading(false);
            DirectN.Functions.SafeArrayUnaccessData(*psa).ThrowOnError();
        }

        var result = new VARIANT();
        result.Anonymous.Anonymous.vt = VARENUM.VT_VARIANT | VARENUM.VT_ARRAY;
        result.Anonymous.Anonymous.Anonymous.parray = sa;

        //Application.TraceVerbose($"WebFolder.GetChildrenView('{ParsingName}') returned {list.Count} items in {sp.ElapsedMilliseconds} ms");
        return result;
    }

    private static VARIANT GetViewVARIANT(Entry entry, EntryViewType type, EntryEnumerateOptions enumerateOptions)
    {
        Variant variant;
        switch (type)
        {
            default:
                var options = entry.GetWebOptions(enumerateOptions);
                var details = new string?[]
                {
                    entry.ParsingName,
                    entry.FormattedLastWriteTime,
                    entry.FormattedSize,
                    entry.DisplayName,
                    options == WebEntryOptions.None ? null : ((int)options).ToString(),
                };

                // we can't use a variant or variant because of a bug in WebView2
                // https://github.com/MicrosoftEdge/WebView2Feedback/issues/3183
                variant = new Variant(string.Join('|', details));
                return variant.Detach();
        }
    }

    public override string ToString() => ParsingName;
#pragma warning restore CA1822 // Mark members as static
}
