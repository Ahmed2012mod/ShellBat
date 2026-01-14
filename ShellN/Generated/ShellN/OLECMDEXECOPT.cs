#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/docobj/ne-docobj-olecmdexecopt
public enum OLECMDEXECOPT
{
    OLECMDEXECOPT_DODEFAULT = 0,
    OLECMDEXECOPT_PROMPTUSER = 1,
    OLECMDEXECOPT_DONTPROMPTUSER = 2,
    OLECMDEXECOPT_SHOWHELP = 3,
}
