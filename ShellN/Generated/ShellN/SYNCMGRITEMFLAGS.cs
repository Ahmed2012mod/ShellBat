#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/ne-mobsync-syncmgritemflags
public enum SYNCMGRITEMFLAGS
{
    SYNCMGRITEM_HASPROPERTIES = 1,
    SYNCMGRITEM_TEMPORARY = 2,
    SYNCMGRITEM_ROAMINGUSER = 4,
    SYNCMGRITEM_LASTUPDATETIME = 8,
    SYNCMGRITEM_MAYDELETEITEM = 16,
    SYNCMGRITEM_HIDDEN = 32,
}
