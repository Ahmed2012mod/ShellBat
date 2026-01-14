namespace ShellBat.Model;

[Flags]
public enum CacheTypes
{
    None = 0x0,
    WebView2 = 0x1,
    HttpServer = 0x2,

    All = WebView2 | HttpServer,
}
