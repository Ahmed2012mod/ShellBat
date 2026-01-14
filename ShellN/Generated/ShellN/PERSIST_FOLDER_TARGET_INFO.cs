#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-persist_folder_target_info
public partial struct PERSIST_FOLDER_TARGET_INFO
{
    public nint pidlTargetFolder;
    public InlineArraySystemChar_260 szTargetParsingName;
    public InlineArraySystemChar_260 szNetworkProvider;
    public uint dwAttributes;
    public int csidl;
}
