#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/SecCrypto/hcryptprov-legacy
public partial struct HCRYPTPROV_LEGACY : IEquatable<HCRYPTPROV_LEGACY>, IValueGet<nuint>
{
    public static readonly HCRYPTPROV_LEGACY Null = new();
    
    public nuint Value;
    
    public HCRYPTPROV_LEGACY(nuint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HCRYPTPROV_LEGACY value && Equals(value);
    public readonly bool Equals(HCRYPTPROV_LEGACY other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) => left.Equals(right);
    public static bool operator !=(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) => !left.Equals(right);
    public static implicit operator nuint(HCRYPTPROV_LEGACY value) => value.Value;
    public static implicit operator HCRYPTPROV_LEGACY(nuint value) => new(value);
    
    readonly nuint IValueGet<nuint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
