#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/ishelldispatch5
[GeneratedComInterface, Guid("866738b9-6cf2-4de8-8767-f794ebe74f4e")]
public partial interface IShellDispatch5 : IShellDispatch4
{
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch5-windowswitcher
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WindowSwitcher();
}
