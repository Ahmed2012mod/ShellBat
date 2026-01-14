#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-ctl_usage
public partial struct CTL_USAGE
{
    public uint cUsageIdentifier;
    public nint rgpszUsageIdentifier;
}
