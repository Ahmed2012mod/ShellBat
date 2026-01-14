namespace ShellBat.Resources;

public static class MonacoResources
{
    private static Task? _task;
    private static readonly Lock _lock = new();

    public static Task EnsureFilesAsync(bool forceRefresh = false)
    {
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
        var startTok = typeof(MonacoResources).Namespace + ".vs.";
        const string ext = ".zip";
        var zip = asm.GetManifestResourceNames().FirstOrDefault(n => n.StartsWith(startTok) && n.EndsWith(ext)) ?? throw new InvalidOperationException();
        var version = zip.Substring(startTok.Length, zip.Length - startTok.Length - ext.Length);

        // we check the last known file is there
        var someFile = Path.Combine(Settings.MonacoPath, @"vs\language\typescript\monaco.contribution.js");
        var fi = new FileInfo(someFile);
        if (!forceRefresh && fi.Exists && fi.Length > 0)
        {
            _task = null;
            return;
        }

        using var stream = asm.GetManifestResourceStream(zip) ?? throw new InvalidOperationException();
        using var archive = new ZipArchive(stream, ZipArchiveMode.Read);
        archive.ExtractToDirectory(Settings.MonacoPath, true);
        _task = null;
    }
}
