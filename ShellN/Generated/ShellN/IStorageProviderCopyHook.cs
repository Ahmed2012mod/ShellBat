#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/nn-shobjidl-istorageprovidercopyhook
[GeneratedComInterface, Guid("7bf992a9-af7a-4dba-b2e5-4d080b1ecbc6")]
public partial interface IStorageProviderCopyHook
{
    // https://learn.microsoft.com/windows/win32/shell/nf-shobjidl-istorageprovidercopyhook-copycallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyCallback(HWND hwnd, uint operation, uint flags, PWSTR srcFile, uint srcAttribs, PWSTR destFile, uint destAttribs, out uint result);
}
