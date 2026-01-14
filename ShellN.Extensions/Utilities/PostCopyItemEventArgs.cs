namespace ShellN.Extensions.Utilities;

public class PostCopyItemEventArgs(
    _TRANSFER_SOURCE_FLAGS flags,
    IShellItem item,
    IShellItem destinationFolder,
    string? newName,
    HRESULT hrCopy,
    IShellItem newlyCreatedItem) : FileOperationEventArgs(flags)
{
    public IShellItem Item { get; } = item;
    public IShellItem DestinationFolder { get; } = destinationFolder;
    public string? NewName { get; } = newName;
    public HRESULT HrCopy { get; } = hrCopy;
    public IShellItem? NewlyCreatedItem { get; } = newlyCreatedItem;
}

