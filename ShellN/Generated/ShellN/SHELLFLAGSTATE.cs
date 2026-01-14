#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-shellflagstate
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHELLFLAGSTATE : IEquatable<SHELLFLAGSTATE>, IValueGet<int>
{
    public static readonly SHELLFLAGSTATE Null = new();
    
    public int _bitfield;
    
    public SHELLFLAGSTATE(int value) => this._bitfield = value;
    public override readonly string ToString() => $"0x{_bitfield:x}";
    
    public override readonly bool Equals(object? obj) => obj is SHELLFLAGSTATE value && Equals(value);
    public readonly bool Equals(SHELLFLAGSTATE other) => other._bitfield == _bitfield;
    public override readonly int GetHashCode() => _bitfield.GetHashCode();
    public static bool operator ==(SHELLFLAGSTATE left, SHELLFLAGSTATE right) => left.Equals(right);
    public static bool operator !=(SHELLFLAGSTATE left, SHELLFLAGSTATE right) => !left.Equals(right);
    public static implicit operator int(SHELLFLAGSTATE value) => value._bitfield;
    public static implicit operator SHELLFLAGSTATE(int value) => new(value);
    
    readonly int IValueGet<int>.GetValue() => _bitfield;
    readonly object? IValueGet.GetValue() => _bitfield;
}
