#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iuseraccountchangecallback
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a561e69a-b4b8-4113-91a5-64c6bcca3430")]
public partial interface IUserAccountChangeCallback
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iuseraccountchangecallback-onpicturechange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnPictureChange(PWSTR pszUserName);
}
