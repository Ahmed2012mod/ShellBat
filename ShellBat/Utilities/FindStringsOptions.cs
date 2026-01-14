namespace ShellBat.Utilities;

public class FindStringsOptions : IParsable<FindStringsOptions>
{
    public const long DefaultMemoryLimit = 1_000_000_000;
    public const int DefaultMinLength = 3;
    public const int DefaultMaxLength = 40;
    public static StringComparison DefaultStringComparison { get; } = StringComparison.OrdinalIgnoreCase;

    public virtual string? Search { get; set; }
    public virtual long MemoryLimit { get; set; } = DefaultMemoryLimit;
    public virtual int MinLength { get; set; } = DefaultMinLength;
    public virtual int MaxLength { get; set; } = DefaultMaxLength;
    public virtual StringComparison StringComparison { get; set; } = DefaultStringComparison;
    public virtual bool IsRegex { get; set; }
    public virtual string? SearchPattern { get; set; }
    public virtual bool IsRecursive { get; set; }
    public virtual bool InTextOnlyFiles { get; set; }
    public virtual string? NameSpec { get; set; }
    public virtual string? PathSpec { get; set; }
    public virtual Func<string, bool>? SkipEntryFunc { get; set; }

    public override string ToString()
    {
        var dic = new Dictionary<string, string?>();
        if (Search != null)
        {
            dic[nameof(Search)] = Search;
        }

        if (MemoryLimit != DefaultMemoryLimit)
        {
            dic[nameof(MemoryLimit)] = MemoryLimit.ToString(CultureInfo.InvariantCulture);
        }

        if (MinLength != DefaultMinLength)
        {
            dic[nameof(MinLength)] = MinLength.ToString(CultureInfo.InvariantCulture);
        }

        if (MaxLength != DefaultMaxLength)
        {
            dic[nameof(MaxLength)] = MaxLength.ToString(CultureInfo.InvariantCulture);
        }

        if (StringComparison != StringComparison.OrdinalIgnoreCase)
        {
            dic[nameof(StringComparison)] = StringComparison.ToString();
        }

        if (SearchPattern != null)
        {
            dic[nameof(SearchPattern)] = SearchPattern;
        }

        if (NameSpec != null)
        {
            dic[nameof(NameSpec)] = NameSpec;
        }

        if (PathSpec != null)
        {
            dic[nameof(PathSpec)] = PathSpec;
        }

        if (IsRegex)
        {
            dic[nameof(IsRegex)] = IsRegex.ToString();
        }

        if (IsRecursive)
        {
            dic[nameof(IsRecursive)] = IsRecursive.ToString();
        }

        if (InTextOnlyFiles)
        {
            dic[nameof(InTextOnlyFiles)] = InTextOnlyFiles.ToString();
        }

        return DictionarySerializer<string>.Serialize(dic)!;
    }

    public static FindStringsOptions Parse(string s, IFormatProvider? provider) { if (!TryParse(s, provider, out var result)) throw new FormatException(); return result; }
    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out FindStringsOptions result)
    {
        result = new FindStringsOptions();
        if (string.IsNullOrEmpty(s))
            return true;

        var dic = DictionarySerializer<string>.Deserialize(s);
        result.Search = dic.GetNullifiedString(nameof(Search));
        result.MemoryLimit = dic.GetValue(nameof(MemoryLimit), CultureInfo.InvariantCulture, DefaultMemoryLimit);
        result.MinLength = dic.GetValue(nameof(MinLength), CultureInfo.InvariantCulture, DefaultMinLength);
        result.MaxLength = dic.GetValue(nameof(MaxLength), CultureInfo.InvariantCulture, DefaultMaxLength);
        result.StringComparison = dic.GetValue(nameof(StringComparison), CultureInfo.InvariantCulture, DefaultStringComparison);
        result.IsRegex = dic.GetValue<bool>(nameof(IsRegex));
        result.SearchPattern = dic.GetNullifiedString(nameof(SearchPattern));
        result.IsRecursive = dic.GetValue<bool>(nameof(IsRecursive));
        result.InTextOnlyFiles = dic.GetValue<bool>(nameof(InTextOnlyFiles));
        result.NameSpec = dic.GetNullifiedString(nameof(NameSpec));
        result.PathSpec = dic.GetNullifiedString(nameof(PathSpec));
        return true;
    }

    internal string? _searchString;
    private RegexOptions _regexOptions;
    private Regex? _regex;
    private bool _resolved;
    private FindStringsSearchCommand _searchCommand;

    internal void Resolve()
    {
        if (_resolved)
            return;

        if (string.IsNullOrWhiteSpace(Search))
        {
            _searchString = null; // search for all strings
        }
        else
        {
            if (IsRegex)
            {
                _searchString = Search;
            }
            else
            {
                if (Search.IndexOf('*') < 0)
                {
                    Search = '*' + Search + '*';
                }

                _searchString = Search;
                var pos = _searchString.IndexOf('*');
                if (pos < 0)
                {
                    _searchString = Search;
                    _searchCommand = FindStringsSearchCommand.Equals;
                }
                else if (pos == 0)
                {
                    _searchString = Search[1..];
                    if (_searchString.Length == 0) // *
                    {
                        _searchString = null;
                    }
                    else if (_searchString[^1] == '*')
                    {
                        _searchString = _searchString[..^1];
                        if (_searchString.Length == 0) // **
                        {
                            _searchString = null;
                        }
                        else // *search*
                        {
                            _searchCommand = FindStringsSearchCommand.Contains;
                        }
                    }
                    else // *search
                    {
                        _searchCommand = FindStringsSearchCommand.EndsWith;
                    }
                }
                else if (pos == _searchString.Length - 1)
                {
                    _searchString = Search[..(_searchString.Length - 1)];
                    if (_searchString.Length == 0)
                    {
                        _searchString = null;
                    }
                    else
                    {
                        _searchCommand = FindStringsSearchCommand.StartsWith;
                    }
                }
            }
        }

        _searchString = NormalizeString(_searchString);
        if (IsRegex)
        {
            if (_searchString == null)
                throw new ShellBatException($"0014: Search string cannot be empty when using regex.");

            _regex = new Regex(_searchString, _regexOptions);
        }
        else
        {
            _regexOptions = RegexOptions.None;
        }
        _resolved = true;
    }

    private static string SafeSubstring(string s, int startIndex, int length) => s.Substring(startIndex, Math.Min(length, s.Length - startIndex));
    internal string GetExtract(string s)
    {
        if (s.Length <= MaxLength)
            return s;

        if (_searchString == null)
            return SafeSubstring(s, 0, MaxLength);

        var pos = s.IndexOf(_searchString, StringComparison);
        if (pos < 0)
            return SafeSubstring(s, 0, MaxLength);

        return SafeSubstring(s, pos, MaxLength);
    }

    internal bool Matches(string s)
    {
        if (_regex != null)
            return _regex.IsMatch(s);

        return _searchCommand switch
        {
            FindStringsSearchCommand.Contains => s.Contains(_searchString!, StringComparison),
            FindStringsSearchCommand.StartsWith => s.StartsWith(_searchString!, StringComparison),
            FindStringsSearchCommand.EndsWith => s.EndsWith(_searchString!, StringComparison),
            FindStringsSearchCommand.Equals => string.Compare(s, _searchString, StringComparison) == 0,
            _ => throw new NotSupportedException(),
        };
    }

    private static string? NormalizeString(string? str)
    {
        if (str == null)
            return null;

        var sb = new StringBuilder(str.Length);
        for (var i = 0; i < str.Length; i++)
        {
            if (IsUnicode(str, i, out char unicode))
            {
                sb.Append(unicode);
                i += 5;
            }
            else
            {
                sb.Append(str[i]);
            }
        }
        return sb.ToString();
    }

    // format is \uXXXX
    private static bool IsUnicode(string s, int offset, out char c)
    {
        c = '\0';
        if ((offset + 6) > s.Length)
            return false;

        if (s[offset] != '\\')
            return false;

        if (s[offset + 1] != 'u' && s[offset + 1] != 'U')
            return false;

        var unicode = s.Substring(offset + 2, 4);
        if (!ushort.TryParse(unicode, NumberStyles.HexNumber, null, out ushort us))
            return false;

        c = (char)us;
        return true;
    }
}
