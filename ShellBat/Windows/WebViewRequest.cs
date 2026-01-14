namespace ShellBat.Windows;

public class WebViewRequest(string method, string url, COREWEBVIEW2_WEB_RESOURCE_CONTEXT context)
{
    public string Method { get; } = method;
    public string Url { get; } = url;
    public COREWEBVIEW2_WEB_RESOURCE_CONTEXT Context { get; } = context;
    public IDictionary<string, string?> Headers { get; } = new Dictionary<string, string?>(StringComparer.OrdinalIgnoreCase);
}
