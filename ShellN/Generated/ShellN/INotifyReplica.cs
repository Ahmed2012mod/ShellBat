#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/reconcil/nn-reconcil-inotifyreplica
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("99180163-da16-101a-935c-444553540000")]
public partial interface INotifyReplica
{
    // https://learn.microsoft.com/windows/win32/api/reconcil/nf-reconcil-inotifyreplica-youareareplica
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT YouAreAReplica(uint ulcOtherReplicas, [In][Out][MarshalUsing(CountElementName = nameof(ulcOtherReplicas))] IMoniker[] rgpmkOtherReplicas);
}
