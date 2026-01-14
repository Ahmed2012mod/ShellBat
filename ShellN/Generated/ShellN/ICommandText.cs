#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("0c733a27-2a1c-11ce-ade5-00aa0044773d")]
public partial interface ICommandText : ICommand
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCommandText(nint /* optional Guid* */ pguidDialect, out PWSTR ppwszCommand);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCommandText(in Guid rguidDialect, PWSTR pwszCommand);
}
