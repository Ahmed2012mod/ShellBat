namespace ShellBat.Monaco;

public class LanguageExtensionAlias(string extension, string languageId, bool force)
{
    public string Extension { get; } = extension;
    public string LanguageId { get; } = languageId;
    public bool Force { get; } = force;

    public override string ToString() => $"{Extension} => {LanguageId} (Force={Force})";
}
