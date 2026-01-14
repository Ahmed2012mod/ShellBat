namespace ShellN.Extensions.Utilities;

public abstract class FileOperationEventArgs(_TRANSFER_SOURCE_FLAGS flags) : EventArgs
{
    public _TRANSFER_SOURCE_FLAGS Flags { get; } = flags;
    public virtual HRESULT HResult { get; set; }
}
