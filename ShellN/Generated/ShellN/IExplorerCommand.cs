#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iexplorercommand
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a08ce4d0-fa25-44ab-b57c-c7b1c323e0b9")]
public partial interface IExplorerCommand
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorercommand-gettitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTitle([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psiItemArray, out PWSTR ppszName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorercommand-geticon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIcon([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psiItemArray, out PWSTR ppszIcon);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorercommand-gettooltip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetToolTip([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psiItemArray, out PWSTR ppszInfotip);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorercommand-getcanonicalname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCanonicalName(out Guid pguidCommandName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorercommand-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psiItemArray, BOOL fOkToBeSlow, out uint pCmdState);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorercommand-invoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psiItemArray, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorercommand-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out uint pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorercommand-enumsubcommands
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumSubCommands([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumExplorerCommand>))] out IEnumExplorerCommand ppEnum);
}
