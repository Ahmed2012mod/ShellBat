namespace ShellBat.Utilities;

public class LocalizedDescriptionNameAttribute(string resourceKey) :
    DescriptionAttribute(Res.ResourceManager.GetString(resourceKey).Nullify() ?? resourceKey)
{
}
