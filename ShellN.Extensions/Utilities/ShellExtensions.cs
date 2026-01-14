namespace ShellN.Extensions.Utilities;

public static class ShellExtensions
{
    public static int GetSize(this SHIL shil) => shil switch
    {
        SHIL.SHIL_SMALL => 16,
        SHIL.SHIL_LARGE => 32,
        SHIL.SHIL_EXTRALARGE => 48,
        SHIL.SHIL_SYSSMALL => DirectN.Functions.GetSystemMetrics(SYSTEM_METRICS_INDEX.SM_CXSMICON),
        SHIL.SHIL_JUMBO => 256,
        _ => 16,
    };

    public static T? MakeUnique<T>(string name, Func<string, (T? Value, MakeUniqueResult Result)> tentativeFunc)
    {
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(tentativeFunc);

        var index = 1;
        var tentativeName = name;
        do
        {
            var (value, result) = tentativeFunc(tentativeName);
            if (result == MakeUniqueResult.Success)
                return value;

            if (result == MakeUniqueResult.Error)
                return default;

            index++;
            tentativeName = $"{name} ({index})";
        }
        while (true);
    }

    public static T? MakeUniqueWithExtension<T>(string nameWithExtension, Func<string, (T? Value, MakeUniqueResult Result)> tentativeFunc)
    {
        ArgumentNullException.ThrowIfNull(nameWithExtension);
        ArgumentNullException.ThrowIfNull(tentativeFunc);

        var index = 1;
        var nameWithoutExtension = Path.GetFileNameWithoutExtension(nameWithExtension);
        var ext = Path.GetExtension(nameWithExtension);

        var tentativeName = nameWithExtension;
        do
        {
            var (value, result) = tentativeFunc(tentativeName);
            if (result == MakeUniqueResult.Success)
                return value;

            if (result == MakeUniqueResult.Error)
                return default;

            index++;
            tentativeName = $"{nameWithoutExtension} ({index}){ext}";
        }
        while (true);
    }

    public static HRESULT SetPreferredDropEffect(this IDataObject dataObject, DROPEFFECT effect) =>
        dataObject.Set(Clipboard.RegisterFormat(Constants.CFSTR_PREFERREDDROPEFFECT), effect);

    public static DROPEFFECT GetPreferredDropEffect(this IDataObject? dataObject, DROPEFFECT defaultValue) =>
        dataObject.Get(Clipboard.RegisterFormat(Constants.CFSTR_PREFERREDDROPEFFECT), defaultValue);

    public static HRESULT SetPerformedDropEffect(this IDataObject dataObject, DROPEFFECT effect) =>
        dataObject.Set(Clipboard.RegisterFormat(Constants.CFSTR_PERFORMEDDROPEFFECT), effect);

    public static DROPEFFECT GetPerformedDropEffect(this IDataObject? dataObject, DROPEFFECT defaultValue) =>
        dataObject.Get(Clipboard.RegisterFormat(Constants.CFSTR_PERFORMEDDROPEFFECT), defaultValue);

    public static HRESULT SetPasteSucceededEffect(this IDataObject dataObject, DROPEFFECT effect) =>
        dataObject.Set(Clipboard.RegisterFormat(Constants.CFSTR_PASTESUCCEEDED), effect);

    public static DROPEFFECT GetPasteSucceededEffect(this IDataObject? dataObject, DROPEFFECT defaultValue) =>
        dataObject.Get(Clipboard.RegisterFormat(Constants.CFSTR_PASTESUCCEEDED), defaultValue);

    public static unsafe IReadOnlyList<FILEDESCRIPTORW> GetFileDescriptors(this IDataObject? dataObject)
    {
        if (dataObject.TryGet(Clipboard.RegisterFormat(Constants.CFSTR_FILEDESCRIPTORW), out byte[]? bytes).IsError)
            return [];

        fixed (byte* pBytes = bytes)
        {
            var groupDescriptor = (FILEGROUPDESCRIPTORW*)pBytes;
            var count = (int)groupDescriptor->cItems;
            var list = new FILEDESCRIPTORW[count];
            var descriptors = (FILEDESCRIPTORW*)(&groupDescriptor->fgd);
            for (var i = 0; i < count; i++)
            {
                list[i] = descriptors[i];
            }
            return list;
        }
    }
}
