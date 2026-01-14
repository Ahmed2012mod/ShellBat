#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("9ba05970-f6a8-11cf-a442-00a0c90a8f39")]
public partial interface IFolderViewOC : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFolderView([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] IDispatch pdisp);
}
