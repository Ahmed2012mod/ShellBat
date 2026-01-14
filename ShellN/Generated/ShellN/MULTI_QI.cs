#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/ns-objidlbase-multi_qi
public partial struct MULTI_QI
{
    public nint pIID;
    public nint pItf;
    public HRESULT hr;
}
