namespace ShellBat.Utilities.GitHub;

public partial class GitHubRelease : IComparable<GitHubRelease>, IComparable
{
    [GeneratedRegex(@"\d+(\.\d+)+", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant)]
    private static partial Regex _versionRegex();
    private static readonly Regex _version = _versionRegex();

    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Body { get; set; }
    public bool? Draft { get; set; }
    public bool? PreRelease { get; set; }

    [JsonPropertyName("published_at")]
    public DateTime PublishedAt { get; set; }

    public IReadOnlyList<GitHubAsset> Assets { get; set; } = new List<GitHubAsset>().AsReadOnly();

    [JsonIgnore]
    public Version Version
    {
        get
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                try
                {
                    var m = _version.Match(Name);
                    if (m.Success)
                        return Version.Parse(m.Value);
                }
                catch
                {
                    // continue
                }
            }
            return new Version(1, 0);
        }
    }

    public override string ToString() => Id + " " + Version + " " + Name + " " + Body;
    int IComparable.CompareTo(object? obj) => CompareTo(obj as GitHubRelease);
    public int CompareTo(GitHubRelease? other)
    {
        ArgumentNullException.ThrowIfNull(other);
        return Version.CompareTo(other.Version);
    }
}
