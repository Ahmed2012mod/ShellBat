#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iapplicationassociationregistration
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("4e530b0a-e611-4c77-a3ac-9031d022281b")]
public partial interface IApplicationAssociationRegistration
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationassociationregistration-querycurrentdefault
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryCurrentDefault(PWSTR pszQuery, ASSOCIATIONTYPE atQueryType, ASSOCIATIONLEVEL alQueryLevel, out PWSTR ppszAssociation);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationassociationregistration-queryappisdefault
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryAppIsDefault(PWSTR pszQuery, ASSOCIATIONTYPE atQueryType, ASSOCIATIONLEVEL alQueryLevel, PWSTR pszAppRegistryName, out BOOL pfDefault);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationassociationregistration-queryappisdefaultall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryAppIsDefaultAll(ASSOCIATIONLEVEL alQueryLevel, PWSTR pszAppRegistryName, out BOOL pfDefault);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationassociationregistration-setappasdefault
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAppAsDefault(PWSTR pszAppRegistryName, PWSTR pszSet, ASSOCIATIONTYPE atSetType);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationassociationregistration-setappasdefaultall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAppAsDefaultAll(PWSTR pszAppRegistryName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationassociationregistration-clearuserassociations
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearUserAssociations();
}
