#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-sfvm_helptopic_data
public partial struct SFVM_HELPTOPIC_DATA
{
    public InlineArraySystemChar_260 wszHelpFile;
    public InlineArraySystemChar_260 wszHelpTopic;
}
