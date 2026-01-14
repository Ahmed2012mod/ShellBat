namespace ShellBat.Model;

// aggregate options in one enum for optimiazed web communication
[Flags]
public enum WebEntryOptions
{
    None = 0x0,
    IsFolder = 0x1,
    IsNotWebView2NativeImage = 0x2,
    IsCompressed = 0x4,
    IsImage = 0x8,
    IsHidden = 0x10,
    IsSystem = 0x20,
    IsPdf = 0x40,
    IsCut = 0x80,
}
