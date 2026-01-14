#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iresolveshelllink
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("5cd52983-9449-11d2-963a-00c04f79adf0")]
public partial interface IResolveShellLink
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iresolveshelllink-resolveshelllink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResolveShellLink(nint punkLink, HWND hwnd, uint fFlags);
}
