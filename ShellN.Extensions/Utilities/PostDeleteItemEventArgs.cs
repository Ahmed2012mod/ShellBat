namespace ShellN.Extensions.Utilities;

public class PostDeleteItemEventArgs(
    _TRANSFER_SOURCE_FLAGS flags,
    IShellItem item,
    HRESULT hrDelete,
    IShellItem? newlyCreatedItem) : FileOperationEventArgs(flags)
{
    public IShellItem Item { get; } = item;
    public HRESULT HrDelete { get; } = hrDelete;
    public IShellItem? NewlyCreatedItem { get; } = newlyCreatedItem;
}

