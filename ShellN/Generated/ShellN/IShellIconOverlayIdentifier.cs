#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishelliconoverlayidentifier
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0c6c4200-c589-11d0-999a-00c04fd655e1")]
public partial interface IShellIconOverlayIdentifier
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelliconoverlayidentifier-ismemberof
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsMemberOf(PWSTR pwszPath, uint dwAttrib);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelliconoverlayidentifier-getoverlayinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOverlayInfo([MarshalUsing(CountElementName = nameof(cchMax))] PWSTR pwszIconFile, int cchMax, out int pIndex, out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelliconoverlayidentifier-getpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPriority(out int pPriority);
}
