#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iexplorerpanevisibility
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e07010ec-bc17-44c0-97b0-46c7c95b9edc")]
public partial interface IExplorerPaneVisibility
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerpanevisibility-getpanestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPaneState(in Guid ep, out uint peps);
}
