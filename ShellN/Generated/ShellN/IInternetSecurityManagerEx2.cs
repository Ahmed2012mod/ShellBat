#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("f1e50292-a795-4117-8e09-2b560a72ac60")]
public partial interface IInternetSecurityManagerEx2 : IInternetSecurityManagerEx
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapUrlToZoneEx2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IUri>))] IUri pUri, out uint pdwZone, uint dwFlags, nint /* optional PWSTR* */ ppwszMappedUrl, nint /* optional uint* */ pdwOutFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessUrlActionEx2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IUri>))] IUri pUri, uint dwAction, nint /* byte array */ pPolicy, uint cbPolicy, nint /* byte array */ pContext, uint cbContext, uint dwFlags, nuint dwReserved, out uint pdwOutFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSecurityIdEx2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IUri>))] IUri pUri, nint /* byte array */ pbSecurityId, ref uint pcbSecurityId, nuint dwReserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryCustomPolicyEx2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IUri>))] IUri pUri, in Guid guidKey, out nint /* byte array */ ppPolicy, out uint pcbPolicy, nint /* byte array */ pContext, uint cbContext, nuint dwReserved);
}
