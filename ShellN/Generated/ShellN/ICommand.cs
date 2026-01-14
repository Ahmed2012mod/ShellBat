#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("0c733a63-2a1c-11ce-ade5-00aa0044773d")]
public partial interface ICommand
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Execute(nint pUnkOuter, in Guid riid, nint /* optional DBPARAMS* */ pParams, nint /* optional nint* */ pcRowsAffected, nint /* optional nint* */ ppRowset);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDBSession(in Guid riid, out nint ppSession);
}
