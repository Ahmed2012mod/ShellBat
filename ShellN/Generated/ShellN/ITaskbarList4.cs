#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-itaskbarlist4
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c43dc798-95d1-4bea-9030-bb99e2983a1a")]
public partial interface ITaskbarList4 : ITaskbarList3
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist4-settabproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTabProperties(HWND hwndTab, STPFLAG stpFlags);
}
