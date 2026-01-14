#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shappmgr/ne-shappmgr-appactionflags
public enum APPACTIONFLAGS
{
    APPACTION_INSTALL = 1,
    APPACTION_UNINSTALL = 2,
    APPACTION_MODIFY = 4,
    APPACTION_REPAIR = 8,
    APPACTION_UPGRADE = 16,
    APPACTION_CANGETSIZE = 32,
    APPACTION_MODIFYREMOVE = 128,
    APPACTION_ADDLATER = 256,
    APPACTION_UNSCHEDULE = 512,
}
