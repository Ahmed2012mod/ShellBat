namespace ShellN;

public static partial class Constants
{
    public static readonly Guid CLSID_ArchiveFolder = new("0c1fd748-b888-443d-9ec3-ad7e22d48808");
    public static readonly Guid CLSID_ZipFolder = new("e88dcce0-b7b3-11d1-a9f0-00aa0060fa31");
    public static readonly Guid CLSID_Applications = new("4234d49b-0245-4df3-b780-3893943456e1"); // shell:appsFolder
    public static readonly Guid CLSID_RecycleBinManager = new("4a04656d-52aa-49de-8a09-cb178760e748");
    public static readonly Guid DBGUID_DEFAULT = new("c8b521fb-5cf3-11ce-ade5-00aa0044773d");

    public const string ShellAppsFolder = "shell:appsFolder";
}
