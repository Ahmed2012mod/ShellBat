namespace ShellBat.Utilities;

public class LocalizedDisplayNameAttribute(string resourceKey) :
    DisplayNameAttribute(Res.ResourceManager.GetString(resourceKey).Nullify() ?? resourceKey)
{
}
