namespace ShellBat;

[Serializable]
public class ShellBatException : Exception
{
    public const string Prefix = "SBA";

    public ShellBatException()
        : base(Prefix + "0001: ShellBat exception.")
    {
    }

    public ShellBatException(string message)
        : base(Prefix + message)
    {
    }

    public ShellBatException(string message, Exception innerException)
        : base(Prefix + message, innerException)
    {
    }

    public ShellBatException(Exception innerException)
        : base(null, innerException)
    {
    }

    public static int GetCode(string message)
    {
        if (message == null)
            return -1;

        if (!message.StartsWith(Prefix, StringComparison.Ordinal))
            return -1;

        var pos = message.IndexOf(':', Prefix.Length);
        if (pos < 0)
            return -1;

        if (int.TryParse(message.AsSpan(Prefix.Length, pos - Prefix.Length), NumberStyles.None, CultureInfo.InvariantCulture, out var i))
            return i;

        return -1;
    }

    public int Code => GetCode(Message);
}
