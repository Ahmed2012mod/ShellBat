#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("0c733a5d-2a1c-11ce-ade5-00aa0044773d")]
public partial interface IDBCreateSession
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSession(nint pUnkOuter, in Guid riid, out nint ppDBSession);
}
