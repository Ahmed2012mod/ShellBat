namespace ShellBat.Utilities;

public class PreviewHandlerOptions
{
    public virtual SIZE? Size { get; set; }
    public virtual int? SnapshotTimeout { get; set; }
    internal int FinalTimeout { get; set; }
    internal Size FinalSize { get; set; }

    public static SIZE GetDefaultSize()
    {
        var primary = DirectN.Extensions.Utilities.Monitor.Primary;
        if (primary != null)
            return new()
            {
                cx = primary.WorkingArea.Width * 2 / 3,
                cy = primary.WorkingArea.Height * 2 / 3,
            };

        return new(1440, 960);
    }
}
