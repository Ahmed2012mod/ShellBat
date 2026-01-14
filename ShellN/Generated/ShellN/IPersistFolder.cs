#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ipersistfolder
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214ea-0000-0000-c000-000000000046")]
public partial interface IPersistFolder : IPersist
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipersistfolder-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(nint pidl);
}
