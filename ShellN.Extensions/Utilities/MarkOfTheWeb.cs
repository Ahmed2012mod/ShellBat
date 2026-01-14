namespace ShellN.Extensions.Utilities;

// from https://devblogs.microsoft.com/oldnewthing/20131104-00/?p=2753
public static class MarkOfTheWeb
{
    public static Guid CLSID_PersistentZoneIdentifier { get; } = new("0968e258-16c7-4dba-aa86-462dd61e31a3");
    public static Guid CLSID_InternetSecurityManager { get; } = new("7b8a2d94-0ac9-11d1-896c-00c04fb6bfc4");

    private static void CheckPath(string filePath)
    {
        ArgumentNullException.ThrowIfNull(filePath);
        if (!Path.IsPathFullyQualified(filePath))
            throw new ArgumentException("The file path must be fully qualified.", nameof(filePath));
    }

    public static URLZONE MapUrlToZone(string filePath, bool throwOnError = true)
    {
        CheckPath(filePath);
        using var pzi = ComObject.CoCreate<IInternetSecurityManager>(CLSID_InternetSecurityManager, throwOnError: throwOnError);
        if (pzi != null)
        {
            var hr = pzi.Object.MapUrlToZone(PWSTR.From(filePath), out var zone, Constants.MUTZ_ISFILE | Constants.MUTZ_DONT_UNESCAPE | Constants.MUTZ_DONT_USE_CACHE).ThrowOnError(throwOnError);
            if (hr.IsSuccess)
                return (URLZONE)zone;
        }
        return URLZONE.URLZONE_INVALID;
    }

    public static URLZONE GetZone(string filePath, bool throwOnError = true)
    {
        CheckPath(filePath);
        using var pzi = ComObject.CoCreate<IZoneIdentifier>(CLSID_PersistentZoneIdentifier, throwOnError: throwOnError);
        if (pzi != null)
        {
            var pf = pzi.As<IPersistFile>(throwOnError: throwOnError);
            if (pf != null)
            {
                var hr = pf.Object.Load(PWSTR.From(filePath), STGM.STGM_READ);
                if (hr.IsSuccess)
                {
                    if (pzi.Object.GetId(out var zone).ThrowOnError(throwOnError).IsSuccess)
                        return (URLZONE)zone;
                }
                else if (hr == DirectN.Constants.ERROR_FILE_NOT_FOUND)
                    return URLZONE.URLZONE_LOCAL_MACHINE;

                hr.ThrowOnError(throwOnError);
            }
        }
        return URLZONE.URLZONE_INVALID;
    }

    public static void SetZone(string filePath, URLZONE zone, bool throwOnError = true)
    {
        CheckPath(filePath);
        using var pzi = ComObject.CoCreate<IZoneIdentifier>(CLSID_PersistentZoneIdentifier, throwOnError: throwOnError);
        if (pzi == null)
            return;

        var hr = pzi.Object.SetId((uint)zone).ThrowOnError(throwOnError);
        if (!hr.IsSuccess)
            return;

        var pf = pzi.As<IPersistFile>(throwOnError: throwOnError);
        if (pf == null)
            return;

        pf.Object.Save(PWSTR.From(filePath), true).ThrowOnError(throwOnError);
    }

    public static void RemoveZone(string filePath, bool throwOnError = true)
    {
        CheckPath(filePath);
        using var pzi = ComObject.CoCreate<IZoneIdentifier>(CLSID_PersistentZoneIdentifier, throwOnError: throwOnError);
        if (pzi == null)
            return;

        var hr = pzi.Object.Remove().ThrowOnError(throwOnError);
        if (!hr.IsSuccess)
            return;

        var pf = pzi.As<IPersistFile>(throwOnError: throwOnError);
        if (pf == null)
            return;

        pf.Object.Save(PWSTR.From(filePath), true).ThrowOnError(throwOnError);
    }
}
