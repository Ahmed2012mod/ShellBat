#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iresultsfolder
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("96e5ae6d-6ae1-4b1c-900c-c6480eaa8828")]
public partial interface IResultsFolder
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iresultsfolder-additem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iresultsfolder-addidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddIDList(nint pidl, nint /* optional nint** */ ppidlAdded);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iresultsfolder-removeitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iresultsfolder-removeidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveIDList(nint pidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iresultsfolder-removeall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAll();
}
