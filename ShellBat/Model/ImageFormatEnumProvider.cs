namespace ShellBat.Model;

public class ImageFormatEnumProvider : IEnumProvider
{
    public bool IsFlags => false;
    public IDictionary<string, object?>? Values => WicImagingComponent.EncoderFileExtensions.ToDictionary(x => x, x => (object?)x);
}
