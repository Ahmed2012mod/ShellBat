#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/structuredquerycondition/nn-structuredquerycondition-irichchunk
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("4fdef69c-dbc9-454e-9910-b34f3c64b510")]
public partial interface IRichChunk
{
    // https://learn.microsoft.com/windows/win32/api/structuredquerycondition/nf-structuredquerycondition-irichchunk-getdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(nint /* optional uint* */ pFirstPos, nint /* optional uint* */ pLength, nint /* optional PWSTR* */ ppsz, nint /* optional PROPVARIANT* */ pValue);
}
