#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("2af16ba9-2de5-4b75-82d9-01372afbffb4")]
public partial interface IInputPaneAnimationCoordinator
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddAnimation(nint device, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionAnimation>))] IDCompositionAnimation animation);
}
