namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebPropertyGridProperty : DispatchObject, IComparable<WebPropertyGridProperty>, IComparable
{
    public string Key { get; set; } = string.Empty;
    public string? Editor { get; set; }
    public string? CategoryName { get; set; }
    public string? DisplayName { get; set; }
    public string? Tooltip { get; set; }
    public bool HasDefault { get; set; }
    public object? DefaultValue { get; set; }
    public bool IsReadOnly { get; set; }
    public bool IsEnum { get; set; }
    public bool IsFlagsEnum { get; set; }
    public bool IsHidden { get; set; } // not rendered in the HTML UI
    public bool IsHtml { get; set; }
    public string? BaseClassName { get; set; }
    public IDictionary<string, object?>? EnumValues { get; set; }

    int IComparable.CompareTo(object? obj) => CompareTo(obj as WebPropertyGridProperty);
    public int CompareTo(WebPropertyGridProperty? other)
    {
        ArgumentNullException.ThrowIfNull(other);
        var name = DisplayName ?? Key;
        var otherName = other.DisplayName ?? other.Key;
        return string.Compare(name, otherName, StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString() => $"{Key} ({Editor})";
}
