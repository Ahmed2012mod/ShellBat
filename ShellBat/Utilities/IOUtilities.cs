namespace ShellBat.Utilities;

public static class IOUtilities
{
    public static bool IsPathRooted(string path)
    {
        if (path == null)
            return false;

        var length = path.Length;
        if (length < 1 || path[0] != Path.DirectorySeparatorChar && path[0] != Path.AltDirectorySeparatorChar)
            return length >= 2 && path[1] == Path.VolumeSeparatorChar;

        return true;
    }

    public static bool PathIsDrive(string? path)
    {
        if (path == null)
            return false;

        return path.Length == 3 && char.IsLetter(path[0]) && path[1] == Path.VolumeSeparatorChar && path[2] == Path.DirectorySeparatorChar;
    }

    public static char GetDrive(string? path)
    {
        if (path != null && path.Length >= 2 && char.IsLetter(path[0]) && path[1] == Path.VolumeSeparatorChar)
            return char.ToUpperInvariant(path[0]);

        return '\0';
    }

    public static string? PathRemoveExtension(string? path, string? extension)
    {
        if (string.IsNullOrWhiteSpace(path))
            return path;

        if (string.IsNullOrWhiteSpace(extension))
            return path;

        if (path.EndsWith(extension, StringComparison.OrdinalIgnoreCase))
            return path[..^extension.Length];

        return path;
    }

    public static bool PathMatchSpec(string path, string pattern)
    {
        ArgumentNullException.ThrowIfNull(pattern);
        ArgumentNullException.ThrowIfNull(pattern);
        if (pattern == "." || pattern == "*.*" || pattern == "*")
            return true;

        return ShellN.Functions.PathMatchSpecW(PWSTR.From(path), PWSTR.From(pattern));
    }

    public static bool PathIsEqual(string path1, string path2, bool normalize = true)
    {
        ArgumentNullException.ThrowIfNull(path1);
        ArgumentNullException.ThrowIfNull(path2);
        if (normalize)
        {
            path1 = Path.GetFullPath(path1);
            path2 = Path.GetFullPath(path2);
        }

        return path1.EqualsIgnoreCase(path2);
    }

    public static bool FileOverwrite(string source, string destination, bool unprotect = true, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(destination);
        if (PathIsEqual(source, destination))
            return false;

        if (!throwOnError && !PathIsFile(source))
            return false;

        if (!FileEnsureDirectory(destination, throwOnError))
            return false;

        if (unprotect)
        {
            // we delete the target only if we can write to its directory
            if (DirectoryCheckCanWrite(Path.GetDirectoryName(destination)!))
            {
                FileDelete(destination, unprotect, throwOnError);
            }
        }

        if (throwOnError)
        {
            File.Copy(source, destination, true);
        }
        else
        {
            try
            {
                File.Copy(source, destination, true);
            }
            catch
            {
                return false;
            }
        }
        return true;
    }

    public static bool DirectoryCheckCanWrite(string directoryPath)
    {
        ArgumentNullException.ThrowIfNull(directoryPath);
        if (!PathIsDirectory(directoryPath))
            return false;

        var guid = "temp" + Guid.NewGuid().ToString("N") + ".txt";
        var path = Path.Combine(directoryPath, guid);
        try
        {
            File.WriteAllText(path, "You can safely delete this file");
        }
        catch
        {
            return false;
        }

        FileDelete(path, false, false);
        return true;
    }

    public static void DirectoryDelete(string path, bool recursive, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(path);
        if (!PathIsDirectory(path))
            return;

        if (throwOnError)
        {
            Directory.Delete(path, recursive);
            return;
        }

        try
        {
            Directory.Delete(path, recursive);
        }
        catch
        {
            // do nothing
        }
    }

    public static void DirectoryDeleteFiles(string path, bool recurseSubdirectories = false, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(path);
        if (!PathIsDirectory(path))
            return;

        foreach (var file in Directory.EnumerateFiles(path, "*.*", new EnumerationOptions
        {
            IgnoreInaccessible = true,
            RecurseSubdirectories = recurseSubdirectories,
        }))
        {
            FileDelete(file, true, throwOnError);
        }
    }

    public static void DirectoryDeleteEmptySubDirectories(string path, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(path);
        if (!PathIsDirectory(path))
            return;

        do
        {
            var hasDeletedAny = false;
            foreach (var directory in Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories))
            {
                if (DirectoryIsEmpty(directory) == true)
                {
                    DirectoryDelete(directory, throwOnError);
                    hasDeletedAny = true;
                }
            }
            if (!hasDeletedAny)
                break;
        }
        while (true);
    }

    public static bool FileDelete(string path, bool unprotect = true, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(path);
        if (!PathIsFile(path))
            return false;

        if (throwOnError)
        {
            delete();
        }
        else
        {
            try
            {
                delete();
            }
            catch
            {
                return false;
            }
        }
        return true;

        void delete()
        {
            var attributes = File.GetAttributes(path);
            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly && unprotect)
            {
                File.SetAttributes(path, attributes & ~FileAttributes.ReadOnly);
            }

            File.Delete(path);
        }
    }

    public unsafe static FileAttributes? PathGetAttributes(string path)
    {
        ArgumentNullException.ThrowIfNull(path);
        var data = new WIN32_FILE_ATTRIBUTE_DATA();
        if (!DirectN.Functions.GetFileAttributesExW(PWSTR.From(path), GET_FILEEX_INFO_LEVELS.GetFileExInfoStandard, (nint)(&data)))
            return null;

        return (FileAttributes)data.dwFileAttributes;
    }

    public static bool PathExists(string path) => PathGetAttributes(path).HasValue;
    public static bool PathIsFile(string path)
    {
        var atts = PathGetAttributes(path);
        if (!atts.HasValue)
            return false;

        return !atts.Value.HasFlag(FileAttributes.Directory);
    }

    public static bool PathIsDirectory(string path)
    {
        var atts = PathGetAttributes(path);
        if (!atts.HasValue)
            return false;

        return atts.Value.HasFlag(FileAttributes.Directory);
    }

    public static bool? DirectoryIsEmpty(string path)
    {
        if (!PathIsDirectory(path))
            return null;

        return !Directory.EnumerateFileSystemEntries(path).Any();
    }

    public static bool FileEnsureDirectory(string path, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(path);
        if (!IsPathRooted(path))
        {
            path = Path.GetFullPath(path);
        }

        var dir = Path.GetDirectoryName(path);
        if (dir == null)
            return false;

        if (PathIsDirectory(dir))
            return true;

        try
        {
            Directory.CreateDirectory(dir);
            return true;
        }
        catch
        {
            if (throwOnError)
                throw;

            return false;
        }
    }

    public static long FileGetSize(string path, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(path);
        if (PathIsFile(path))
        {
            if (throwOnError)
                return new FileInfo(path).Length;

            try
            {
                return new FileInfo(path).Length;
            }
            catch
            {
                // continue
            }
        }
        return -1;
    }

    public static RegistryKey EnsureSubKey(this RegistryKey root, string name)
    {
        ArgumentNullException.ThrowIfNull(root);
        ArgumentNullException.ThrowIfNull(name);
        var key = root.OpenSubKey(name, true);
        if (key != null)
            return key;

        var parentName = Path.GetDirectoryName(name);
        if (string.IsNullOrEmpty(parentName))
            return root.CreateSubKey(name);

        using var parentKey = EnsureSubKey(root, parentName);
        return parentKey.CreateSubKey(Path.GetFileName(name));
    }

    public static string? NameToValidFileName(string fileName, char escapePrefix = '♦')
    {
        ArgumentNullException.ThrowIfNull(fileName);

        var invalid = Path.GetInvalidFileNameChars();
        var sb = new StringBuilder(fileName.Length);
        foreach (var c in fileName)
        {
            if (Array.IndexOf(invalid, c) < 0)
            {
                sb.Append(c);
            }
            else
            {
                sb.Append($"{escapePrefix}{(int)c:X4}");
            }
        }

        var s = sb.ToString();
        if (s.Length >= 255)
        {
            s = s[..254];
        }

        s = s.Nullify();
        if (s == null)
            return null;

        if (s.All(c => c == '.'))
            return null;

        if (_reservedFileNames.Contains(s))
            return escapePrefix + string.Join(null, s.Select(c => $"{(int)c:X4}"));

        return s.Nullify();
    }

    public static HRESULT EjectVirtualDisk(string path, HWND hwnd, out bool isVirtual)
    {
        isVirtual = false;
        ArgumentNullException.ThrowIfNull(path);
        if (path.Length < 2)
            throw new ArgumentException(null, nameof(path));

        path = path[..2];
        var handle = ShellN.Functions.CreateFileW(
            PWSTR.From(path),
            (uint)FILE_ACCESS_RIGHTS.FILE_READ_ATTRIBUTES,
            FILE_SHARE_MODE.FILE_SHARE_READ | FILE_SHARE_MODE.FILE_SHARE_WRITE,
            0,
            FILE_CREATION_DISPOSITION.OPEN_EXISTING,
            FILE_FLAGS_AND_ATTRIBUTES.FILE_ATTRIBUTE_NORMAL | FILE_FLAGS_AND_ATTRIBUTES.FILE_FLAG_BACKUP_SEMANTICS,
            0);
        if (handle == HANDLE.InvalidValue)
            return Marshal.GetLastPInvokeError();

        try
        {
            return ShellN.Functions.SHELL32_TryVirtualDiscImageDriveEject(handle, hwnd, out isVirtual);
        }
        finally
        {
            DirectN.Functions.CloseHandle(handle);
        }
    }

    public static bool IsVirtualDevice(string path)
    {
        ArgumentNullException.ThrowIfNull(path);
        if (path.Length < 2)
            throw new ArgumentException(null, nameof(path));

        path = path[..2];
        var handle = ShellN.Functions.CreateFileW(
            PWSTR.From(path),
            (uint)FILE_ACCESS_RIGHTS.FILE_READ_ATTRIBUTES,
            FILE_SHARE_MODE.FILE_SHARE_READ | FILE_SHARE_MODE.FILE_SHARE_WRITE,
            0,
            FILE_CREATION_DISPOSITION.OPEN_EXISTING,
            FILE_FLAGS_AND_ATTRIBUTES.FILE_ATTRIBUTE_NORMAL | FILE_FLAGS_AND_ATTRIBUTES.FILE_FLAG_BACKUP_SEMANTICS,
            0);
        if (handle == HANDLE.InvalidValue)
            return false;

        try
        {
            return ShellN.Functions.SHELL32_SHIsVirtualDevice(handle);
        }
        finally
        {
            DirectN.Functions.CloseHandle(handle);
        }
    }

    public static unsafe string? GetVirtualDiskImagePath(string path, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(path);
        if (path.Length < 2)
            throw new ArgumentException(null, nameof(path));

        path = path[..2];
        var handle = ShellN.Functions.CreateFileW(
            PWSTR.From(path),
            (uint)FILE_ACCESS_RIGHTS.FILE_READ_ATTRIBUTES,
            FILE_SHARE_MODE.FILE_SHARE_READ | FILE_SHARE_MODE.FILE_SHARE_WRITE,
            0,
            FILE_CREATION_DISPOSITION.OPEN_EXISTING,
            FILE_FLAGS_AND_ATTRIBUTES.FILE_ATTRIBUTE_NORMAL | FILE_FLAGS_AND_ATTRIBUTES.FILE_FLAG_BACKUP_SEMANTICS,
            0);
        if (handle == HANDLE.InvalidValue)
        {
            if (throwOnError)
                throw new Win32Exception(Marshal.GetLastPInvokeError());

            return null;
        }

        try
        {
            var size = (uint)sizeof(STORAGE_DEPENDENCY_INFO);
            var dummy = stackalloc byte[(int)size];
            ((STORAGE_DEPENDENCY_INFO*)dummy)->Version = STORAGE_DEPENDENCY_INFO_VERSION.STORAGE_DEPENDENCY_INFO_VERSION_2;
            var ret = ShellN.Functions.GetStorageDependencyInformation(
                handle,
                GET_STORAGE_DEPENDENCY_FLAG.GET_STORAGE_DEPENDENCY_FLAG_HOST_VOLUMES,
                size,
                ref Unsafe.AsRef<STORAGE_DEPENDENCY_INFO>(dummy),
                (nint)(&size));
            if (ret != WIN32_ERROR.ERROR_INSUFFICIENT_BUFFER)
            {
                if (throwOnError)
                    throw new Win32Exception((int)ret);

                return null;
            }

            var buffer = Marshal.AllocHGlobal((int)size);
            var info = (STORAGE_DEPENDENCY_INFO*)buffer;
            try
            {
                info->Version = STORAGE_DEPENDENCY_INFO_VERSION.STORAGE_DEPENDENCY_INFO_VERSION_2;
                ret = ShellN.Functions.GetStorageDependencyInformation(
                    handle,
                    GET_STORAGE_DEPENDENCY_FLAG.GET_STORAGE_DEPENDENCY_FLAG_HOST_VOLUMES,
                    size,
                    ref Unsafe.AsRef<STORAGE_DEPENDENCY_INFO>(info),
                    (nint)(&size));
                if (ret != WIN32_ERROR.ERROR_SUCCESS)
                {
                    if (throwOnError)
                        throw new Win32Exception((int)ret);

                    return null;
                }

                for (var i = 0; i < info->NumberEntries; i++)
                {
                    var entry = info->Anonymous.Version2Entries[i];

                    var hostVolumeName = entry.HostVolumeName.ToString();
                    if (hostVolumeName == null)
                        continue;

                    var dependentVolumeRelativePath = entry.DependentVolumeRelativePath.ToString();
                    if (dependentVolumeRelativePath == null)
                        continue;

                    if (dependentVolumeRelativePath.StartsWith('\\'))
                    {
                        dependentVolumeRelativePath = dependentVolumeRelativePath[1..];
                    }

                    var imagePath = Path.Combine(hostVolumeName, dependentVolumeRelativePath);
                    var imageHandle = ShellN.Functions.CreateFileW(
                        PWSTR.From(imagePath),
                        (uint)FILE_ACCESS_RIGHTS.FILE_READ_ATTRIBUTES,
                        FILE_SHARE_MODE.FILE_SHARE_READ | FILE_SHARE_MODE.FILE_SHARE_WRITE,
                        0,
                        FILE_CREATION_DISPOSITION.OPEN_EXISTING,
                        FILE_FLAGS_AND_ATTRIBUTES.FILE_ATTRIBUTE_NORMAL,
                        0);
                    if (imageHandle == HANDLE.InvalidValue)
                    {
                        if (throwOnError)
                            throw new Win32Exception(Marshal.GetLastPInvokeError());

                        return null;
                    }

                    try
                    {
                        var pathSize = ShellN.Functions.GetFinalPathNameByHandleW(imageHandle, PWSTR.Null, 0, GETFINALPATHNAMEBYHANDLE_FLAGS.VOLUME_NAME_DOS);
                        if (pathSize == 0)
                        {
                            if (throwOnError)
                                throw new Win32Exception(Marshal.GetLastPInvokeError());

                            return null;
                        }

                        var pathBuffer = Marshal.AllocHGlobal((int)(pathSize * 2));
                        try
                        {
                            var resultSize = ShellN.Functions.GetFinalPathNameByHandleW(imageHandle, new PWSTR(pathBuffer), pathSize, GETFINALPATHNAMEBYHANDLE_FLAGS.VOLUME_NAME_DOS);
                            if (resultSize == 0 || resultSize >= pathSize)
                            {
                                if (throwOnError)
                                    throw new Win32Exception(Marshal.GetLastPInvokeError());

                                return null;
                            }

                            var diskPath = Marshal.PtrToStringUni(pathBuffer, (int)resultSize);
                            if (diskPath != null &&
                                diskPath.Length > 5 &&
                                diskPath.StartsWith(@"\\?\") &&
                                char.IsAsciiLetter(diskPath[4]) &&
                                diskPath[5] == ':')
                            {
                                diskPath = diskPath[4..];
                            }
                            return diskPath;
                        }
                        finally
                        {
                            Marshal.FreeHGlobal(pathBuffer);
                        }
                    }
                    finally
                    {
                        DirectN.Functions.CloseHandle(imageHandle);
                    }
                }
                return null;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }
        finally
        {
            DirectN.Functions.CloseHandle(handle);
        }
    }

    private static readonly HashSet<string> _reservedFileNames = new(StringComparer.OrdinalIgnoreCase){
        "con",
        "prn",
        "aux",
        "nul",
        "com0",
        "com1",
        "com2",
        "com3",
        "com4",
        "com5",
        "com6",
        "com7",
        "com8",
        "com9",
        "lpt0",
        "lpt1",
        "lpt2",
        "lpt3",
        "lpt4",
        "lpt5",
        "lpt6",
        "lpt7",
        "lpt8",
        "lpt9"
    };
}
