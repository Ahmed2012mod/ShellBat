namespace ShellBat.Model.Viewers;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class ImageViewer(Entry entry) : Viewer(entry)
{
    public override int Priority => FileExtensionMatchPriority - 1;
    public override string? Icon => "fa-regular fa-file-image";
    public override bool IsSupported
    {
        get
        {
            // we support webview2 native images directly and other images via WIC
            if (Entry.Extension.IsWebView2NativeImage || Entry.Extension.IsWicImage)
                return true;

            return base.IsSupported;
        }
    }

    public virtual bool FillWidth { get; set; } = ShellBatInstance.Current.Settings.ImageFillWidth;
    public virtual bool FillHeight { get; set; } = ShellBatInstance.Current.Settings.ImageFillHeight;

    public string? GetPageUrl(uint size)
    {
        if (!IsSupported)
            return null;

        // let webview2 load native images from file system directly
        if (Entry.Extension.IsWebView2NativeImage && Entry.FileSystemPath != null)
            return Entry.FileSystemPath.EncodePathForWebView2();

        var encodedPath = ShellBatHttpLocalServer.EscapeUrl(Entry.FileSystemPath ?? Entry.ParsingName);
        var url = $"{ShellBatInstance.Current.HttpServer.Url}{UrlType.Image}/{encodedPath}?size={size}";
        return url;
    }

    public override Task<WebPropertyGrid?> GetProperties()
    {
        var grid = new WebPropertyGrid();

        grid.Properties.Add(new WebPropertyGridProperty()
        {
            Key = nameof(FillWidth),
            DisplayName = Res.FillWidth,
            Editor = "Boolean",
        });

        grid.Properties.Add(new WebPropertyGridProperty()
        {
            Key = nameof(FillHeight),
            DisplayName = Res.FillHeight,
            Editor = "Boolean",
        });

        grid.Instance.PropertyChanged += (s, e) =>
        {
            switch (e.PropertyName)
            {
                case nameof(FillWidth):
                    FillWidth = grid.Instance.GetTypedValue<bool>(nameof(FillWidth));
                    break;

                case nameof(FillHeight):
                    FillHeight = grid.Instance.GetTypedValue<bool>(nameof(FillHeight));
                    break;
            }
        };

        grid.Instance.SetValue(nameof(FillWidth), FillWidth);
        grid.Instance.SetValue(nameof(FillHeight), FillHeight);

        grid.Options.GroupByCategory = false;
        grid.Options.PropertyNamePostfix = ":";
        grid.Options.BaseClassName = "viewer-Image-pg";
        return Task.FromResult<WebPropertyGrid?>(grid);
    }
}
