#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/sspi/ns-sspi-secpkgcontext_bindings
public partial struct SecPkgContext_Bindings
{
    public uint BindingsLength;
    public nint Bindings;
}
