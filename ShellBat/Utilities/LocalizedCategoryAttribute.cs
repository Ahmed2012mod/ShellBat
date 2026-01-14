namespace ShellBat.Utilities;

public class LocalizedCategoryAttribute(string resourceKey) :
    CategoryAttribute(Res.ResourceManager.GetString(resourceKey).Nullify() ?? resourceKey)
{
}
