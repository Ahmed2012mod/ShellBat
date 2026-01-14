#nullable enable
namespace ShellN;

[InlineArray(InlineArraySystemChar_2.Length)]
public partial struct InlineArraySystemChar_2
{
    public const int Length = 2;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArraySystemChar_2>(str, this, Length);
    public static implicit operator InlineArraySystemChar_2(string? str) { var n = new InlineArraySystemChar_2(); n.CopyFrom(str); return n; }
}
