#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-icreateobject
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("75121952-e0d0-43e5-9380-1d80483acf72")]
public partial interface ICreateObject
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-icreateobject-createobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateObject(in Guid clsid, nint pUnkOuter, in Guid riid, out nint /* void */ ppv);
}
