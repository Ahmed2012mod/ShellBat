using System.Security.Cryptography.X509Certificates;

namespace ShellBat.Utilities;

public class AuthenticodeSignature
{
    internal readonly List<AuthenticodeSignerInfo> _signerInfos = [];
    internal readonly List<X509Certificate2> _certificates = [];

    internal AuthenticodeSignature(byte[] content)
    {
        Content = content;
    }

    public byte[] Content { get; }
    public IReadOnlyList<AuthenticodeSignerInfo> SignerInfos => _signerInfos.AsReadOnly();
    public IReadOnlyList<X509Certificate2> Certificates => _certificates.AsReadOnly();

    public IEnumerable<AuthenticodeSignature> AllSignatures
    {
        get
        {
            yield return this;
            foreach (var signer in _signerInfos)
            {
                foreach (var nested in signer.NestedSignatures)
                {
                    foreach (var sig in nested.AllSignatures)
                    {
                        yield return sig;
                    }
                }
            }
        }
    }
}
