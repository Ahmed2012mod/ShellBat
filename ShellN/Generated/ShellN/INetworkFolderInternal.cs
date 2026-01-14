#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("ceb38218-c971-47bb-a703-f0bc99ccdb81")]
public partial interface INetworkFolderInternal
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceDisplayType(out uint displayType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIDList(out nint idList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProvider(uint itemIdCount, [In][Out][MarshalUsing(CountElementName = nameof(itemIdCount))] nint[] itemIds, uint providerMaxLength, [MarshalUsing(CountElementName = nameof(providerMaxLength))] PWSTR provider);
}
