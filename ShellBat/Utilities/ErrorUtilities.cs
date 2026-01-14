namespace ShellBat.Utilities;

public static class ErrorUtilities
{
    private static readonly HttpClient _client = new(new HttpClientHandler
    {
        MaxConnectionsPerServer = int.MaxValue,
        ServerCertificateCustomValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true,
    })
    {
        DefaultVersionPolicy = HttpVersionPolicy.RequestVersionOrHigher,
    };

    // see https://github.com/smourier/TracesToCsv for more details about the trace server
    public static async Task SendErrorReport(this Exception? error, IDictionary<string, object?>? values = null, CancellationToken cancellationToken = default)
    {
        if (error == null)
            return;

        try
        {
            var dic = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
            if (values != null)
            {
                foreach (var kvp in values)
                {
                    dic[kvp.Key] = kvp.Value;
                }
            }

            var trace = new ErrorTrace
            {
                Level = TraceLevel.Error,
                Timestamp = DateTimeOffset.UtcNow,
                Message = error.ToString(),
                Values = dic
            };

            var content = JsonContent.Create(trace, JsonSourceGenerationContext.Default.ErrorTrace);
            var response = await _client.PutAsync(
                "https://tracer-dngtc6cccjghguh0.centralus-01.azurewebsites.net/traces/Pu7HRielidt5Rw6IYYBqMatkvbnfnpe-X0vrl-XEEzE9INUfc_fpH3JksfTGL667",
                content,
                cancellationToken);
        }
        catch (Exception ex)
        {
            ShellBatInstance.LogError($"Error: {ex}");
        }
    }
}
