#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ifiledialog2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("61744fc7-85b5-4791-a9b0-272276309b13")]
public partial interface IFileDialog2 : IFileDialog
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifiledialog2-setcancelbuttonlabel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCancelButtonLabel(PWSTR pszLabel);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifiledialog2-setnavigationroot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNavigationRoot([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi);
}
