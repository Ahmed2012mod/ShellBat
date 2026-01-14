#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iobjectprovider
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a6087428-3be3-4d73-b308-7c04a540bf1a")]
public partial interface IObjectProvider
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iobjectprovider-queryobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryObject(in Guid guidObject, in Guid riid, out nint /* void */ ppvOut);
}
