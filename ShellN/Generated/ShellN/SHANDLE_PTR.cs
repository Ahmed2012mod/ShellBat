#nullable enable
namespace ShellN;

public partial struct SHANDLE_PTR : IEquatable<SHANDLE_PTR>, IValueGet<nint>
{
    public static readonly SHANDLE_PTR Null = new();
    
    public nint Value;
    
    public SHANDLE_PTR(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SHANDLE_PTR value && Equals(value);
    public readonly bool Equals(SHANDLE_PTR other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SHANDLE_PTR left, SHANDLE_PTR right) => left.Equals(right);
    public static bool operator !=(SHANDLE_PTR left, SHANDLE_PTR right) => !left.Equals(right);
    public static implicit operator nint(SHANDLE_PTR value) => value.Value;
    public static implicit operator SHANDLE_PTR(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
