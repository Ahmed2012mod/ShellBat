#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iobjectwithprogid
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("71e806fb-8dee-46fc-bf8c-7748a8a1ae13")]
public partial interface IObjectWithProgID
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iobjectwithprogid-setprogid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProgID(PWSTR pszProgID);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iobjectwithprogid-getprogid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProgID(out PWSTR ppszProgID);
}
