#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ilaunchtargetmonitor
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("266fbc7e-490d-46ed-a96b-2274db252003")]
public partial interface ILaunchTargetMonitor
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ilaunchtargetmonitor-getmonitor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMonitor(out HMONITOR monitor);
}
