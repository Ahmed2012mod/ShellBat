#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlwapi/ns-shlwapi-dllversioninfo2
public partial struct DLLVERSIONINFO2
{
    public DLLVERSIONINFO info1;
    public uint dwFlags;
    public ulong ullVersion;
}
