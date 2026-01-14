namespace ShellN;

[GeneratedComInterface, Guid("1cbff8c0-da47-4ebe-9928-2e642f00b5bc")]
public partial interface IInitializeWithFolder
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellFolder>))] IShellFolder folder);
}
