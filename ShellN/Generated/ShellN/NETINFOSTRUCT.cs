#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/winnetwk/ns-winnetwk-netinfostruct
public partial struct NETINFOSTRUCT
{
    public uint cbStructure;
    public uint dwProviderVersion;
    public WIN32_ERROR dwStatus;
    public NETINFOSTRUCT_CHARACTERISTICS dwCharacteristics;
    public nuint dwHandle;
    public ushort wNetType;
    public uint dwPrinters;
    public uint dwDrives;
}
