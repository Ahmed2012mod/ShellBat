#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-iobjmgr
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00bb2761-6a77-11d0-a535-00c04fd7d062")]
public partial interface IObjMgr
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iobjmgr-append
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Append(nint punk);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iobjmgr-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(nint punk);
}
