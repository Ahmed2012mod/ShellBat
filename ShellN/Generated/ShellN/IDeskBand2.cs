#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ideskband2
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("79d16de4-abee-4021-8d9d-9169b261d657")]
public partial interface IDeskBand2 : IDeskBand
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ideskband2-canrendercomposited
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanRenderComposited(out BOOL pfCanRenderComposited);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ideskband2-setcompositionstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCompositionState(BOOL fCompositionEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ideskband2-getcompositionstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCompositionState(out BOOL pfCompositionEnabled);
}
