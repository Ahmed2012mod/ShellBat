namespace ShellN.Extensions.Utilities;

public class PostMoveItemEventArgs(
    _TRANSFER_SOURCE_FLAGS flags,
    IShellItem item,
    IShellItem destinationFolder,
    string? newName,
    HRESULT hrMove,
    IShellItem newlyCreatedItem) : FileOperationEventArgs(flags)
{
    public IShellItem Item { get; } = item;
    public IShellItem DestinationFolder { get; } = destinationFolder;
    public string? NewName { get; } = newName;
    public HRESULT HrMove { get; } = hrMove;
    public IShellItem? NewlyCreatedItem { get; } = newlyCreatedItem;
}

