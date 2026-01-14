#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iapplicationdesignmodesettings2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("490514e1-675a-4d6e-a58d-e54901b4ca2f")]
public partial interface IApplicationDesignModeSettings2 : IApplicationDesignModeSettings
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-setnativedisplayorientation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNativeDisplayOrientation(NATIVE_DISPLAY_ORIENTATION nativeDisplayOrientation);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-setapplicationvieworientation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetApplicationViewOrientation(APPLICATION_VIEW_ORIENTATION viewOrientation);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-setadjacentdisplayedges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAdjacentDisplayEdges(ADJACENT_DISPLAY_EDGES adjacentDisplayEdges);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-setisonlockscreen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIsOnLockScreen(BOOL isOnLockScreen);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-setapplicationviewminwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetApplicationViewMinWidth(APPLICATION_VIEW_MIN_WIDTH viewMinWidth);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-getapplicationsizebounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationSizeBounds(out SIZE minApplicationSizePixels, out SIZE maxApplicationSizePixels);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-getapplicationvieworientation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationViewOrientation(SIZE applicationSizePixels, out APPLICATION_VIEW_ORIENTATION viewOrientation);
}
