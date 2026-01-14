#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/objectarray/nn-objectarray-iobjectcollection
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5632b1a4-e38a-400a-928a-d4cd63230295")]
public partial interface IObjectCollection : IObjectArray
{
    // https://learn.microsoft.com/windows/win32/api/objectarray/nf-objectarray-iobjectcollection-addobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddObject(nint punk);
    
    // https://learn.microsoft.com/windows/win32/api/objectarray/nf-objectarray-iobjectcollection-addfromarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFromArray([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IObjectArray>))] IObjectArray poaSource);
    
    // https://learn.microsoft.com/windows/win32/api/objectarray/nf-objectarray-iobjectcollection-removeobjectat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveObjectAt(uint uiIndex);
    
    // https://learn.microsoft.com/windows/win32/api/objectarray/nf-objectarray-iobjectcollection-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
}
