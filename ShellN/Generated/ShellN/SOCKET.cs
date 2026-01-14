#nullable enable
namespace ShellN;

public partial struct SOCKET : IEquatable<SOCKET>, IValueGet<nuint>
{
    public static readonly SOCKET Null = new();
    
    public nuint Value;
    
    public SOCKET(nuint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SOCKET value && Equals(value);
    public readonly bool Equals(SOCKET other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SOCKET left, SOCKET right) => left.Equals(right);
    public static bool operator !=(SOCKET left, SOCKET right) => !left.Equals(right);
    public static implicit operator nuint(SOCKET value) => value.Value;
    public static implicit operator SOCKET(nuint value) => new(value);
    
    readonly nuint IValueGet<nuint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
