#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shdeprecated/nn-shdeprecated-ishellservice
[GeneratedComInterface, Guid("5836fb00-8187-11cf-a12b-00aa004ae837")]
public partial interface IShellService
{
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ishellservice-setowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOwner(nint punkOwner);
}
