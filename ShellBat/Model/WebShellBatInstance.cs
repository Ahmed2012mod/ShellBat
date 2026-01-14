namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebShellBatInstance(IShellBatInstance instance) : DispatchObject
{
    public int ProcessId { get; } = instance.ProcessId;
    public string Key { get; } = instance.Name;
    public string OtherDisplayName { get; } = instance.OtherDisplayName;
    public string DisplayName { get; } = instance.DisplayName;
    public ShellBatInstanceOptions Options { get; } = instance.Options;
    public bool IsUnspecified { get; } = instance.IsUnspecified;
    public bool IsThis { get; } = instance.IsThis;
}
