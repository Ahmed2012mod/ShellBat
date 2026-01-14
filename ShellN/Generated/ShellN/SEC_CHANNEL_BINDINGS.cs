#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/sspi/ns-sspi-sec_channel_bindings
public partial struct SEC_CHANNEL_BINDINGS
{
    public uint dwInitiatorAddrType;
    public uint cbInitiatorLength;
    public uint dwInitiatorOffset;
    public uint dwAcceptorAddrType;
    public uint cbAcceptorLength;
    public uint dwAcceptorOffset;
    public uint cbApplicationDataLength;
    public uint dwApplicationDataOffset;
}
