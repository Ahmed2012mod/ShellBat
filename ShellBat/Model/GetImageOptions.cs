namespace ShellBat.Model;

[Flags]
public enum GetImageOptions
{
    None = 0x0,
    CropToSquare = 0x1,
    DontCache = 0x2,
    CacheOnly = 0x4,
    IconOnly = 0x8,
}
