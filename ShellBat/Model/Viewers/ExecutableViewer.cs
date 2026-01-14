namespace ShellBat.Model.Viewers;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class ExecutableViewer(Entry entry) : Viewer(entry)
{
    public override string? Icon => "fa-solid fa-bolt";
    public override bool IsSupported => !Entry.IsFolder && Entry.Extension.IsExecutable;

    public IReadOnlyList<string> GetExports()
    {
        var exports = PEInfo.FromFile(Entry.ParsingName);
        return exports?.Exports ?? [];
    }
}
