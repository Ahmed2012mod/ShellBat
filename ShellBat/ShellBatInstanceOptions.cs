namespace ShellBat;

[Flags]
public enum ShellBatInstanceOptions
{
    None = 0x0,
    IsLocalHttpServer = 0x1,
    IsInHttpServerOnlyMode = 0x2,
}
