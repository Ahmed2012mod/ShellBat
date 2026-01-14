#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("0c733a1d-2a1c-11ce-ade5-00aa0044773d")]
public partial interface IDBCreateCommand
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCommand(nint pUnkOuter, in Guid riid, out nint ppCommand);
}
