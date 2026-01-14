namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebMenuItem : DispatchObject
{
    public virtual string? Id { get; set; }
    public virtual string? Html { get; set; }
    public virtual string? Icon { get; set; }
    public virtual string? IconPath { get; set; }
    public virtual string? ClassName { get; set; }
    public virtual string? Tooltip { get; set; }
    public virtual bool IsSeparator { get; set; }
    public virtual bool IsChecked { get; set; }
    public virtual bool IsDisabled { get; set; }

    public IList<WebMenuItem> Items { get; internal set; } = [];

    public override string ToString() => IsSeparator ? "-" : Html ?? Id ?? string.Empty;
}
