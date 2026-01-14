using Windows.Data.Pdf;
using Windows.Storage;

namespace ShellBat.Utilities;

public partial class PdfRenderer(ComObject<IPdfRendererNative> comObject) : InterlockedComObject<IPdfRendererNative>(comObject)
{
    public async Task<WicBitmapSource?> RenderPdfPage(Stream stream, PdfRenderOptions options)
    {
        ArgumentNullException.ThrowIfNull(stream);
        var doc = await PdfDocument.LoadFromStreamAsync(stream.AsRandomAccessStream());
        return RenderPdfPage(doc, options);
    }

    public async Task<WicBitmapSource?> RenderPdfPage(string path, PdfRenderOptions options)
    {
        ArgumentNullException.ThrowIfNull(path);
        if (!IOUtilities.PathIsFile(path))
            return null;

        var file = await StorageFile.GetFileFromPathAsync(path);
        var doc = await PdfDocument.LoadFromFileAsync(file);
        return RenderPdfPage(doc, options);
    }

    public virtual unsafe WicBitmapSource? RenderPdfPage(PdfDocument document, PdfRenderOptions options)
    {
        ArgumentNullException.ThrowIfNull(document);
        var bmp = new WicBitmapSource(options.Width, options.Height, WicPixelFormat.GUID_WICPixelFormat32bppPRGBA);
        try
        {
            using var fac = D2D1Functions.D2D1CreateFactory();
            using var rt = fac.CreateWicBitmapRenderTarget(bmp.As<IWICBitmap>()!);
            var dc = rt.As<ID2D1DeviceContext>()!;
            using var page = document.GetPage(options.Index);

            var size = page.Size;
            var factor = new Size(options.Width, options.Height).GetScaleFactor(size);
            var width = size.Width * factor.Width;
            var height = size.Height * factor.Height;

            // center if needed
            D2D_MATRIX_3X2_F? xf = null;
            if (width < options.Width || height < options.Height)
            {
                xf = dc.GetTransform();
                dc.SetTransform(xf.Value * D2D_MATRIX_3X2_F.Translation(
                    Math.Max(0, (float)((options.Width - width) / 2)),
                    Math.Max(0, (float)((options.Height - height) / 2)))
                    );
            }

            var renderParams = new PDF_RENDER_PARAMS
            {
                //BackgroundColor = D3DCOLORVALUE.White, // doesn't seem to be honored
                DestinationWidth = (uint)width,
                DestinationHeight = (uint)height,
                IgnoreHighContrast = options.IgnoreHighContrast,
            };

            var unk = ((IWinRTObject)page).NativeObject.ThisPtr; // no AddRef needed
            dc.BeginDraw();

            // not sure why but PDF_RENDER_PARAMS's BackgroundColor seems to not be used
            // so we do it ourselves
            using var backgroundBrush = dc.CreateSolidColorBrush(D3DCOLORVALUE.White);
            dc.FillRectangle(new D2D_RECT_F(0, 0, width, height), backgroundBrush);

            NativeObject.RenderPageToDeviceContext(unk, dc.Object, (nint)(&renderParams)).ThrowOnError();
            dc.EndDraw();
            return bmp;
        }
        catch (Exception ex)
        {
            ShellBatInstance.LogError($"Error: {ex}");
            bmp.Dispose();
            return null;
        }
    }
}
