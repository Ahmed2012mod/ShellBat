#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ipreviewhandlerframe
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fec87aaf-35f9-447a-adb7-20234491401a")]
public partial interface IPreviewHandlerFrame
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipreviewhandlerframe-getwindowcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindowContext(out PREVIEWHANDLERFRAMEINFO pinfo);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipreviewhandlerframe-translateaccelerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateAccelerator(in MSG pmsg);
}
