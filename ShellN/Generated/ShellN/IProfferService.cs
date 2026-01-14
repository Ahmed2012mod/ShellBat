#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iprofferservice
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("cb728b20-f786-11ce-92ad-00aa00a74cd0")]
public partial interface IProfferService
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iprofferservice-profferservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProfferService(in Guid serviceId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<DirectN.IServiceProvider>))] DirectN.IServiceProvider serviceProvider, out uint cookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iprofferservice-revokeservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RevokeService(uint cookie);
}
