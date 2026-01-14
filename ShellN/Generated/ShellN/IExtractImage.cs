#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iextractimage
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("bb2e617c-0920-11d1-9a0b-00c04fc2d6c1")]
public partial interface IExtractImage
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iextractimage-getlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocation([MarshalUsing(CountElementName = nameof(cch))] PWSTR pszPathBuffer, uint cch, ref uint pdwPriority, in SIZE prgSize, uint dwRecClrDepth, ref uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iextractimage-extract
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Extract(out HBITMAP phBmpThumbnail);
}
