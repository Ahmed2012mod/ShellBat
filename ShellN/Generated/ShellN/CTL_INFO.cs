#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-ctl_info
public partial struct CTL_INFO
{
    public uint dwVersion;
    public CTL_USAGE SubjectUsage;
    public CRYPT_INTEGER_BLOB ListIdentifier;
    public CRYPT_INTEGER_BLOB SequenceNumber;
    public FILETIME ThisUpdate;
    public FILETIME NextUpdate;
    public CRYPT_ALGORITHM_IDENTIFIER SubjectAlgorithm;
    public uint cCTLEntry;
    public nint rgCTLEntry;
    public uint cExtension;
    public nint rgExtension;
}
