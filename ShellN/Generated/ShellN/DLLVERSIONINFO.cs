#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlwapi/ns-shlwapi-dllversioninfo
public partial struct DLLVERSIONINFO
{
    public uint cbSize;
    public uint dwMajorVersion;
    public uint dwMinorVersion;
    public uint dwBuildNumber;
    public uint dwPlatformID;
}
