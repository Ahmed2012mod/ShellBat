namespace ShellBat.Windows;

public class WebViewResponse(Stream? stream, HttpStatusCode statusCode)
{
    public Stream? Stream { get; } = stream;
    public HttpStatusCode StatusCode { get; } = statusCode;
    public IDictionary<string, string?> Headers { get; } = new Dictionary<string, string?>(StringComparer.OrdinalIgnoreCase);

    public static WebViewResponse NotFound { get; } = new WebViewResponse(null, HttpStatusCode.NotFound);
    public static WebViewResponse NotModified { get; } = new WebViewResponse(null, HttpStatusCode.NotModified);
    public static WebViewResponse InternalServerError { get; } = new WebViewResponse(null, HttpStatusCode.InternalServerError);
}
