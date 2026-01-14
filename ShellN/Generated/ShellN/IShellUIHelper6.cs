#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("987a573e-46ee-4e89-96ab-ddf7f8fdc98c")]
public partial interface IShellUIHelper6 : IShellUIHelper5
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msStopPeriodicTileUpdate();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msStartPeriodicTileUpdate(VARIANT pollingUris, VARIANT startTime, VARIANT uiUpdateRecurrence);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msStartPeriodicTileUpdateBatch(VARIANT pollingUris, VARIANT startTime, VARIANT uiUpdateRecurrence);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msClearTile();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msEnableTileNotificationQueue(VARIANT_BOOL fChange);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msPinnedSiteState(out VARIANT pvarSiteState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msEnableTileNotificationQueueForSquare150x150(VARIANT_BOOL fChange);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msEnableTileNotificationQueueForWide310x150(VARIANT_BOOL fChange);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msEnableTileNotificationQueueForSquare310x310(VARIANT_BOOL fChange);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msScheduledTileNotification(BSTR bstrNotificationXml, BSTR bstrNotificationId, BSTR bstrNotificationTag, VARIANT startTime, VARIANT expirationTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msRemoveScheduledTileNotification(BSTR bstrNotificationId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msStartPeriodicBadgeUpdate(BSTR pollingUri, VARIANT startTime, VARIANT uiUpdateRecurrence);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msStopPeriodicBadgeUpdate();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msLaunchInternetOptions();
}
