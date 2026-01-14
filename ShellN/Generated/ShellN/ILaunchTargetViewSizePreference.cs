#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ilaunchtargetviewsizepreference
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("2f0666c6-12f7-4360-b511-a394a0553725")]
public partial interface ILaunchTargetViewSizePreference
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ilaunchtargetviewsizepreference-gettargetviewsizepreference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTargetViewSizePreference(out APPLICATION_VIEW_SIZE_PREFERENCE targetSizeOnLaunch);
}
