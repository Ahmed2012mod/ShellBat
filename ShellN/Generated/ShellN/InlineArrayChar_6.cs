#nullable enable
namespace ShellN;

[InlineArray(InlineArrayChar_6.Length)]
public partial struct InlineArrayChar_6
{
    public const int Length = 6;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_6>(str, this, Length);
    public static implicit operator InlineArrayChar_6(string? str) { var n = new InlineArrayChar_6(); n.CopyFrom(str); return n; }
}
