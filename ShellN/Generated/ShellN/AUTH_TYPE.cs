#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/ne-searchapi-auth_type
public enum AUTH_TYPE
{
    eAUTH_TYPE_ANONYMOUS = 0,
    eAUTH_TYPE_NTLM = 1,
    eAUTH_TYPE_BASIC = 2,
}
