#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shldisp/ne-shldisp-autocompleteoptions
public enum AUTOCOMPLETEOPTIONS
{
    ACO_NONE = 0,
    ACO_AUTOSUGGEST = 1,
    ACO_AUTOAPPEND = 2,
    ACO_SEARCH = 4,
    ACO_FILTERPREFIXES = 8,
    ACO_USETAB = 16,
    ACO_UPDOWNKEYDROPSLIST = 32,
    ACO_RTLREADING = 64,
    ACO_WORD_FILTER = 128,
    ACO_NOPREFIXFILTERING = 256,
}
