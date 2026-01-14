#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ideskbar
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("eb0fe173-1a3a-11d0-89b3-00a0c90a90ac")]
public partial interface IDeskBar : IOleWindow
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ideskbar-setclient
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClient(nint punkClient);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ideskbar-getclient
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClient(out nint ppunkClient);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ideskbar-onposrectchangedb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnPosRectChangeDB(in RECT prc);
}
