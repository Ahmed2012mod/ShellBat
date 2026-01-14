#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("0c733a8b-2a1c-11ce-ade5-00aa0044773d")]
public partial interface IDBInitialize
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Uninitialize();
}
