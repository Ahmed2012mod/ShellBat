#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propidlbase/ns-propidlbase-statpropstg
public partial struct STATPROPSTG
{
    public PWSTR lpwstrName;
    public uint propid;
    public VARENUM vt;
}
