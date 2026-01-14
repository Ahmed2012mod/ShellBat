#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("7ebfdd80-ad18-11d3-a4c5-00c04f72d6b8")]
public partial interface ITravelLogStg
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEntry(PWSTR pszUrl, PWSTR pszTitle, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITravelLogEntry>))] ITravelLogEntry ptleRelativeTo, BOOL fPrepend, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITravelLogEntry>))] out ITravelLogEntry pptle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TravelTo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITravelLogEntry>))] ITravelLogEntry ptle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumEntries(TLENUMF flags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumTravelLogEntry>))] out IEnumTravelLogEntry ppenum);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindEntries(TLENUMF flags, PWSTR pszUrl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumTravelLogEntry>))] out IEnumTravelLogEntry ppenum);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(TLENUMF flags, out uint pcEntries);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveEntry([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITravelLogEntry>))] ITravelLogEntry ptle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRelativeEntry(int iOffset, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITravelLogEntry>))] out ITravelLogEntry ptle);
}
