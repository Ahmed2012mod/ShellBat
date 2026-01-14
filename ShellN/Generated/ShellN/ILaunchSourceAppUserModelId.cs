#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ilaunchsourceappusermodelid
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("989191ac-28ff-4cf0-9584-e0d078bc2396")]
public partial interface ILaunchSourceAppUserModelId
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ilaunchsourceappusermodelid-getappusermodelid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAppUserModelId(out PWSTR launchingApp);
}
