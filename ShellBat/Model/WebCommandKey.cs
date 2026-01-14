namespace ShellBat.Model;

public class WebCommandKey
{
    public VIRTUAL_KEY Key { get; set; }
    public string? CommandText { get; set; }
    public string? DefaultCommandText { get; set; }
    public bool Ctrl { get; set; }
    public bool Shift { get; set; }
    public bool Alt { get; set; }
    public string? CommandName { get; set; }
    public string? ErrorText { get; set; }
    public bool IsValid { get; set; }
    public bool PreventDefault { get; set; }
}
