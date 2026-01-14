namespace ShellN.Extensions.Utilities;

public class PreDeleteItemEventArgs(
    _TRANSFER_SOURCE_FLAGS flags,
    IShellItem item) : FileOperationEventArgs(flags)
{
    public IShellItem Item { get; } = item;
}

