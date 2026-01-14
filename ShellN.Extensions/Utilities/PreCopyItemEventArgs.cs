namespace ShellN.Extensions.Utilities;

public class PreCopyItemEventArgs(
    _TRANSFER_SOURCE_FLAGS flags,
    IShellItem item,
    IShellItem destinationFolder,
    string? newName) : FileOperationEventArgs(flags)
{
    public IShellItem Item { get; } = item;
    public IShellItem DestinationFolder { get; } = destinationFolder;
    public string? NewName { get; } = newName;
}

