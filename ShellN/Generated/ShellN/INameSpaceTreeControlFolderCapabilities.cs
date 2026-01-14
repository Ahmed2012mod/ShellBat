#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-inamespacetreecontrolfoldercapabilities
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("e9701183-e6b3-4ff2-8568-813615fec7be")]
public partial interface INameSpaceTreeControlFolderCapabilities
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrolfoldercapabilities-getfoldercapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolderCapabilities(NSTCFOLDERCAPABILITIES nfcMask, out NSTCFOLDERCAPABILITIES pnfcValue);
}
