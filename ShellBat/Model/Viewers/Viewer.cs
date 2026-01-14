namespace ShellBat.Model.Viewers;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public abstract partial class Viewer : DispatchObject, IDisposable
{
    public const int FileExtensionMatchPriority = 10000;

    protected Viewer(Entry entry)
    {
        ArgumentNullException.ThrowIfNull(entry);
        Entry = entry;
        Id = GetType().Name;
        if (Id.EndsWith(nameof(Viewer)))
        {
            Id = Id[..^nameof(Viewer).Length];
        }
        Title = Res.ResourceManager.GetString(Id) ?? Id;
    }

    public Entry Entry { get; }
    public virtual bool IsSupported => false;
    public virtual int Priority => 0;
    public virtual string Id { get; protected set; }
    public virtual string Title { get; }
    public virtual string? Icon => null;
    public virtual int SortOrder => 0;
    public virtual Task<WebPropertyGrid?> GetProperties() => Task.FromResult<WebPropertyGrid?>(null);

    public override string ToString() => Id;

    protected override object? GetTaskResult(Task task)
    {
        if (task is Task<WebPropertyGrid?> pgTask)
            return pgTask.Result;

        if (task is Task<string> strTask)
            return strTask.Result;

        return base.GetTaskResult(task);
    }

    public static IEnumerable<Viewer> GetSupportedViewers(Entry entry)
    {
        ArgumentNullException.ThrowIfNull(entry);
        return GetAvailableInstances(entry).Where(v => v.IsSupported);
    }

    private static IEnumerable<Viewer> GetAvailableInstances(Entry entry)
    {
        yield return new AudioViewer(entry);
        yield return new BinaryViewer(entry);
        yield return new DetailsViewer(entry);
        yield return new ExecutableViewer(entry);
        yield return new GeneralViewer(entry);
        yield return new ImageViewer(entry);
        yield return new MarkdownViewer(entry);
        yield return new CodeViewer(entry);
        yield return new PdfViewer(entry);
        yield return new PreviewViewer(entry);
        yield return new TextViewer(entry);
        yield return new VideoViewer(entry);
    }

    // expose Dispose for all viewers so js can call Dispose w/o knowning if it's really needed or not
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
    protected virtual void Dispose(bool disposing)
    {
    }
}
