#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-iquerycontinuewithstatus
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("9090be5b-502b-41fb-bccc-0049a6c7254b")]
public partial interface IQueryContinueWithStatus : IQueryContinue
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-iquerycontinuewithstatus-setstatusmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStatusMessage(PWSTR psz);
}
