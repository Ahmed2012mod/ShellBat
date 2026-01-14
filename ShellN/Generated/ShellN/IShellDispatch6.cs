#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/ishelldispatch6
[GeneratedComInterface, Guid("286e6f1b-7113-4355-9562-96b7e9d64c54")]
public partial interface IShellDispatch6 : IShellDispatch5
{
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch6-searchcommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SearchCommand();
}
