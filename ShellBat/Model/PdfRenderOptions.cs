namespace ShellBat.Model;

public class PdfRenderOptions(uint width, uint height, uint index = 0)
{
    public virtual uint Height { get; set; } = height;
    public virtual uint Width { get; set; } = width;
    public virtual uint Index { get; set; } = index;
    public virtual bool IgnoreHighContrast { get; set; }
    public virtual bool RenderPasswordProtectedImage { get; set; } = true;

    internal string Key => $"{Width}_{Height}_{Index}_{IgnoreHighContrast}";
}
