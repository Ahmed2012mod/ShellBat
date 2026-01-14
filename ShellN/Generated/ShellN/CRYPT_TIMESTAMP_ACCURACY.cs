#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-crypt_timestamp_accuracy
public partial struct CRYPT_TIMESTAMP_ACCURACY
{
    public uint dwSeconds;
    public uint dwMillis;
    public uint dwMicros;
}
