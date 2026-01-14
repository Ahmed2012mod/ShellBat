#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cmsg_stream_info
public partial struct CMSG_STREAM_INFO
{
    public uint cbContent;
    public nint pfnStreamOutput;
    public nint pvArg;
}
