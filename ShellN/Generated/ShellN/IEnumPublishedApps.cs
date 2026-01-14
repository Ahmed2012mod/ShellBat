#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shappmgr/nn-shappmgr-ienumpublishedapps
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("0b124f8c-91f0-11d1-b8b5-006008059382")]
public partial interface IEnumPublishedApps
{
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-ienumpublishedapps-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPublishedApp>))] out IPublishedApp pia);
    
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-ienumpublishedapps-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
}
