#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iopencontrolpanel
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d11ad862-66de-4df4-bf6c-1f5621996af1")]
public partial interface IOpenControlPanel
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iopencontrolpanel-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(PWSTR pszName, PWSTR pszPage, nint punkSite);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iopencontrolpanel-getpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPath(PWSTR pszName, [MarshalUsing(CountElementName = nameof(cchPath))] PWSTR pszPath, uint cchPath);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iopencontrolpanel-getcurrentview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentView(out CPVIEW pView);
}
