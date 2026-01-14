#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-itransferadvisesink
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d594d0d8-8da7-457b-b3b4-ce5dbaac0b88")]
public partial interface ITransferAdviseSink
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itransferadvisesink-updateprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateProgress(ulong ullSizeCurrent, ulong ullSizeTotal, int nFilesCurrent, int nFilesTotal, int nFoldersCurrent, int nFoldersTotal);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itransferadvisesink-updatetransferstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateTransferState(uint ts);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itransferadvisesink-confirmoverwrite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConfirmOverwrite([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiSource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiDestParent, PWSTR pszName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itransferadvisesink-confirmencryptionloss
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConfirmEncryptionLoss([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiSource);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itransferadvisesink-filefailure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FileFailure([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, PWSTR pszItem, HRESULT hrError, [MarshalUsing(CountElementName = nameof(cchRename))] PWSTR pszRename, uint cchRename);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itransferadvisesink-substreamfailure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SubStreamFailure([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, PWSTR pszStreamName, HRESULT hrError);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itransferadvisesink-propertyfailure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PropertyFailure([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, in PROPERTYKEY pkey, HRESULT hrError);
}
