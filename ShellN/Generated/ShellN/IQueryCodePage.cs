#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iquerycodepage
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c7b236ce-ee80-11d0-985f-006008059382")]
public partial interface IQueryCodePage
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iquerycodepage-getcodepage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodePage(out uint puiCodePage);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iquerycodepage-setcodepage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCodePage(uint uiCodePage);
}
