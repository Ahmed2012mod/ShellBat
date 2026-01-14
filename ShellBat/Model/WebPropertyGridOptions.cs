namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebPropertyGridOptions : DispatchObject
{
    public string? Title { get; set; }
    public bool IsReadOnly { get; set; }
    public bool ExpandIfOneCategory { get; set; } = true;
    public string? PropertyNamePostfix { get; set; }
    public bool GroupByCategory { get; set; } = true;
    public string? DefaultCategoryName { get; set; } = "General";
    public string? ResourcePrefix { get; set; } = "PG_";
    public IList<WebPropertyGridCategory> Categories { get; set; } = [];
    public string? BaseClassName { get; set; }
    public string? SwalClassName { get; set; }
}
