#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-inamespacewalkcb2
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7ac7492b-c38e-438a-87db-68737844ff70")]
public partial interface INamespaceWalkCB2 : INamespaceWalkCB
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacewalkcb2-walkcomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WalkComplete(HRESULT hr);
}
