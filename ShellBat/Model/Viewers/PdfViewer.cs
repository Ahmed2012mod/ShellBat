using Windows.Data.Pdf;
using Windows.Storage;

namespace ShellBat.Model.Viewers;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class PdfViewer(Entry entry) : Viewer(entry)
{
    public const string SaveDefaultFormat = ".png";

    private static int _documentId;
    private static readonly Dictionary<int, PdfDocument> _documents = [];

    private PdfDocument? _document;
    private int _id;
    private uint _currentPage;

    public virtual bool IsPasswordProtected { get; protected set; }
    public override int Priority => FileExtensionMatchPriority;
    public override string? Icon => "fa-regular fa-file-pdf";
    public override bool IsSupported
    {
        get
        {
            if (Entry.Extension.IsPdf)
                return true;

            return base.IsSupported;
        }
    }

    public override async Task<WebPropertyGrid?> GetProperties()
    {
        await LoadDocument();
        if (_document == null || _document.IsPasswordProtected)
            return null;

        var props = new PdfProperties(this);
        var grid = WebPropertyGrid.Reflect(props);
        grid.Options.GroupByCategory = false;
        grid.Options.IsReadOnly = true;
        grid.Options.BaseClassName = "viewer-Pdf-pg";
        return grid;
    }

    public async Task<string?> GetPageUrl(uint size, uint page)
    {
        await LoadDocument();
        _currentPage = page;
        if (_document == null || IsPasswordProtected)
            return null;

        var encodedPath = ShellBatHttpLocalServer.EscapeUrl(Entry.ParsingName);
        var url = $"{ShellBatInstance.Current.HttpServer.Url}{UrlType.PdfPage}/{encodedPath}?page={page}&size={size}&id{_id}";
        return url;
    }

    protected virtual async Task LoadDocument()
    {
        if (_document != null)
            return;

        try
        {
            var file = await StorageFile.GetFileFromPathAsync(Entry.ParsingName);
            _document = await PdfDocument.LoadFromFileAsync(file);
            IsPasswordProtected = false;
        }
        catch (Exception ex)
        {
            if (ex.HResult == DirectN.Constants.ERROR_WRONG_PASSWORD)
            {
                IsPasswordProtected = true;
            }
            else
            {
                ShellBatInstance.LogError($"Error loading PDF document '{Entry.ParsingName}': {ex}");
            }
            return;
        }

        if (ShellBatInstance.Current.Options.HasFlag(ShellBatInstanceOptions.IsLocalHttpServer))
        {
            _id = Interlocked.Increment(ref _documentId);
            _documents[_id] = _document;
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Interlocked.Exchange(ref _document, null);
            _documents.Remove(_id);
            _id = 0;
        }
        base.Dispose(disposing);
    }

    public virtual bool SavePage()
    {
        if (_document == null)
            return false;

        using var fsd = new FileSaveDialog();
        fsd.SetOptions(FileSaveDialog.DefaultOptions | FILEOPENDIALOGOPTIONS.FOS_NOCHANGEDIR);
        var images = WicImagingComponent.EncoderFileExtensions
            .Where(ext => FileExtension.GetByExtension(ext).IsImage)
            .Select(ext => $"{FileExtension.GetDisplayName(ext)} (*{ext})|*{ext}").ToArray();
        fsd.SetFileTypes(images);

        var format = Settings.Current.PdfSaveDefaultFormat ?? SaveDefaultFormat;
        var pngIndex = Array.FindIndex(images, t => t.EndsWith(format, StringComparison.OrdinalIgnoreCase));
        if (pngIndex >= 0)
        {
            fsd.SetFileTypeIndex((uint)(pngIndex + 1));
            fsd.SetDefaultExtension(format.TrimStart('.'));
        }

        fsd.SetFileName($"{Path.GetFileNameWithoutExtension(Entry.DisplayName)}_{_currentPage + 1}{format}");
        fsd.SetTitle(Res.SavePage);
        if (!fsd.Show(Program.MainWindow?.Handle ?? HWND.Null))
            return false;

        using var result = fsd.GetResult();
        if (result == null || result.Extension == null || result.SIGDN_NORMALDISPLAY == null)
            return false;

        using var folder = result.GetParent();
        if (folder == null)
            return false;

        using var newItem = folder.CreateNewItem(result.SIGDN_NORMALDISPLAY, makeUniqueName: false);
        if (newItem == null)
            return false;

        using var ctx = IBindCtxExtensions.CreateBindCtx(STGM.STGM_WRITE)!;
        newItem.ComObject.Object.BindToHandler(ctx.Object, ShellN.Constants.BHID_Stream, typeof(DirectN.IStream).GUID, out var unk);
        var strm = ComObject.FromPointer<DirectN.IStream>(unk);
        if (strm == null)
            return false;

        using var stream = new StreamOnIStream(strm.Object, true);
        SavePage(_document, _currentPage, stream, result.Extension);
        return true;
    }

    public virtual bool SaveAllPages()
    {
        if (_document == null)
            return false;

        using var fsd = new FileOpenDialog();
        fsd.SetOptions(FileOpenDialog.DefaultOptions | FILEOPENDIALOGOPTIONS.FOS_PICKFOLDERS | FILEOPENDIALOGOPTIONS.FOS_NOCHANGEDIR);
        var format = Settings.Current.PdfSaveDefaultFormat ?? SaveDefaultFormat;
        fsd.SetTitle(string.Format(Res.SaveAllPagesChooseFolder, format));
        if (!fsd.Show(Program.MainWindow?.Handle ?? HWND.Null))
            return false;

        using var folder = fsd.GetResult() as ShellFolder;
        if (folder == null)
            return false;

        var parsingName = folder.SIGDN_DESKTOPABSOLUTEPARSING;
        if (parsingName == null)
            return false;

        var progress = new ProgressDialog();
        progress.Initialize(_SPINITF.SPINITF_NORMAL, Res.SaveAllPages, Res.Cancel);
        progress.Begin(SPACTION.SPACTION_CALCULATING, _SPBEGINF.SPBEGINF_NORMAL);

        TaskUtilities.RunWithSTAThread(() =>
        {
            using var item = ShellItem.FromParsingName(parsingName, throwOnError: false);
            if (item is ShellFolder folder)
            {
                for (uint i = 0; i < _document.PageCount; i++)
                {
                    if (progress.QueryCancel())
                        break;

                    progress.UpdateProgress(i, _document.PageCount);
                    progress.UpdateActionDetail($"{100 * i / _document.PageCount} %", true);
                    progress.UpdateActionDescription(string.Format(Res.SavingPage, i + 1, _document.PageCount), true);

                    var fileName = $"{Path.GetFileNameWithoutExtension(Entry.DisplayName)}_{i + 1}{format}";
                    using var newItem = folder.CreateNewItem(fileName);
                    if (newItem == null)
                        break;

                    using var ctx = IBindCtxExtensions.CreateBindCtx(STGM.STGM_WRITE)!;
                    newItem.ComObject.Object.BindToHandler(ctx.Object, ShellN.Constants.BHID_Stream, typeof(DirectN.IStream).GUID, out var unk);
                    var strm = ComObject.FromPointer<DirectN.IStream>(unk);
                    if (strm == null)
                        break;

                    using var stream = new StreamOnIStream(strm.Object, true);
                    SavePage(_document, i, stream, format);
                }
            }

            progress.End();
            progress.Stop();
            progress.Dispose();
        }, true);
        return true;
    }

    public static bool SavePage(PdfDocument document, uint index, Stream stream, string extension)
    {
        ArgumentNullException.ThrowIfNull(document);
        ArgumentNullException.ThrowIfNull(stream);
        ArgumentNullException.ThrowIfNull(extension);

        var encoder = WicImagingComponent.AllComponents.OfType<WicEncoder>().FirstOrDefault(c => c.SupportsFileExtension(extension));
        if (encoder == null)
            return false;

        var renderer = ShellBatWindow.GetPdfRenderer();
        if (renderer == null)
            return false;

        var size = Math.Max(100, Settings.Current.PdfSaveImageSize);
        var options = new PdfRenderOptions(size, size, index);
        using var bmp = renderer.RenderPdfPage(document, options);
        if (bmp == null)
            return false;

        bmp.Save(stream, encoder.ContainerFormat);
        return true;
    }

    public static bool SavePage(PdfDocument document, uint index, string filePath)
    {
        ArgumentNullException.ThrowIfNull(document);
        ArgumentNullException.ThrowIfNull(filePath);

        var renderer = ShellBatWindow.GetPdfRenderer();
        if (renderer == null)
            return false;

        var size = Math.Max(100, Settings.Current.PdfSaveImageSize);
        var options = new PdfRenderOptions(size, size, index);
        using var bmp = renderer.RenderPdfPage(document, options);
        if (bmp == null)
            return false;

        bmp.Save(filePath);
        return true;
    }

    public static PdfDocument? GetDocument(int id)
    {
        if (!ShellBatInstance.Current.Options.HasFlag(ShellBatInstanceOptions.IsLocalHttpServer))
            return null;

        _documents.TryGetValue(id, out var doc);
        return doc;
    }

    protected class PdfProperties(PdfViewer viewer)
    {
        // not visible to HTML UI
        [WebPropertyGridProperty(IsHidden = true)]
        public uint CurrentPage => viewer._currentPage;

        // not visible to HTML UI
        [WebPropertyGridProperty(IsHidden = true)]
        public uint PageCount => viewer._document?.PageCount ?? 0;

        [LocalizedDisplayName("Pages")]
        public string Pages => $"{CurrentPage + 1} / {Math.Max(1, PageCount)}";
    }
}
