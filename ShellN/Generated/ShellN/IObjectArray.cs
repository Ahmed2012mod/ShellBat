#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/objectarray/nn-objectarray-iobjectarray
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("92ca9dcd-5622-4bba-a805-5e9f541bd8c9")]
public partial interface IObjectArray
{
    // https://learn.microsoft.com/windows/win32/api/objectarray/nf-objectarray-iobjectarray-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pcObjects);
    
    // https://learn.microsoft.com/windows/win32/api/objectarray/nf-objectarray-iobjectarray-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint uiIndex, in Guid riid, out nint /* void */ ppv);
}
