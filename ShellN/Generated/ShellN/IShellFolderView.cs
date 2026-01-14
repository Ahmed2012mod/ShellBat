#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-ishellfolderview
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("37a378c0-f82d-11ce-ae65-08002b2e1262")]
public partial interface IShellFolderView
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-rearrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Rearrange(LPARAM lParamSort);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-getarrangeparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetArrangeParam(out LPARAM plParamSort);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-arrangegrid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ArrangeGrid();
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-autoarrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AutoArrange();
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-getautoarrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAutoArrange();
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-addobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddObject(nint pidl, out uint puItem);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-getobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObject(out nint ppidl, uint uItem);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-removeobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveObject(nint /* optional nint* */ pidl, out uint puItem);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-getobjectcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectCount(out uint puCount);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-setobjectcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetObjectCount(uint uCount, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-updateobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateObject(nint pidlOld, nint pidlNew, out uint puItem);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-refreshobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RefreshObject(nint pidl, out uint puItem);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-setredraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedraw(BOOL bRedraw);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-getselectedcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelectedCount(out uint puSelected);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-getselectedobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelectedObjects(out nint pppidl, out uint puItems);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-isdroponsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDropOnSource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDropTarget?>))] IDropTarget? pDropTarget);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-getdragpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDragPoint(out POINT ppt);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-getdroppoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDropPoint(out POINT ppt);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-moveicons
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveIcons([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pDataObject);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-setitempos
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetItemPos(nint pidl, in POINT ppt);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-isbkdroptarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsBkDropTarget([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDropTarget?>))] IDropTarget? pDropTarget);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-setclipboard
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClipboard(BOOL bMove);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-setpoints
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPoints([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pDataObject);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-getitemspacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemSpacing(out ITEMSPACING pSpacing);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-setcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCallback([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellFolderViewCB?>))] IShellFolderViewCB? pNewCB, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellFolderViewCB>))] out IShellFolderViewCB ppOldCB);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-select
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Select(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-querysupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QuerySupport(ref uint pdwSupport);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderview-setautomationobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAutomationObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch?>))] IDispatch? pdisp);
}
