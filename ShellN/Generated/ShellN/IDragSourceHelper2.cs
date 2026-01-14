#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-idragsourcehelper2
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("83e07d0d-0c5f-4163-bf1a-60b274051e40")]
public partial interface IDragSourceHelper2 : IDragSourceHelper
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-idragsourcehelper2-setflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(uint dwFlags);
}
