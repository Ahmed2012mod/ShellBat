#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-isearchboxinfo
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6af6e03f-d664-4ef4-9626-f7e0ed36755e")]
public partial interface ISearchBoxInfo
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-isearchboxinfo-getcondition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCondition(in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-isearchboxinfo-gettext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetText(out PWSTR ppsz);
}
