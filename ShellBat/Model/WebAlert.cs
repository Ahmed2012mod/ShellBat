namespace ShellBat.Model;

public class WebAlert
{
    public string? Position { get; set; }
    public string? Width { get; set; }
    public bool Toast { get; set; } = true;
    public string? Icon { get; set; }
    public string? Title { get; set; }
    public string? Text { get; set; }
    public bool ShowConfirmButton { get; set; }
    public bool ShowDenyButton { get; set; }
    public bool ShowCancelButton { get; set; }
    public bool ShowCloseButton { get; set; }
    public bool ReverseButtons { get; set; }
    public string? ConfirmButtonText { get; set; } = Res.OK;
    public string? DenyButtonText { get; set; } = Res.No;
    public string? CancelButtonText { get; set; } = Res.Cancel;
    public int Timer { get; set; } = 1500;
    public bool TimerProgressBar { get; set; }
    public string? CustomClass { get; set; }
    public WebEventType ConfirmEventType { get; set; }
}
