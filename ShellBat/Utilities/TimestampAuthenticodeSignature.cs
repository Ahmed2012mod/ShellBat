using System.Security.Cryptography;

namespace ShellBat.Utilities;

public class TimestampAuthenticodeSignature : AuthenticodeSignature
{
    internal TimestampAuthenticodeSignature(byte[] content)
        : base(content)
    {
    }

    public uint Version { get; internal set; }
    public string? TSAPolicyId { get; internal set; }
    public DateTime Time { get; internal set; }
    public Oid HashAlgorithm { get; internal set; } = null!;
}
