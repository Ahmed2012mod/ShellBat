namespace ShellBat.Model;

[Flags]
public enum EntryEnumerateOptions
{
    None = 0x0,
    IncludeHidden = 0x1,
    IncludeSystem = 0x2,
    ExcludeFolders = 0x4,
    ExcludeFiles = 0x8,
    ShowCompressedAsFile = 0x10,
    DontInvokeDefaultCommand = 0x20,
    ImagesOnly = 0x40,
    DontUseCache = 0x80,
}
