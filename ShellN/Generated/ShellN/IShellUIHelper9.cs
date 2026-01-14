#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("6cdf73b0-7f2f-451f-bc0f-63e0f3284e54")]
public partial interface IShellUIHelper9 : IShellUIHelper8
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOSSku(out uint pdwResult);
}
