#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("f164edf1-cc7c-4f0d-9a94-34222625c393")]
public partial interface IInternetSecurityManagerEx : IInternetSecurityManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessUrlActionEx(PWSTR pwszUrl, uint dwAction, nint /* byte array */ pPolicy, uint cbPolicy, nint /* byte array */ pContext, uint cbContext, uint dwFlags, uint dwReserved, out uint pdwOutFlags);
}
