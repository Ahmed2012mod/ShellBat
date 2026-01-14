#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-idelegatefolder
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("add8ba80-002b-11d0-8f0f-00c04fd7d062")]
public partial interface IDelegateFolder
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idelegatefolder-setitemalloc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetItemAlloc([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMalloc>))] IMalloc pmalloc);
}
