#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shdeprecated/ns-shdeprecated-foldersetdata
public partial struct FOLDERSETDATA
{
    public FOLDERSETTINGS _fs;
    public Guid _vidRestore;
    public uint _dwViewPriority;
}
