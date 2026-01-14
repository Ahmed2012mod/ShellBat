namespace ShellBat;

public class ShellBatHttpServer(Uri url, ShellBatHttpLocalServer? localServer = null)
{
    public Uri Url { get; } = url ?? throw new ArgumentNullException(nameof(url));
    public int ProcessId { get; internal set; } = Environment.ProcessId;
    public ShellBatHttpLocalServer? LocalServer { get; } = localServer;

    public override string ToString() => Url.ToString();
}
