#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ipersistfolder3
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("cef04fdf-fe72-11d2-87a5-00c04f6837cf")]
public partial interface IPersistFolder3 : IPersistFolder2
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipersistfolder3-initializeex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeEx([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, nint pidlRoot, in PERSIST_FOLDER_TARGET_INFO ppfti);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipersistfolder3-getfoldertargetinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolderTargetInfo(out PERSIST_FOLDER_TARGET_INFO ppfti);
}
