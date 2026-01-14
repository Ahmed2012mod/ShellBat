namespace ShellBat.Resources;

public static class WebRootResources
{
    private static Task? _task;
    private static bool _done;
    private static readonly Lock _lock = new();

    public static Task EnsureFilesAsync(bool forceRefresh = false)
    {
        if (_done)
            return Task.CompletedTask;

        if (_task != null)
            return _task;

        lock (_lock)
        {
            _task ??= Task.Run(() => EnsureFiles(forceRefresh));
            return _task;
        }
    }

    private static void EnsureFiles(bool forceRefresh = false)
    {
        var asm = Assembly.GetExecutingAssembly();
        var startTok = @"WebRoot\";
        var files = asm.GetManifestResourceNames().Where(n => n.StartsWith(startTok)).Order().ToArray();
        var lastFile = files.Last();

        if (!forceRefresh)
        {
            var path = Path.Combine(Settings.WebRootPath, lastFile[startTok.Length..]);
            if (IOUtilities.FileGetSize(path) > 0)
            {
                //Application.TraceVerbose("WebRoot resources already exist, skipping extraction");
                _task = null;
                return;
            }
        }

        IOUtilities.DirectoryDelete(Path.GetDirectoryName(Settings.WebRootPath)!, true, false);
        foreach (var name in files)
        {
            using var stream = asm.GetManifestResourceStream(name) ?? throw new InvalidOperationException();
            var path = Path.Combine(Settings.WebRootPath, name[startTok.Length..]);
            IOUtilities.FileEnsureDirectory(path);
            using var fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            stream.CopyTo(fs);
            lastFile = path;
        }

        _done = true;
        _task = null;
    }
}
