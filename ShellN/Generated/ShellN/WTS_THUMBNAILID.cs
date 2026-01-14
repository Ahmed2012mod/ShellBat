#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/thumbcache/ns-thumbcache-wts_thumbnailid
public partial struct WTS_THUMBNAILID : IValueGet<byte[]>
{
    public InlineArrayByte_16 rgbKey;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)rgbKey).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)rgbKey).ToArray();
}
