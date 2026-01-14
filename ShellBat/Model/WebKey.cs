namespace ShellBat.Model;

public readonly struct WebKey(string? name) : IEquatable<WebKey>
{
    public WebKeyCode KeyCode { get; } = Enum.TryParse<WebKeyCode>(name, true, out var code) ? code : WebKeyCode.Unidentified;
    public WebVirtualKeyCode VirtualKeyCode { get; } = Parse(name);
    public VIRTUAL_KEY VirtualKey => (VIRTUAL_KEY)VirtualKeyCode;

    public override bool Equals([NotNullWhen(true)] object? obj) => obj is WebKey other && Equals(other);
    public bool Equals(WebKey other) => KeyCode == other.KeyCode && VirtualKeyCode == other.VirtualKeyCode;
    public override int GetHashCode() => HashCode.Combine(KeyCode, VirtualKeyCode);
    public override string ToString() => $"KC={KeyCode}, VK={VirtualKeyCode})";
    public static bool operator ==(WebKey left, WebKey right) => left.Equals(right);
    public static bool operator !=(WebKey left, WebKey right) => !(left == right);

    private static WebVirtualKeyCode Parse(string? name)
    {
        if (name == null)
            return WebVirtualKeyCode.Unidentified;

        if (name.Length == 1)
        {
            if (char.IsAsciiDigit(name[0]))
                return (WebVirtualKeyCode)(name[0] - '0' + (int)WebVirtualKeyCode.Digit0);

            if (name[0] == ' ')
                return WebVirtualKeyCode.Space;

            return WebVirtualKeyCode.Unidentified; // no other single-character string is mapped
        }

        if (Enum.TryParse<WebVirtualKeyCode>(name, true, out var code))
            return code;

        return WebVirtualKeyCode.Unidentified;
    }
}
