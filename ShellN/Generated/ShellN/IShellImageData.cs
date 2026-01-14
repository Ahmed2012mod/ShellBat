#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shimgdata/nn-shimgdata-ishellimagedata
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("bfdeec12-8040-4403-a5ea-9e07dafcf530")]
public partial interface IShellImageData
{
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-decode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Decode(uint dwFlags, uint cxDesired, uint cyDesired);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-draw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Draw(HDC hdc, ref RECT prcDest, ref RECT prcSrc);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-nextframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NextFrame();
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-nextpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NextPage();
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-prevpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrevPage();
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-istransparent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsTransparent();
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-isanimated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsAnimated();
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-isvector
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsVector();
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-ismultipage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsMultipage();
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-iseditable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEditable();
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-isprintable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsPrintable();
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-isdecoded
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDecoded();
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-getcurrentpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentPage(ref uint pnPage);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-getpagecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPageCount(ref uint pcPages);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-selectpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectPage(uint iPage);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-getsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSize(ref SIZE pSize);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-getrawdataformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRawDataFormat(ref Guid pDataFormat);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-getpixelformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPixelFormat(ref uint pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-getdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDelay(ref uint pdwDelay);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-getproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperties(uint dwMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertySetStorage>))] out IPropertySetStorage ppPropSet);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-rotate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Rotate(uint dwAngle);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-scale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Scale(uint cx, uint cy, InterpolationMode hints);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-discardedit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DiscardEdit();
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-setencoderparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEncoderParams([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyBag>))] IPropertyBag pbagEnc);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-displayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayName(PWSTR wszName, uint cch);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-getresolution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResolution(ref uint puResolutionX, ref uint puResolutionY);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-getencoderparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEncoderParams(ref Guid pguidFmt, out nint /* byte array */ ppEncParams);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-registerabort
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterAbort([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellImageDataAbort>))] IShellImageDataAbort pAbort, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellImageDataAbort>))] out IShellImageDataAbort ppAbortPrev);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-cloneframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CloneFrame(out nint /* byte array */ ppImg);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedata-replaceframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReplaceFrame(nint /* byte array */ pImg);
}
