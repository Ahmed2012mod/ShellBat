namespace ShellBat.Utilities;

public partial class EntryWatcher : IDisposable
{
    private bool _disposedValue;
    private readonly ChangeNotifier? _notifier;
    private readonly ItemIdList? _pidl;
    private readonly FileSystemWatcher? _watcher;

    public event EventHandler<EntryWatcherEventArgs>? Event;

    public EntryWatcher(Entry entry)
    {
        ArgumentNullException.ThrowIfNull(entry);
        if (IOUtilities.PathIsDirectory(entry.ParsingName))
        {
            _watcher = new FileSystemWatcher(entry.ParsingName)
            {
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.Size,
                IncludeSubdirectories = false,
            };

            _watcher.Created += OnWatcherEvent;
            _watcher.Deleted += OnWatcherEvent;
            _watcher.Changed += OnWatcherEvent;
            _watcher.Renamed += OnWatcherEvent;
        }
        else if (entry.IsFolder)
        {
            _pidl = entry.GetIdList(false);
            if (_pidl is not null)
            {
                _notifier = new ChangeNotifier();
                _notifier.Notified += OnNotifierNotified;
            }
        }
    }

    public virtual void Run()
    {
        if (_watcher != null)
        {
            _watcher.EnableRaisingEvents = true;
        }
        else
        {
            _notifier?.Run(_pidl, recursive: false,
                SHCNE_ID.SHCNE_ATTRIBUTES |
                SHCNE_ID.SHCNE_DELETE |
                SHCNE_ID.SHCNE_RENAMEITEM |
                SHCNE_ID.SHCNE_CREATE |
                SHCNE_ID.SHCNE_MKDIR |
                SHCNE_ID.SHCNE_RMDIR |
                SHCNE_ID.SHCNE_UPDATEDIR |
                SHCNE_ID.SHCNE_UPDATEITEM |
                SHCNE_ID.SHCNE_UPDATEIMAGE |
                SHCNE_ID.SHCNE_RENAMEFOLDER
            );
        }
    }

    protected virtual void OnEvent(object sender, EntryWatcherEventArgs e) => Event?.Invoke(sender, e);

    private void OnNotifierNotified(object? sender, ChangeNotifyEventArgs e)
    {
        EntryWatcherEventType type;
        switch (e.Event)
        {
            case SHCNE_ID.SHCNE_MKDIR:
            case SHCNE_ID.SHCNE_CREATE:
                type = EntryWatcherEventType.Created;
                break;

            case SHCNE_ID.SHCNE_DELETE:
            case SHCNE_ID.SHCNE_RMDIR:
                type = EntryWatcherEventType.Deleted;
                break;

            case SHCNE_ID.SHCNE_ATTRIBUTES:
            case SHCNE_ID.SHCNE_UPDATEDIR:
            case SHCNE_ID.SHCNE_UPDATEITEM:
            case SHCNE_ID.SHCNE_UPDATEIMAGE:
                type = EntryWatcherEventType.Changed;
                break;

            case SHCNE_ID.SHCNE_RENAMEITEM:
            case SHCNE_ID.SHCNE_RENAMEFOLDER:
                type = EntryWatcherEventType.Renamed;
                break;

            default:
                return;
        }

        var ewe = new EntryWatcherEventArgs(type, Entry.Get(null, e.IdList1), Entry.Get(null, e.IdList2));
        OnEvent(sender!, ewe);
    }

    private void OnWatcherEvent(object sender, FileSystemEventArgs e)
    {
        EntryWatcherEventType type;
        switch (e.ChangeType)
        {
            case WatcherChangeTypes.Created:
                type = EntryWatcherEventType.Created;
                break;

            case WatcherChangeTypes.Deleted:
                type = EntryWatcherEventType.Deleted;
                break;

            case WatcherChangeTypes.Changed:
                type = EntryWatcherEventType.Changed;
                break;

            case WatcherChangeTypes.Renamed:
                type = EntryWatcherEventType.Renamed;
                break;

            default:
                return;
        }

        EntryWatcherEventArgs ewe;
        if (e is RenamedEventArgs renamedEvent)
        {
            // must create shell item for non existing entry (renamed entry)
            var context = IBindCtxExtensions.CreateBindCtx(renamedEvent.OldFullPath);
            ewe = new EntryWatcherEventArgs(
                type,
                Entry.Get(null, renamedEvent.FullPath, ShellItemParsingOptions.DontThrowOnError),
                Entry.Get(null, renamedEvent.OldFullPath, ShellItemParsingOptions.DontThrowOnError, context));
        }
        else
        {
            if (type == EntryWatcherEventType.Deleted)
            {
                // must create shell item for non existing entry (deleted entry)
                var context = IBindCtxExtensions.CreateBindCtx(e.FullPath);
                ewe = new EntryWatcherEventArgs(type, Entry.Get(null, e.FullPath, ShellItemParsingOptions.DontThrowOnError, context));
            }
            else
            {
                ewe = new EntryWatcherEventArgs(type, Entry.Get(null, e.FullPath, ShellItemParsingOptions.DontThrowOnError));
            }
        }
        OnEvent(sender, ewe);
    }

    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                _notifier?.Dispose();
                _watcher?.Dispose();
                _pidl?.Dispose();
            }

            _disposedValue = true;
        }
    }
}
