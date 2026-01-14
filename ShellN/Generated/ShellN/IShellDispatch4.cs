#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/ishelldispatch4
[GeneratedComInterface, Guid("efd84b2d-4bcf-4298-be25-eb542a59fbda")]
public partial interface IShellDispatch4 : IShellDispatch3
{
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch4-windowssecurity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WindowsSecurity();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch4-toggledesktop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ToggleDesktop();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch4-explorerpolicy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExplorerPolicy(BSTR bstrPolicyName, out VARIANT pValue);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch4-getsetting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSetting(int lSetting, out VARIANT_BOOL pResult);
}
