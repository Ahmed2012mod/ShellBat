#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iattachmentexecute
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("73db1241-1e85-4581-8e4f-a81e1d0f8c57")]
public partial interface IAttachmentExecute
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iattachmentexecute-setclienttitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClientTitle(PWSTR pszTitle);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iattachmentexecute-setclientguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClientGuid(in Guid guid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iattachmentexecute-setlocalpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLocalPath(PWSTR pszLocalPath);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iattachmentexecute-setfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFileName(PWSTR pszFileName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iattachmentexecute-setsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSource(PWSTR pszSource);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iattachmentexecute-setreferrer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReferrer(PWSTR pszReferrer);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iattachmentexecute-checkpolicy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckPolicy();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iattachmentexecute-prompt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Prompt(HWND hwnd, ATTACHMENT_PROMPT prompt, out ATTACHMENT_ACTION paction);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iattachmentexecute-save
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Save();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iattachmentexecute-execute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Execute(HWND hwnd, PWSTR pszVerb, nint /* optional HANDLE* */ phProcess);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iattachmentexecute-savewithui
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveWithUI(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iattachmentexecute-clearclientstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearClientState();
}
