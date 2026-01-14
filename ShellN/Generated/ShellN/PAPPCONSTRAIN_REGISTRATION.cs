#nullable enable
namespace ShellN;

public partial struct PAPPCONSTRAIN_REGISTRATION : IEquatable<PAPPCONSTRAIN_REGISTRATION>, IValueGet<nint>
{
    public static readonly PAPPCONSTRAIN_REGISTRATION Null = new();
    
    public nint Value;
    
    public PAPPCONSTRAIN_REGISTRATION(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is PAPPCONSTRAIN_REGISTRATION value && Equals(value);
    public readonly bool Equals(PAPPCONSTRAIN_REGISTRATION other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(PAPPCONSTRAIN_REGISTRATION left, PAPPCONSTRAIN_REGISTRATION right) => left.Equals(right);
    public static bool operator !=(PAPPCONSTRAIN_REGISTRATION left, PAPPCONSTRAIN_REGISTRATION right) => !left.Equals(right);
    public static implicit operator nint(PAPPCONSTRAIN_REGISTRATION value) => value.Value;
    public static implicit operator PAPPCONSTRAIN_REGISTRATION(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
