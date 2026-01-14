namespace ShellBat.Model;

[Flags]
public enum ShellItemParsingOptions
{
    None = 0,
    DontThrowOnError = 0x1,
    TrySplitting = 0x2,
    DontInvokeDefaultCommand = 0x4,
}
