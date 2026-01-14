#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/nn-shlobj-ishellfolderband
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("7fe80cc8-c247-11d0-b93a-00a0c90312e1")]
public partial interface IShellFolderBand
{
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-ishellfolderband-initializesfb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeSFB([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellFolder?>))] IShellFolder? psf, nint /* optional nint* */ pidl);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-ishellfolderband-setbandinfosfb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBandInfoSFB(in BANDINFOSFB pbi);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-ishellfolderband-getbandinfosfb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBandInfoSFB(ref BANDINFOSFB pbi);
}
