#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iactionprogressdialog
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("49ff1172-eadc-446d-9285-156453a6431c")]
public partial interface IActionProgressDialog
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iactionprogressdialog-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(uint flags, PWSTR pszTitle, PWSTR pszCancel);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iactionprogressdialog-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
}
