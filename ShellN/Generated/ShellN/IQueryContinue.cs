#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iquerycontinue
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("7307055c-b24a-486b-9f25-163e597a28a9")]
public partial interface IQueryContinue
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iquerycontinue-querycontinue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryContinue();
}
