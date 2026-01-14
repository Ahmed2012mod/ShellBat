#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifileisinuse
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("64a1cbf0-3a1a-4461-9158-376969693950")]
public partial interface IFileIsInUse
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileisinuse-getappname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAppName(out PWSTR ppszName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileisinuse-getusage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUsage(out FILE_USAGE_TYPE pfut);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileisinuse-getcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapabilities(out uint pdwCapFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileisinuse-getswitchtohwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSwitchToHWND(out HWND phwnd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileisinuse-closefile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CloseFile();
}
