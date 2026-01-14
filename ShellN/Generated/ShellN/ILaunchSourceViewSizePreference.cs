#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ilaunchsourceviewsizepreference
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("e5aa01f7-1fb8-4830-8720-4e6734cbd5f3")]
public partial interface ILaunchSourceViewSizePreference
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ilaunchsourceviewsizepreference-getsourceviewtoposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceViewToPosition(out HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ilaunchsourceviewsizepreference-getsourceviewsizepreference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceViewSizePreference(out APPLICATION_VIEW_SIZE_PREFERENCE sourceSizeAfterLaunch);
}
