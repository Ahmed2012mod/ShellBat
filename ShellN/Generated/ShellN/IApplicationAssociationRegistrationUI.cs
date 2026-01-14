#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iapplicationassociationregistrationui
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("1f76a169-f994-40ac-8fc8-0959e8874710")]
public partial interface IApplicationAssociationRegistrationUI
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iapplicationassociationregistrationui-launchadvancedassociationui
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LaunchAdvancedAssociationUI(PWSTR pszAppRegistryName);
}
