#nullable enable
namespace ShellN;

public partial struct HPSXA : IEquatable<HPSXA>, IValueGet<nint>
{
    public static readonly HPSXA Null = new();
    
    public nint Value;
    
    public HPSXA(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HPSXA value && Equals(value);
    public readonly bool Equals(HPSXA other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HPSXA left, HPSXA right) => left.Equals(right);
    public static bool operator !=(HPSXA left, HPSXA right) => !left.Equals(right);
    public static implicit operator nint(HPSXA value) => value.Value;
    public static implicit operator HPSXA(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
