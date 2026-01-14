#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("0751c551-7568-41c9-8e5b-e22e38919236")]
public partial interface INewWDEvents : IWebWizardHost
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PassportAuthenticate(BSTR bstrSignInUrl, out VARIANT_BOOL pvfAuthenitcated);
}
