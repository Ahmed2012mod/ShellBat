#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ideskband
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("eb0fe172-1a3a-11d0-89b3-00a0c90a90ac")]
public partial interface IDeskBand : IDockingWindow
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ideskband-getbandinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBandInfo(uint dwBandID, uint dwViewMode, ref DESKBANDINFO pdbi);
}
