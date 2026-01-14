#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("55136804-b2de-11d1-b9f2-00a0c98bc547")]
public partial interface IShellFavoritesNameSpace : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveSelectionUp();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveSelectionDown();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetSort();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NewFolder();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Synchronize();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Import();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Export();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeContextMenuCommand(BSTR strCommand);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveSelectionTo();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SubscriptionsEnabled(out VARIANT_BOOL pBool);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSubscriptionForSelection(out VARIANT_BOOL pBool);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteSubscriptionForSelection(out VARIANT_BOOL pBool);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRoot(BSTR bstrFullPath);
}
