#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("edc817aa-92b8-11d1-b075-00c04fc33aa5")]
public partial interface FolderItem2 : FolderItem
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeVerbEx(VARIANT vVerb, VARIANT vArgs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExtendedProperty(BSTR bstrPropName, out VARIANT pvRet);
}
