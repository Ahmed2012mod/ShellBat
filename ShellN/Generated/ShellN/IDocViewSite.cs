#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/nn-shlobj-idocviewsite
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("87d605e0-c511-11cf-89a9-00a0c9054129")]
public partial interface IDocViewSite
{
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-idocviewsite-onsettitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSetTitle(in VARIANT pvTitle);
}
