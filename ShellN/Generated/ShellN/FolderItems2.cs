#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/folderitems2-object
[GeneratedComInterface, Guid("c94f0ad0-f363-11d2-a327-00c04f8eec7f")]
public partial interface FolderItems2 : FolderItems
{
    // https://learn.microsoft.com/windows/win32/shell/folderitems2-invokeverbex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeVerbEx(VARIANT vVerb, VARIANT vArgs);
}
