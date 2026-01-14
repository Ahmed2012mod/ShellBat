namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebPropertyGridCategory : DispatchObject
{
    public string Key { get; set; } = string.Empty;
    public string? DisplayName { get; set; }
    public bool Collapsed { get; set; }
    public int? SortOrder { get; set; }

    public override string ToString() => Key;
}
