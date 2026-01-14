namespace ShellBat.Model;

public class WebKeyEvent
{
    public virtual string? Type { get; set; }
    public virtual string? Key { get; set; }
    public virtual string? Code { get; set; }
    public virtual bool Alt { get; set; }
    public virtual bool Shift { get; set; }
    public virtual bool Ctrl { get; set; }
    public virtual bool Meta { get; set; }

    public override string ToString() => $"{Type} - Key: {Key}, Code: {Code} Alt: {Alt}, Shift: {Shift}, Ctrl: {Ctrl}, Meta: {Meta}";
}
