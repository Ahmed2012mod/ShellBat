namespace ShellN.Extensions.Utilities;

public class PostRenameItemEventArgs(
    _TRANSFER_SOURCE_FLAGS flags,
    IShellItem item,
    string? newName,
    HRESULT hrRename,
    IShellItem newlyCreatedItem) : FileOperationEventArgs(flags)
{
    public IShellItem Item { get; } = item;
    public string? NewName { get; } = newName;
    public HRESULT HrRename { get; } = hrRename;
    public IShellItem? NewlyCreatedItem { get; } = newlyCreatedItem;
}

