#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-inamespacetreecontroldrophandler
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f9c665d6-c2f2-4c19-bf33-8322d7352f51")]
public partial interface INameSpaceTreeControlDropHandler
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontroldrophandler-ondragenter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDragEnter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem?>))] IShellItem? psiOver, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psiaData, BOOL fOutsideSource, uint grfKeyState, ref uint pdwEffect);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontroldrophandler-ondragover
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDragOver([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem?>))] IShellItem? psiOver, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psiaData, uint grfKeyState, ref uint pdwEffect);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontroldrophandler-ondragposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDragPosition([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem?>))] IShellItem? psiOver, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psiaData, int iNewPosition, int iOldPosition);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontroldrophandler-ondrop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDrop([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem?>))] IShellItem? psiOver, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psiaData, int iPosition, uint grfKeyState, ref uint pdwEffect);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontroldrophandler-ondropposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDropPosition([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem?>))] IShellItem? psiOver, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psiaData, int iNewPosition, int iOldPosition);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontroldrophandler-ondragleave
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDragLeave([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem?>))] IShellItem? psiOver);
}
