namespace ShellBat.Model;

[AttributeUsage(AttributeTargets.Property)]
public sealed class WebPropertyGridPropertyAttribute : Attribute
{
    public bool IsHidden { get; set; }
    public bool IsHtml { get; set; }
    public string? BaseClassName { get; set; }
    public bool Windows11Only { get; set; }
    public bool NeedsRestart { get; set; }
    public EnumProvider EnumProvider { get; set; }
}
