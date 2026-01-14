#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("75bd59aa-f23b-4963-aba4-0b355752a91b")]
public partial interface IPropertyKeyStore
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKeyCount(out int keyCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKeyAt(int index, out PROPERTYKEY pkey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendKey(in PROPERTYKEY key);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteKey(int index);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsKeyInStore(in PROPERTYKEY key);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveKey(in PROPERTYKEY key);
}
