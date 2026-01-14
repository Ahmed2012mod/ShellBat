namespace ShellBat;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    ReadCommentHandling = JsonCommentHandling.Skip,
    PropertyNameCaseInsensitive = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    Converters = [
        typeof(JsonCustomConverterFactory),
        typeof(JsonStringEnumConverter<TokenElevationType>),
        ])]
[JsonSerializable(typeof(GitHubAsset))]
[JsonSerializable(typeof(GitHubRelease))]
[JsonSerializable(typeof(GitHubRelease[]))]
[JsonSerializable(typeof(WebKeyEvent))]
[JsonSerializable(typeof(WebAlert))]
[JsonSerializable(typeof(WebCommandKey))]
[JsonSerializable(typeof(WebWindowShowOptions))]
[JsonSerializable(typeof(WebFindStringsResult))]
[JsonSerializable(typeof(WebWindowsSearchResult))]
[JsonSerializable(typeof(EditorControlObjectOptions))]
[JsonSerializable(typeof(ErrorTrace))]
[JsonSerializable(typeof(FileAttributes))]
[JsonSerializable(typeof(SFGAO_FLAGS))]
[JsonSerializable(typeof(Version))]
[JsonSerializable(typeof(TokenElevationType))]
[JsonSerializable(typeof(ProcessorArchitecture))]
[JsonSerializable(typeof(LanguageExtensionPoint[]))]
[JsonSerializable(typeof(EditorControlObjectOptions))]
[JsonSerializable(typeof(History))]
[JsonSerializable(typeof(Architecture))]
[JsonSerializable(typeof(JsonDocument))]
[JsonSerializable(typeof(JsonElement))]
[JsonSerializable(typeof(IDictionary<string, string?>))]
[JsonSerializable(typeof(Guid))]
[JsonSerializable(typeof(object))]
[JsonSerializable(typeof(object[]))]
[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(string[]))]
[JsonSerializable(typeof(long))]
[JsonSerializable(typeof(long[]))]
[JsonSerializable(typeof(bool))]
[JsonSerializable(typeof(ulong))]
[JsonSerializable(typeof(ulong[]))]
[JsonSerializable(typeof(int))]
[JsonSerializable(typeof(int[]))]
[JsonSerializable(typeof(uint))]
[JsonSerializable(typeof(uint[]))]
[JsonSerializable(typeof(ushort))]
[JsonSerializable(typeof(ushort[]))]
[JsonSerializable(typeof(short))]
[JsonSerializable(typeof(short[]))]
[JsonSerializable(typeof(double))]
[JsonSerializable(typeof(double[]))]
[JsonSerializable(typeof(float))]
[JsonSerializable(typeof(float[]))]
[JsonSerializable(typeof(byte))]
[JsonSerializable(typeof(byte[]))]
[JsonSerializable(typeof(nint))]
[JsonSerializable(typeof(nint[]))]
internal partial class JsonSourceGenerationContext : JsonSerializerContext
{
}

[JsonSourceGenerationOptions(
    WriteIndented = true,
    ReadCommentHandling = JsonCommentHandling.Skip,
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    Converters = [
        typeof(JsonCustomConverterFactory),
        typeof(JsonStringEnumConverter<TokenElevationType>),
        ])]
[JsonSerializable(typeof(Settings))]
[JsonSerializable(typeof(ShellBatInstanceSettings))]
[JsonSerializable(typeof(ShellBatChildWindow))]
[JsonSerializable(typeof(ShellBatChildWindow[]))]
internal partial class JsonSourceNoDefaultGenerationContext : JsonSerializerContext
{
}

[JsonSourceGenerationOptions(
    WriteIndented = true,
    ReadCommentHandling = JsonCommentHandling.Skip,
    IncludeFields = true,
    PropertyNameCaseInsensitive = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    Converters = [
        typeof(JsonCustomConverterFactory),
    ])]
[JsonSerializable(typeof(POINT))]
[JsonSerializable(typeof(RECT))]
[JsonSerializable(typeof(D2D_RECT_F))]
[JsonSerializable(typeof(WINDOWPLACEMENT))]
internal partial class JsonSourceStructGenerationContext : JsonSerializerContext
{
}

[JsonSourceGenerationOptions(
    WriteIndented = true,
    ReadCommentHandling = JsonCommentHandling.Skip,
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonKnownNamingPolicy.KebabCaseLower,
    Converters = [
        typeof(JsonCustomConverterFactory),
        ])]
[JsonSerializable(typeof(ShellBatTheme))]
internal partial class JsonSourceKebabGenerationContext : JsonSerializerContext
{
}
