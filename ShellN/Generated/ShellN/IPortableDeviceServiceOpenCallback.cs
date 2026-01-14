#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("bced49c8-8efe-41ed-960b-61313abd47a9")]
public partial interface IPortableDeviceServiceOpenCallback
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnComplete(HRESULT hrStatus);
}
