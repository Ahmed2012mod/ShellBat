#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-inewwindowmanager
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("d2bc4c84-3f72-4a52-a604-7bcbf3982cbb")]
public partial interface INewWindowManager
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inewwindowmanager-evaluatenewwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EvaluateNewWindow(PWSTR pszUrl, PWSTR pszName, PWSTR pszUrlContext, PWSTR pszFeatures, BOOL fReplace, uint dwFlags, uint dwUserActionTime);
}
