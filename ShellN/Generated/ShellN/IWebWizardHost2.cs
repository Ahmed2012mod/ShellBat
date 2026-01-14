#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("f9c013dc-3c23-4041-8e39-cfb402f7ea59")]
public partial interface IWebWizardHost2 : IWebWizardHost
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SignString(BSTR value, out BSTR signedValue);
}
