#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shdeprecated/nn-shdeprecated-ibrowserservice4
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("639f1bff-e135-4096-abd8-e0f504d649a4")]
public partial interface IBrowserService4 : IBrowserService3
{
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice4-activateview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateView(BOOL fPendingView);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice4-saveviewstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveViewState();
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice4-_resizeallborders
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT _ResizeAllBorders();
}
