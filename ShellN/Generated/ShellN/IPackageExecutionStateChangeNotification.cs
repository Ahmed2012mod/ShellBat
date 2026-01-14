#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ipackageexecutionstatechangenotification
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("1bb12a62-2ad8-432b-8ccf-0c2c52afcd5b")]
public partial interface IPackageExecutionStateChangeNotification
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackageexecutionstatechangenotification-onstatechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStateChanged(PWSTR pszPackageFullName, PACKAGE_EXECUTION_STATE pesNewState);
}
