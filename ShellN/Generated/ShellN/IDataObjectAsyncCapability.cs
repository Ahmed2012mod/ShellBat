#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shldisp/nn-shldisp-idataobjectasynccapability
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("3d8b0590-f691-11d2-8ea9-006097df5bd4")]
public partial interface IDataObjectAsyncCapability
{
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-idataobjectasynccapability-setasyncmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAsyncMode(BOOL fDoOpAsync);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-idataobjectasynccapability-getasyncmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAsyncMode(out BOOL pfIsOpAsync);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-idataobjectasynccapability-startoperation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartOperation([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx?>))] IBindCtx? pbcReserved);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-idataobjectasynccapability-inoperation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InOperation(out BOOL pfInAsyncOp);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-idataobjectasynccapability-endoperation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndOperation(HRESULT hResult, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbcReserved, uint dwEffects);
}
