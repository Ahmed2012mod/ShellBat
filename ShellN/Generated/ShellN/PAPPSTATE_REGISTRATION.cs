#nullable enable
namespace ShellN;

public partial struct PAPPSTATE_REGISTRATION : IEquatable<PAPPSTATE_REGISTRATION>, IValueGet<nint>
{
    public static readonly PAPPSTATE_REGISTRATION Null = new();
    
    public nint Value;
    
    public PAPPSTATE_REGISTRATION(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is PAPPSTATE_REGISTRATION value && Equals(value);
    public readonly bool Equals(PAPPSTATE_REGISTRATION other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(PAPPSTATE_REGISTRATION left, PAPPSTATE_REGISTRATION right) => left.Equals(right);
    public static bool operator !=(PAPPSTATE_REGISTRATION left, PAPPSTATE_REGISTRATION right) => !left.Equals(right);
    public static implicit operator nint(PAPPSTATE_REGISTRATION value) => value.Value;
    public static implicit operator PAPPSTATE_REGISTRATION(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
