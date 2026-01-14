#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-shdescriptionid
public partial struct SHDESCRIPTIONID
{
    public uint dwDescriptionId;
    public Guid clsid;
}
