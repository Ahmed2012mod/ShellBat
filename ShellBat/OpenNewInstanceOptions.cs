namespace ShellBat;

public class OpenNewInstanceOptions
{
    public virtual string? ParsingName { get; set; }
    public virtual string? ScreenDevicePath { get; set; }
    public virtual bool AsAdministrator { get; set; }
    public virtual RECT? Rect { get; set; }
}
