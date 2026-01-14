#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/nn-shlobj-icurrentworkingdirectory
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("91956d21-9276-11d1-921a-006097df5bd4")]
public partial interface ICurrentWorkingDirectory
{
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-icurrentworkingdirectory-getdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDirectory([MarshalUsing(CountElementName = nameof(cchSize))] PWSTR pwzPath, uint cchSize);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-icurrentworkingdirectory-setdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDirectory(PWSTR pwzPath);
}
