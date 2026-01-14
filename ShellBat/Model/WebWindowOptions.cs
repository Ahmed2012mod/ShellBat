namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebWindowOptions : DispatchObject
{
    public WebWindowOptions(ShellBatWindow window)
    {
        ArgumentNullException.ThrowIfNull(window);
        Window = window;
    }

    public ShellBatWindow Window { get; }
    public BorderSnap BorderSnap { get; set; }
    public int DockPadding { get; } = ShellBatInstance.Current.Settings.DockPadding;
    public string? Title { get; set; }
    public string? Icon { get; set; }
    public string? ResourcePrefix { get; set; } = "WIN_";
    public string? ClassName { get; set; } = "fld-window";
    public WebWindowStyles Styles { get; set; } = WebWindowStyles.IsDraggable | WebWindowStyles.IsResizeable | WebWindowStyles.IsCloseable;
}
