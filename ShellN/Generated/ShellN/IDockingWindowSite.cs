#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-idockingwindowsite
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("2a342fc2-7b26-11d0-8ca9-00a0c92dbfe8")]
public partial interface IDockingWindowSite : IOleWindow
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-idockingwindowsite-getborderdw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBorderDW(nint punkObj, out RECT prcBorder);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-idockingwindowsite-requestborderspacedw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequestBorderSpaceDW(nint punkObj, in RECT pbw);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-idockingwindowsite-setborderspacedw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBorderSpaceDW(nint punkObj, in RECT pbw);
}
