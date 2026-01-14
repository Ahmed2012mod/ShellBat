namespace ShellBat.Model;

// update ShellBatChildWindows if you change this class
public class WebWindowShowOptions
{
    public bool ForceOpen { get; set; }
    public bool NewWindow { get; set; }

    public float Left { get; set; }
    public float Top { get; set; }
    public float Right { get; set; }
    public float Bottom { get; set; }

    // properties window
    public string? ViewerId { get; set; }
    public string? PinnedViewerId { get; set; }
    public IDictionary<string, object?>? ViewerOptions { get; set; }

    // terminal window
    public string? CommandLine { get; set; }
}
