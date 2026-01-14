namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebScreen : DispatchObject
{
    public WebScreen() { }

    public required string DisplayName { get; init; }
    public required string DevicePath { get; init; }
    public required DirectN.Extensions.Utilities.Monitor? Monitor { get; init; }
    public string? DeviceName { get; private set; }
    public int Top => WorkingArea.top;
    public int Left => WorkingArea.left;
    public int Height => WorkingArea.Height;
    public int Width => WorkingArea.Width;
    public RECT WorkingArea { get; private set; }
    public uint EffectiveDpi { get; private set; }
    public uint AngularDpi { get; private set; }
    public uint RawDpi { get; private set; }
    public bool IsThis
    {
        get
        {
            var window = Program.MainWindow;
            if (window == null)
                return true; // yes

            var monitor = window.GetMonitor(MONITOR_FROM_FLAGS.MONITOR_DEFAULTTONEAREST);
            if (monitor == null)
                return true;

            return monitor.DeviceName.EqualsIgnoreCase(DeviceName);
        }
    }

    public override string ToString() => DisplayName;

    public static WebScreen Get(string? devicePath) => All.FirstOrDefault(m => m.DevicePath.EqualsIgnoreCase(devicePath))!;
    public static IEnumerable<WebScreen> All
    {
        get
        {
            var dd = DisplayDevice.All.ToList();
            foreach (var path in DisplayConfig.Query())
            {
                var tar = DisplayConfig.GetTargetName(path);
                var src = DisplayConfig.GetSourceName(path);
                var display = dd.FirstOrDefault(m => m.DeviceName.EqualsIgnoreCase(src.viewGdiDeviceName.ToString()));
                if (display == null)
                    continue;

                var mon = display.Monitor;
                yield return new WebScreen
                {
                    Monitor = mon,
                    DisplayName = tar.monitorFriendlyDeviceName.ToString(),
                    DevicePath = tar.monitorDevicePath.ToString(),
                    DeviceName = src.viewGdiDeviceName.ToString(),
                    AngularDpi = mon?.AngularDpi.width ?? 96,
                    EffectiveDpi = mon?.EffectiveDpi.width ?? 96,
                    RawDpi = mon?.RawDpi.width ?? 96,
                    WorkingArea = mon?.WorkingArea ?? new RECT()
                };
            }
        }
    }
}
