#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/ishelllinkdual2-object
[GeneratedComInterface, Guid("317ee249-f12e-11d2-b1e4-00c04f8eeb3e")]
public partial interface IShellLinkDual2 : IShellLinkDual
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Target([MarshalUsing(typeof(UniqueComInterfaceMarshaller<FolderItem>))] out FolderItem ppfi);
}
