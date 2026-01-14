namespace ShellN.Extensions.Utilities;

public class PreRenameItemEventArgs(
    _TRANSFER_SOURCE_FLAGS flags,
    IShellItem item,
    string? newName) : FileOperationEventArgs(flags)
{
    public IShellItem Item { get; } = item;
    public string? NewName { get; } = newName;
}

