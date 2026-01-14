#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ienumreadycallback
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("61e00d45-8fff-4e60-924e-6537b61612dd")]
public partial interface IEnumReadyCallback
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ienumreadycallback-enumready
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumReady();
}
