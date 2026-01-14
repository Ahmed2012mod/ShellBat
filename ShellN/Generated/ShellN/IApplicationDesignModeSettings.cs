#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iapplicationdesignmodesettings
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("2a3dee9a-e31d-46d6-8508-bcc597db3557")]
public partial interface IApplicationDesignModeSettings
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-setnativedisplaysize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNativeDisplaySize(SIZE nativeDisplaySizePixels);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-setscalefactor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetScaleFactor(DEVICE_SCALE_FACTOR scaleFactor);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-setapplicationviewstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetApplicationViewState(APPLICATION_VIEW_STATE viewState);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-computeapplicationsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComputeApplicationSize(out SIZE applicationSizePixels);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-isapplicationviewstatesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsApplicationViewStateSupported(APPLICATION_VIEW_STATE viewState, SIZE nativeDisplaySizePixels, DEVICE_SCALE_FACTOR scaleFactor, out BOOL supported);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-triggeredgegesture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TriggerEdgeGesture(EDGE_GESTURE_KIND edgeGestureKind);
}
