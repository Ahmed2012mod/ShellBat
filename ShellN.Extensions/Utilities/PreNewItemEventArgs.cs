namespace ShellN.Extensions.Utilities;

public class PreNewItemEventArgs(
    _TRANSFER_SOURCE_FLAGS flags,
    IShellItem destinationFolder,
    string? newName) : FileOperationEventArgs(flags)
{
    public IShellItem DestinationFolder { get; } = destinationFolder;
    public string? NewName { get; } = newName;
}

