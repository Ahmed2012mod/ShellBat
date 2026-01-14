namespace ShellBat.Windows;

public sealed partial class WindowsSearch : InterlockedComObject<IDBInitialize>
{
    private IComObject<ISearchQueryHelper>? _queryHelper;
    private IComObject<ISearchCatalogManager>? _catalogManager;

    public WindowsSearch()
        : base()
    {
        using var mgr = DirectN.Extensions.Com.ComObject.CoCreate<ISearchManager>(ShellN.Constants.CSearchManager)!;
        mgr.Object.GetCatalog(PWSTR.From("SystemIndex"), out var obj).ThrowOnError();
        _catalogManager = new ComObject<ISearchCatalogManager>(obj)!;
        _catalogManager.Object.GetQueryHelper(out var helperObj).ThrowOnError();
        _queryHelper = new ComObject<ISearchQueryHelper>(helperObj);
        _queryHelper.Object.get_ConnectionString(out var p).ThrowOnError();
        ConnectionString = p.ToStringAndDispose()!;

        using var initialize = DirectN.Extensions.Com.ComObject.CoCreate<IDataInitialize>(ShellN.Constants.MSDAINITIALIZE)!;
        nint unk = 0;
        initialize.Object.GetDataSource(0, (uint)CLSCTX.CLSCTX_ALL, PWSTR.From(ConnectionString), typeof(IDBInitialize).GUID, ref unk).ThrowOnError();
        var dbInitialize = DirectN.Extensions.Com.ComObject.FromPointer<IDBInitialize>(unk)!;
        dbInitialize.Object.Initialize().ThrowOnError();
        ExchangeDisposable(dbInitialize);
    }

    public string ConnectionString { get; }

    public int KeywordLocale
    {
        get
        {
            var qh = _queryHelper;
            if (qh == null)
                return 0;

            qh.Object.get_QueryKeywordLocale(out var lcid);
            return (int)lcid;
        }
        set
        {
            var qh = _queryHelper;
            if (qh == null)
                return;

            qh.Object.put_QueryKeywordLocale((uint)value);
        }
    }

    public int ContentLocale
    {
        get
        {
            var qh = _queryHelper;
            if (qh == null)
                return 0;

            qh.Object.get_QueryContentLocale(out var lcid);
            return (int)lcid;
        }
        set
        {
            var qh = _queryHelper;
            if (qh == null)
                return;

            qh.Object.put_QueryContentLocale((uint)value);
        }
    }

    public int MaxResults
    {
        get
        {
            var qh = _queryHelper;
            if (qh == null)
                return 0;

            qh.Object.get_QueryMaxResults(out var maxResults);
            return maxResults;
        }
        set
        {
            var qh = _queryHelper;
            if (qh == null)
                return;

            qh.Object.put_QueryMaxResults(value);
        }
    }

    public SEARCH_QUERY_SYNTAX QuerySyntax
    {
        get
        {
            var qh = _queryHelper;
            if (qh == null)
                return SEARCH_QUERY_SYNTAX.SEARCH_NO_QUERY_SYNTAX;

            qh.Object.get_QuerySyntax(out var syntax);
            return syntax;
        }
        set
        {
            var qh = _queryHelper;
            if (qh == null)
                return;

            qh.Object.put_QuerySyntax(value);
        }
    }

    public SEARCH_TERM_EXPANSION TermExpansion
    {
        get
        {
            var qh = _queryHelper;
            if (qh == null)
                return SEARCH_TERM_EXPANSION.SEARCH_TERM_NO_EXPANSION;

            qh.Object.get_QueryTermExpansion(out var expansion);
            return expansion;
        }
        set
        {
            var qh = _queryHelper;
            if (qh == null)
                return;
            qh.Object.put_QueryTermExpansion(value);
        }
    }

    public string? ContentProperties
    {
        get
        {
            var qh = _queryHelper;
            if (qh == null)
                return null;

            qh.Object.get_QueryContentProperties(out var p);
            return p.ToStringAndDispose();
        }
        set
        {
            var qh = _queryHelper;
            if (qh == null)
                return;

            qh.Object.put_QueryContentProperties(PWSTR.From(value));
        }
    }

    public string? WhereRestrictions
    {
        get
        {
            var qh = _queryHelper;
            if (qh == null)
                return null;

            qh.Object.get_QueryWhereRestrictions(out var p);
            return p.ToStringAndDispose();
        }
        set
        {
            var qh = _queryHelper;
            if (qh == null)
                return;

            qh.Object.put_QueryWhereRestrictions(PWSTR.From(value));
        }
    }

    public string? SelectColumns
    {
        get
        {
            var qh = _queryHelper;
            if (qh == null)
                return null;

            qh.Object.get_QuerySelectColumns(out var p);
            return p.ToStringAndDispose();
        }
        set
        {
            var qh = _queryHelper;
            if (qh == null)
                return;

            qh.Object.put_QuerySelectColumns(PWSTR.From(value));
        }
    }

    public string? Sorting
    {
        get
        {
            var qh = _queryHelper;
            if (qh == null)
                return null;

            qh.Object.get_QuerySorting(out var p);
            return p.ToStringAndDispose();
        }
        set
        {
            var qh = _queryHelper;
            if (qh == null)
                return;

            qh.Object.put_QuerySorting(PWSTR.From(value));
        }
    }

    public HRESULT TryIncludedInCrawlScope(string url, out bool isIncluded, out CLUSION_REASON reason)
    {
        ArgumentNullException.ThrowIfNull(url);

        isIncluded = false;
        reason = CLUSION_REASON.CLUSIONREASON_UNKNOWNSCOPE;
        var cm = _catalogManager;
        if (cm == null)
            return DirectN.Constants.E_FAIL;

        var hr = cm.Object.GetCrawlScopeManager(out var managerObj);
        if (hr.IsError)
            return hr;

        using var manager = new DirectN.Extensions.Com.ComObject<ISearchCrawlScopeManager>(managerObj)!;
        hr = manager.Object.IncludedInCrawlScopeEx(PWSTR.From(url), out var included, out reason);
        isIncluded = included;
        return hr;
    }

    public HRESULT TryGenerateSQLFromUserQuery(string query, out string? sql)
    {
        ArgumentNullException.ThrowIfNull(query);
        var qh = _queryHelper;
        if (qh == null)
        {
            sql = null;
            return DirectN.Constants.E_FAIL;
        }

        var hr = qh.Object.GenerateSQLFromUserQuery(PWSTR.From(query), out var p);
        if (hr.IsError)
        {
            sql = null;
            return hr;
        }

        sql = p.ToStringAndDispose();
        return DirectN.Constants.S_OK;
    }

    public unsafe Exception? TryExecuteSql(string sql, out WindowsSearchResult? result)
    {
        ArgumentNullException.ThrowIfNull(sql);

        result = null;
        var session = NativeObject.As<IDBCreateSession>()!;
        var hr = session.CreateSession(0, typeof(IDBCreateCommand).GUID, out var unk);
        if (hr.IsError)
            return ComError.GetError(hr) ?? Marshal.GetExceptionForHR(hr);

        using var command = DirectN.Extensions.Com.ComObject.FromPointer<IDBCreateCommand>(unk)!;

        hr = command.Object.CreateCommand(0, typeof(ICommandText).GUID, out unk);
        if (hr.IsError)
            return ComError.GetError(hr) ?? Marshal.GetExceptionForHR(hr);

        using var commandText = DirectN.Extensions.Com.ComObject.FromPointer<ICommandText>(unk)!;

        hr = commandText.Object.SetCommandText(ShellN.Constants.DBGUID_DEFAULT, PWSTR.From(sql));
        if (hr.IsError)
            return ComError.GetError(hr) ?? Marshal.GetExceptionForHR(hr);

        nint rowsAffected = 0;
        hr = commandText.Object.Execute(0, typeof(IRowset).GUID, 0, (nint)(&rowsAffected), (nint)(&unk));
        if (hr.IsError)
            return ComError.GetError(hr) ?? Marshal.GetExceptionForHR(hr);

        var rowset = DirectN.Extensions.Com.ComObject.FromPointer<IRowset>(unk)!;
        result = new WindowsSearchResult(rowset);
        return null;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Interlocked.Exchange(ref _queryHelper, null)?.Dispose();
            Interlocked.Exchange(ref _catalogManager, null)?.Dispose();
        }
        base.Dispose(disposing);
    }
}
