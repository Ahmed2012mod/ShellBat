#nullable enable
namespace ShellN;

[Flags]
public enum SHCNRF_SOURCE
{
    SHCNRF_InterruptLevel = 1,
    SHCNRF_ShellLevel = 2,
    SHCNRF_RecursiveInterrupt = 4096,
    SHCNRF_NewDelivery = 32768,
}
