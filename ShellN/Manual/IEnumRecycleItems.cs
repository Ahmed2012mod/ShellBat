namespace ShellN;

[GeneratedComInterface, Guid("6e325f88-d12f-49e5-895b-8ec98630c021")]
public partial interface IEnumRecycleItems
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] DELETEDITEM[] pItems, nint /* optional uint* */ pceltFetched);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumRecycleItems>))] out IEnumRecycleItems items);
}
