#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ihandlerinfo
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("997706ef-f880-453b-8118-39e1a2d2655a")]
public partial interface IHandlerInfo
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ihandlerinfo-getapplicationdisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationDisplayName(out PWSTR value);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ihandlerinfo-getapplicationpublisher
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationPublisher(out PWSTR value);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ihandlerinfo-getapplicationiconreference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationIconReference(out PWSTR value);
}
