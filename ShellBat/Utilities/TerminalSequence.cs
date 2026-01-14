namespace ShellBat.Utilities;

public class TerminalSequence(Range range, TerminalSequenceCode code)
{
    public Range Range { get; } = range;
    public TerminalSequenceCode Code { get; } = code;
    public int Length => Range.End.Value - Range.Start.Value;

    public override string ToString() => $"{Code} [{Range.Start.Value},{Range.End.Value}]";

    public virtual void Write(ReadOnlySpan<byte> data, Stream stream)
    {
        ArgumentNullException.ThrowIfNull(stream);
        var bytes = data[Range];
        stream.WriteByte(0x1B);
        stream.Write(bytes);
    }
}

public class RawSequence(Range range)
    : TerminalSequence(range, TerminalSequenceCode.RAW)
{
    public override void Write(ReadOnlySpan<byte> data, Stream stream)
    {
        ArgumentNullException.ThrowIfNull(stream);
        var bytes = data[Range];
        stream.Write(bytes);
    }
}

public class UnsupportedSequence(Range range)
    : TerminalSequence(range, TerminalSequenceCode.UNSUPPORTED)
{
}

public class OscSequence(Range range, short number, string value, byte terminal)
    : TerminalSequence(range, TerminalSequenceCode.CUSTOM_OSC)
{
    public virtual short Number { get; set; } = number;
    public virtual string Value { get; set; } = value;
    public virtual byte Terminal { get; set; } = terminal; // 0x07 or 0x1B

    public override string ToString() => $"OSC {Code} '{Value}' [{Range.Start.Value},{Range.End.Value}]";

    public override void Write(ReadOnlySpan<byte> data, Stream stream)
    {
        ArgumentNullException.ThrowIfNull(stream);
        stream.WriteByte(0x1B);
        stream.WriteByte((byte)']');
        stream.Write(Encoding.ASCII.GetBytes(Number.ToString()));
        stream.WriteByte((byte)';');
        stream.Write(Encoding.UTF8.GetBytes(Value));
        stream.WriteByte(Terminal);
        if (Terminal == 0x1B)
        {
            stream.WriteByte((byte)'\\');
        }
    }
}

public class NumbersSequence(Range range, TerminalSequenceCode code, IList<short> numbers)
    : TerminalSequence(range, code)
{
    public IList<short> Numbers { get; } = numbers;

    public override string ToString() => $"NUMBERS {Code} ({string.Join("; ", Numbers)}) [{Range.Start.Value},{Range.End.Value}]";

    public override void Write(ReadOnlySpan<byte> data, Stream stream)
    {
        ArgumentNullException.ThrowIfNull(stream);
        switch (Code)
        {
            case TerminalSequenceCode.CUU:
            case TerminalSequenceCode.CUD:
            case TerminalSequenceCode.CUF:
            case TerminalSequenceCode.CUB:
            case TerminalSequenceCode.CNL:
            case TerminalSequenceCode.CPL:
            case TerminalSequenceCode.CHA:
            case TerminalSequenceCode.VPA:
            case TerminalSequenceCode.SU:
            case TerminalSequenceCode.SD:
            case TerminalSequenceCode.ICH:
            case TerminalSequenceCode.DCH:
            case TerminalSequenceCode.ECH:
            case TerminalSequenceCode.IL:
            case TerminalSequenceCode.DL:
            case TerminalSequenceCode.ED:
            case TerminalSequenceCode.EL:
            case TerminalSequenceCode.SGR:
            case TerminalSequenceCode.CHT:
            case TerminalSequenceCode.CBT:
            case TerminalSequenceCode.CUP:
            case TerminalSequenceCode.HVP:
            case TerminalSequenceCode.DECSTBM:
                stream.WriteByte(0x1B);
                var lastChar = data[Range.End.Value - 1];
                stream.WriteByte((byte)'[');
                for (var i = 0; i < Numbers.Count; i++)
                {
                    if (i > 0)
                    {
                        stream.WriteByte((byte)';');
                    }
                    stream.Write(Encoding.ASCII.GetBytes(Numbers[i].ToString()));
                }
                stream.WriteByte(lastChar);
                return;

            case TerminalSequenceCode.DECSET:
            case TerminalSequenceCode.DECRST:
                stream.WriteByte(0x1B);
                stream.WriteByte((byte)'[');
                stream.WriteByte((byte)'?');
                for (var i = 0; i < Numbers.Count; i++)
                {
                    if (i > 0)
                    {
                        stream.WriteByte((byte)';');
                    }
                    stream.Write(Encoding.ASCII.GetBytes(Numbers[i].ToString()));
                }
                stream.WriteByte(Code == TerminalSequenceCode.DECSET ? (byte)'h' : (byte)'l');
                return;

            case TerminalSequenceCode.DECSCUSR:
                if (Numbers.Count != 1)
                    throw new InvalidOperationException();

                if (Numbers[0] < 1 || Numbers[0] > 6)
                    throw new InvalidOperationException();

                stream.WriteByte(0x1B);
                stream.WriteByte((byte)'[');
                stream.Write(Encoding.ASCII.GetBytes(Numbers[0].ToString()));
                stream.WriteByte((byte)' ');
                stream.WriteByte((byte)'q');
                return;

            case TerminalSequenceCode.ANSISYSSC:
            case TerminalSequenceCode.ANSISYSRC:
            case TerminalSequenceCode.DECSTR:
            case TerminalSequenceCode.DECXCPR:
            case TerminalSequenceCode.DA:
            case TerminalSequenceCode.TBC_CURRENT:
            case TerminalSequenceCode.TBC_ALL:
                base.Write(data, stream);
                return;
        }

        throw new NotSupportedException($"Writing sequence code {Code} is not supported.");
    }
}
