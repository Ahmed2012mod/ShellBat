#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrhandlercollection
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a7f337a3-d20b-45cb-9ed7-87d094ca5045")]
public partial interface ISyncMgrHandlerCollection
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandlercollection-gethandlerenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHandlerEnumerator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumString>))] out IEnumString ppenum);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandlercollection-bindtohandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindToHandler(PWSTR pszHandlerID, in Guid riid, out nint /* void */ ppv);
}
