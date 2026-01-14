#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("0c733aaf-2a1c-11ce-ade5-00aa0044773d")]
public partial interface IGetRow
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRowFromHROW(nint pUnkOuter, nuint hRow, in Guid riid, out nint ppUnk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetURLFromHROW(nuint hRow, out PWSTR ppwszURL);
}
