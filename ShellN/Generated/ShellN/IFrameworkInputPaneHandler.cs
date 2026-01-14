#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iframeworkinputpanehandler
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("226c537b-1e76-4d9e-a760-33db29922f18")]
public partial interface IFrameworkInputPaneHandler
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iframeworkinputpanehandler-showing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Showing(in RECT prcInputPaneScreenLocation, BOOL fEnsureFocusedElementInView);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iframeworkinputpanehandler-hiding
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Hiding(BOOL fEnsureFocusedElementInView);
}
