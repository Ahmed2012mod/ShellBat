namespace ShellBat.Resources;

public static class ResourcesUtilities
{
    public static IComObject<IWICBitmapSource> LoadBitmapSource(Stream stream, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
    {
        ArgumentNullException.ThrowIfNull(stream);
        using var decoder = WicImagingFactory.CreateDecoderFromStream(stream, metadataOptions: metadataOptions);
        using var frame = decoder.GetFrame(0);
        var converter = WicImagingFactory.CreateFormatConverter();
        var format = DirectN.Constants.GUID_WICPixelFormat32bppPBGRA;
        converter.Object.Initialize(frame.Object, format, WICBitmapDitherType.WICBitmapDitherTypeNone, null!, 0, WICBitmapPaletteType.WICBitmapPaletteTypeCustom).ThrowOnError();
        return converter.As<IWICBitmapSource>()!;
    }

    public static IComObject<IWICBitmapSource>? GetWicBitmapSource(string name, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
    {
        ArgumentNullException.ThrowIfNull(name);
        var stream = Assembly.GetEntryAssembly()!.GetManifestResourceStream(name);
        if (stream == null)
            return null;

        return LoadBitmapSource(stream, metadataOptions);
    }

    public static IComObject<IWICBitmapSource>? GetWicBitmapSource(Func<string, bool> predicate, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
    {
        ArgumentNullException.ThrowIfNull(predicate);
        var name = Assembly.GetEntryAssembly()!.GetManifestResourceNames().FirstOrDefault(predicate);
        if (name == null)
            return null;

        return GetWicBitmapSource(name, metadataOptions);
    }
}
