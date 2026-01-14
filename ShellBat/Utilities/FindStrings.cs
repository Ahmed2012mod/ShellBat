namespace ShellBat.Utilities;

public static class FindStrings
{
    public static IEnumerable<FindStringsResult> FindWords(string filePath, int minLength = FindStringsOptions.DefaultMinLength, long memoryLimit = FindStringsOptions.DefaultMemoryLimit)
    {
        ArgumentNullException.ThrowIfNull(filePath);

        var useMemory = UseMemory(filePath, memoryLimit);
        return useMemory ? EnumWordsWithMemory(filePath, minLength) : EnumWordsWithFile(filePath, minLength);
    }

    public static IEnumerable<FindStringsResult> Search(string path, FindStringsOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(path);
        var att = IOUtilities.PathGetAttributes(path);
        if (att == null)
            return [];

        if (att.Value.HasFlag(FileAttributes.Directory))
            return SearchDirectory(path, options);

        return SearchFile(path, options);
    }

    public static IEnumerable<FindStringsResult> SearchDirectory(string directoryPath, FindStringsOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(directoryPath);
        options ??= new FindStringsOptions();
        options.Resolve();

        var skipEntryFunc = options.SkipEntryFunc ?? dontSkip;
        var searchPattern = options.SearchPattern.Nullify() ?? "*.*";
        foreach (var entry in Directory.EnumerateFileSystemEntries(directoryPath, searchPattern, new EnumerationOptions
        {
            IgnoreInaccessible = true,
            RecurseSubdirectories = options.IsRecursive,
        }))
        {
            if (options.PathSpec != null)
            {
                if (!IOUtilities.PathMatchSpec(entry, options.PathSpec))
                    continue;
            }

            if (options.NameSpec != null)
            {
                var name = Path.GetFileName(entry);
                if (!IOUtilities.PathMatchSpec(name, options.NameSpec))
                    continue;
            }

            if (skipEntryFunc(entry))
                continue;

            var isDirectory = IOUtilities.PathIsDirectory(entry);
            if (!isDirectory && options.InTextOnlyFiles)
            {
                var ext = FileExtension.GetByExtension(Path.GetExtension(entry));
                if (ext != null && !ext.IsText)
                    continue;
            }

            if (isDirectory)
            {
                foreach (var s in SearchDirectory(entry, options))
                {
                    yield return s;
                }
                continue;
            }

            foreach (var s in SearchFile(entry, options))
            {
                yield return s;
            }
        }

        static bool dontSkip(string filePath) => false;
    }

    public static IEnumerable<FindStringsResult> SearchFile(string filePath, FindStringsOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(filePath);

        options ??= new FindStringsOptions();
        options.Resolve();

        foreach (var result in FindWords(filePath, options.MinLength, options.MemoryLimit))
        {
            if (options._searchString == null)
            {
                result.Text = options.GetExtract(result.Text);
                yield return result;
            }
            else
            {
                if (options.Matches(result.Text))
                {
                    result.Text = options.GetExtract(result.Text);
                    yield return result;
                }
            }
        }
    }

    private static bool IsValid(byte b) => b > 31 && b < 128;
    private static bool UseMemory(string filePath, long memoryLimit)
    {
        var fi = new FileInfo(filePath);
        return fi.Exists && fi.Length < memoryLimit;
    }

    private static string? PushString(StringBuilder sb, char? firstChar, int minLength, out int length)
    {
        if (sb.Length >= minLength)
        {
            var s = firstChar.HasValue ? firstChar + sb.ToString() : sb.ToString();
            length = sb.Length;
            sb.Clear();
            return s;
        }

        sb.Clear();
        length = 0;
        return null;
    }

    private static IEnumerable<FindStringsResult> EnumWordsWithMemory(string filePath, int minLength)
    {
        byte[] bytes;
        try
        {
            bytes = File.ReadAllBytes(filePath);
        }
        catch (Exception e)
        {
            Application.TraceError($"Error opening '{filePath}': {e.GetAllMessagesWithDots()}");
            yield break;
        }

        var sb = new StringBuilder();
        var unicode = false;
        byte? start = null;
        byte prev = 0;
        byte prev2 = 0;
        string? str;
        long position = -1;
        foreach (var b in bytes)
        {
            position++;
            if (IsValid(b))
            {
                sb.Append((char)b);
            }
            else if (b == 0) // handle unicode & ansi simultaneously
            {
                if (!IsValid(prev))
                {
                    str = PushString(sb, unicode ? (char?)start : null, minLength, out var l);
                    if (str != null)
                        yield return new(filePath, position - l, str);

                    start = null;
                    unicode = false;
                }
                else if (IsValid(prev2))
                {
                    str = PushString(sb, unicode ? (char?)start : null, minLength, out var l);
                    if (str != null)
                        yield return new(filePath, position - l, str);

                    unicode = false;
                    start = prev;
                }
                else
                {
                    unicode = true;
                }
                // continue
            }
            else
            {
                str = PushString(sb, unicode ? (char?)start : null, minLength, out var l);
                if (str != null)
                    yield return new(filePath, position - l, str);

                start = null;
                unicode = false;
            }

            prev2 = prev;
            prev = b;
        }

        str = PushString(sb, unicode ? (char?)start : null, minLength, out var l2);
        if (str != null)
            yield return new(filePath, position - l2, str);
    }

    private static IEnumerable<FindStringsResult> EnumWordsWithFile(string filePath, int minLength)
    {
        FileStream stream;
        try
        {
            stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        }
        catch (Exception e)
        {
            Application.TraceError($"Error opening '{filePath}': {e.GetAllMessagesWithDots()}");
            yield break;
        }

        var sb = new StringBuilder();
        var unicode = false;
        byte? start = null;
        using (stream)
        {
            byte prev = 0;
            byte prev2 = 0;
            do
            {
                int i;
                try
                {
                    i = stream.ReadByte();
                }
                catch
                {
                    // continue;
                    i = -1;
                }

                if (i < 0)
                {
                    var s = PushString(sb, unicode ? (char?)start : null, minLength, out var l);
                    if (s != null)
                        yield return new(filePath, stream.Position - l, s);

                    break;
                }

                var b = (byte)i;
                if (IsValid(b))
                {
                    sb.Append((char)b);
                }
                else if (b == 0) // handle unicode & ansi simultaneously
                {
                    if (!IsValid(prev))
                    {
                        var s = PushString(sb, unicode ? (char?)start : null, minLength, out var l);
                        if (s != null)
                            yield return new(filePath, stream.Position - l, s);

                        start = null;
                        unicode = false;
                    }
                    else if (IsValid(prev2))
                    {
                        var s = PushString(sb, unicode ? (char?)start : null, minLength, out var l);
                        if (s != null)
                            yield return new(filePath, stream.Position - l, s);

                        unicode = false;
                        start = prev;
                    }
                    else
                    {
                        unicode = true;
                    }
                    // continue
                }
                else
                {
                    var s = PushString(sb, unicode ? (char?)start : null, minLength, out var l);
                    if (s != null)
                        yield return new(filePath, stream.Position - l, s);

                    start = null;
                    unicode = false;
                }

                prev2 = prev;
                prev = b;
            }
            while (true);
        }
    }
}
