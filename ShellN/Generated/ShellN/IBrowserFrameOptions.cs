#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ibrowserframeoptions
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("10df43c8-1dbe-11d3-8b34-006097df5bd4")]
public partial interface IBrowserFrameOptions
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ibrowserframeoptions-getframeoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrameOptions(uint dwMask, out uint pdwOptions);
}
