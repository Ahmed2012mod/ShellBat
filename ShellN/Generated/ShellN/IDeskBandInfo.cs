#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ideskbandinfo
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("77e425fc-cbf9-4307-ba6a-bb5727745661")]
public partial interface IDeskBandInfo
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ideskbandinfo-getdefaultbandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultBandWidth(uint dwBandID, uint dwViewMode, out int pnWidth);
}
