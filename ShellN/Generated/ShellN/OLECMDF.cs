#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/docobj/ne-docobj-olecmdf
public enum OLECMDF
{
    OLECMDF_SUPPORTED = 1,
    OLECMDF_ENABLED = 2,
    OLECMDF_LATCHED = 4,
    OLECMDF_NINCHED = 8,
    OLECMDF_INVISIBLE = 16,
    OLECMDF_DEFHIDEONCTXTMENU = 32,
}
