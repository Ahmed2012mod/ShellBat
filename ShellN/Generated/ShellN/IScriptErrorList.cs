#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("f3470f24-15fd-11d2-bb2e-00805ff7efca")]
public partial interface IScriptErrorList : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT advanceError();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT retreatError();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT canAdvanceError(out BOOL pfCanAdvance);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT canRetreatError(out BOOL pfCanRetreat);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getErrorLine(out int plLine);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getErrorChar(out int plChar);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getErrorCode(out int plCode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getErrorMsg(out BSTR pstr);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getErrorUrl(out BSTR pstr);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getAlwaysShowLockState(out BOOL pfAlwaysShowLocked);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getDetailsPaneOpen(out BOOL pfDetailsPaneOpen);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setDetailsPaneOpen(BOOL fDetailsPaneOpen);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getPerErrorDisplay(out BOOL pfPerErrorDisplay);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setPerErrorDisplay(BOOL fPerErrorDisplay);
}
