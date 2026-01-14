#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icontactmanagerinterop
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("99eacba7-e073-43b6-a896-55afe48a0833")]
public partial interface IContactManagerInterop
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icontactmanagerinterop-showcontactcardforwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowContactCardForWindow(HWND appWindow, nint contact, in RECT selection, FLYOUT_PLACEMENT preferredPlacement);
}
