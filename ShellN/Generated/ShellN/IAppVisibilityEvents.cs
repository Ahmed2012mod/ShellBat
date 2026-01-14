#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iappvisibilityevents
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("6584ce6b-7d82-49c2-89c9-c6bc02ba8c38")]
public partial interface IAppVisibilityEvents
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iappvisibilityevents-appvisibilityonmonitorchanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppVisibilityOnMonitorChanged(HMONITOR hMonitor, MONITOR_APP_VISIBILITY previousMode, MONITOR_APP_VISIBILITY currentMode);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iappvisibilityevents-launchervisibilitychange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LauncherVisibilityChange(BOOL currentVisibleState);
}
