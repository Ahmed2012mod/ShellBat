#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("4a073526-6103-4e21-b7bc-f519d1524e5d")]
public partial interface IGetServiceIds
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceIds(out uint serviceIdCount, [MarshalUsing(CountElementName = nameof(serviceIdCount))] out Guid[] serviceIds);
}
