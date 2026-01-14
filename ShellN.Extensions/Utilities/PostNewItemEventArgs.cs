namespace ShellN.Extensions.Utilities;

public class PostNewItemEventArgs(
    _TRANSFER_SOURCE_FLAGS flags,
    IShellItem destinationFolder,
    string? newName,
    string? templateName,
    FileAttributes fileAttributes,
    HRESULT hrNew,
    IShellItem newItem) : FileOperationEventArgs(flags)
{
    public IShellItem DestinationFolder { get; } = destinationFolder;
    public string? NewName { get; } = newName;
    public string? TemplateName { get; } = templateName;
    public FileAttributes FileAttributes { get; } = fileAttributes;
    public HRESULT HrNew { get; } = hrNew;
    public IShellItem? NewItem { get; } = newItem;
}

