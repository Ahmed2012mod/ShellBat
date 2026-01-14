namespace ShellN;

[GeneratedComInterface, Guid("fc992f1f-debb-4596-b355-50c7a6dd1222")]
public partial interface IWaitCursorManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start(CURSORID id);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Restore();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop(CURSORID id);
}
