#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ipersistfolder2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("1ac3d9f0-175c-11d1-95be-00609797ea4f")]
public partial interface IPersistFolder2 : IPersistFolder
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipersistfolder2-getcurfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurFolder(out nint ppidl);
}
