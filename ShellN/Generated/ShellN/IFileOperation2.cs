#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("cd8f23c1-8f61-4916-909d-55bdd0918753")]
public partial interface IFileOperation2 : IFileOperation
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOperationFlags2(FILE_OPERATION_FLAGS2 operationFlags2);
}
