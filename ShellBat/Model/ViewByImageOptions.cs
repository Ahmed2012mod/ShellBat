namespace ShellBat.Model;

[Flags]
public enum ViewByImageOptions
{
    None = 0x0,
    DisplayTitle = 0x1,
    RenderPdfThumbnails = 0x2,
    SquareThumbnails = 0x4,
}
