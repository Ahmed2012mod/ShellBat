#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shappmgr/ne-shappmgr-pubappinfoflags
public enum PUBAPPINFOFLAGS
{
    PAI_SOURCE = 1,
    PAI_ASSIGNEDTIME = 2,
    PAI_PUBLISHEDTIME = 4,
    PAI_SCHEDULEDTIME = 8,
    PAI_EXPIRETIME = 16,
}
