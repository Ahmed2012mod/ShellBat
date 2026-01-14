namespace ShellBat.Utilities.GitHub;

public static class GitHubApi
{
    public const string BaseUrl = $"https://api.github.com/repos/smourier/{Program.AppId}/";
    public static HttpClient Client => _client.Value;

    private static readonly Lazy<HttpClient> _client = new(GetHttpClient, true);
    private static HttpClient GetHttpClient()
    {
        var client = new HttpClient(new HttpClientHandler());

        var ua = $"{Program.AppId}/{AssemblyUtilities.GetInformationalVersion()} (Windows NT {Environment.OSVersion.Version})";
        client.DefaultRequestHeaders.UserAgent.ParseAdd(ua);
        return client;
    }

    public static async Task<IReadOnlyList<GitHubRelease>> ListReleasesAsync(CancellationToken cancellationToken)
    {
        var url = BaseUrl + "releases";
        using var response = await Client.GetAsync(url, cancellationToken).ConfigureAwait(false);
        if (response.StatusCode == HttpStatusCode.NotFound)
            return [];

        await HandleResponseStatus(response).ConfigureAwait(false);
        using var stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
        var list = await JsonSerializer.DeserializeAsync(stream, JsonSourceGenerationContext.Default.GitHubReleaseArray, cancellationToken: cancellationToken).ConfigureAwait(false);
        if (list == null || list.Length == 0)
            return [];

        list.Sort();
        return list.AsReadOnly();
    }

    public static async Task<string> DownloadReleaseAsync(string url, string fileName, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(url);
        ArgumentNullException.ThrowIfNull(fileName);

        var req = new HttpRequestMessage(HttpMethod.Get, url);
        using var response = await Client.SendAsync(req, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        await HandleResponseStatus(response).ConfigureAwait(false);

        var path = Path.Combine(Path.GetTempPath(), $"{Program.AppId}_{Guid.NewGuid():B}", fileName);
        IOUtilities.FileEnsureDirectory(path);
        IOUtilities.FileDelete(path, true, false);

        using (var output = File.OpenWrite(path))
        {
            using var input = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
            var buffer = new byte[10 * 1024 * 1024];
            do
            {
                var read = await input.ReadAsync(buffer, cancellationToken).ConfigureAwait(false);
                if (read == 0)
                    break;

                await output.WriteAsync(buffer.AsMemory(0, read), cancellationToken).ConfigureAwait(false);
                if (cancellationToken.IsCancellationRequested)
                    break;
            }
            while (true);
        }
        return path;
    }

    private static async Task HandleResponseStatus(HttpResponseMessage response)
    {
        if (response.IsSuccessStatusCode)
            return;

        if (response.Content.Headers.ContentType?.MediaType.EqualsIgnoreCase("application/json") == true)
        {
            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            throw new Exception("GitHub server error " + (int)response.StatusCode + Environment.NewLine + json);
        }

        response.EnsureSuccessStatusCode();
    }
}
