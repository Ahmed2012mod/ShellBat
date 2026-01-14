#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-icdburn
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("3d73a659-e5d0-4d42-afc0-5121ba425c8d")]
public partial interface ICDBurn
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-icdburn-getrecorderdriveletter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecorderDriveLetter([MarshalUsing(CountElementName = nameof(cch))] PWSTR pszDrive, uint cch);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-icdburn-burn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Burn(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-icdburn-hasrecordabledrive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasRecordableDrive(out BOOL pfHasRecorder);
}
