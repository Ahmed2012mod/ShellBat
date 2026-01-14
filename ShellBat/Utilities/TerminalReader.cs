namespace ShellBat.Utilities;

public ref struct TerminalReader(ReadOnlySpan<byte> data)
{
    public readonly ReadOnlySpan<byte> Data { get; } = data;
    public int Position { get; private set; }

    public TerminalSequence? Read()
    {
        if (Data.Length == 0 || Position >= Data.Length)
            return null;

        TerminalSequence seq;
        var escPos = Data[Position..].IndexOf((byte)0x1B);
        if (escPos < 0)
        {
            seq = new RawSequence(new Range(Position, Data.Length));
            Position = Data.Length;
        }
        else
        {
            if (escPos > 0)
            {
                seq = new RawSequence(new Range(Position, Position + escPos));
                Position += escPos;
                return seq;
            }
            seq = GetSequence(Data, Position + escPos + 1);
            Position += escPos + 1 + seq.Length;
        }
        return seq;
    }

    private static TerminalSequence GetSequence(ReadOnlySpan<byte> data, int start)
    {
        var length = data.Length - start;
        switch (data[start])
        {
            case (byte)'[':
                return getCsiSequence(data, start);

            case (byte)']':
                return getOscSequence(data, start);

            case (byte)'M': // ESC M
                return new TerminalSequence(new Range(start, start + 1), TerminalSequenceCode.RI);

            case (byte)'7': // ESC 7
                return new TerminalSequence(new Range(start, start + 1), TerminalSequenceCode.DECSC);

            case (byte)'8': // ESC 8
                return new TerminalSequence(new Range(start, start + 1), TerminalSequenceCode.DECSR);

            case (byte)'=': // ESC =
                return new TerminalSequence(new Range(start, start + 1), TerminalSequenceCode.DECKPAM);

            case (byte)'>': // ESC >
                return new TerminalSequence(new Range(start, start + 1), TerminalSequenceCode.DECKPNM);

            case (byte)'H': // ESC H
                return new TerminalSequence(new Range(start, start + 1), TerminalSequenceCode.HTS);

            case (byte)'(':
                if (length >= 2)
                {
                    if (data[start + 1] == '0') // ESC ( 0
                        return new TerminalSequence(new Range(start, start + 2), TerminalSequenceCode.DCS_DEC);

                    if (data[start + 1] == 'B') // ESC ( B
                        return new TerminalSequence(new Range(start, start + 2), TerminalSequenceCode.DCS_ASCII);
                }
                break;
        }

        return new UnsupportedSequence(new Range(start, data.Length));

        static TerminalSequence getOscSequence(ReadOnlySpan<byte> data, int start)
        {
            var offset = 1;
            var number = parseNumber(data[(start + offset)..], out var numberEnd);
            if (number != null && data.Length > numberEnd && data[start + offset + numberEnd] == ';')
            {
                var endPos = data[(start + offset + numberEnd + 1)..].IndexOfAny((byte)0x07, (byte)0x1B);
                if (endPos >= 0)
                {
                    var terminal = data[start + offset + numberEnd + 1 + endPos];
                    var end = terminal == 0x1B ? 2 : 1; // if ESC, we need to account for the LF after it
                    var text = Encoding.UTF8.GetString(data[(start + offset + numberEnd + 1)..(start + offset + numberEnd + endPos + 1)]);
                    var range = new Range(start, start + offset + numberEnd + endPos + 1 + end);
                    return new OscSequence(range, number.Value, text, terminal);
                }
            }
            return new UnsupportedSequence(new Range(start, data.Length));
        }

        static TerminalSequence getCsiSequence(ReadOnlySpan<byte> data, int start)
        {
            if (data.Length == start)
                return new UnsupportedSequence(new Range(start, data.Length));

            if (data[start + 1] == 's') // ESC [ s
                return new TerminalSequence(new Range(start, start + 2), TerminalSequenceCode.ANSISYSSC);

            if (data[start + 1] == 'u') // ESC [ u
                return new TerminalSequence(new Range(start, start + 2), TerminalSequenceCode.ANSISYSRC);

            if (data.Length > start + 2)
            {
                switch (data[start + 1])
                {
                    case (byte)'!': // ESC [ ! p
                        if (data[start + 2] == 'p')
                            return new TerminalSequence(new Range(start, start + 3), TerminalSequenceCode.DECSTR);
                        break;

                    case (byte)'6': // ESC [ 6 n
                        if (data[start + 2] == 'n')
                            return new TerminalSequence(new Range(start, start + 3), TerminalSequenceCode.DECXCPR);
                        break;

                    case (byte)'0':
                        switch (data[start + 2])
                        {
                            case (byte)'c': // ESC [ 0 c
                                return new TerminalSequence(new Range(start, start + 3), TerminalSequenceCode.DA);

                            case (byte)'g': // ESC [ 0 g
                                return new TerminalSequence(new Range(start, start + 3), TerminalSequenceCode.TBC_CURRENT);
                        }
                        break;

                    case (byte)'3': // ESC [ 3 g
                        if (data[start + 2] == 'g')
                            return new TerminalSequence(new Range(start, start + 3), TerminalSequenceCode.TBC_ALL);
                        break;

                }

                if (data.Length > start + 3)
                {
                    var num = data[start + 1];
                    if (num >= '0' && num <= '6' && data[start + 2] == ' ' && data[start + 3] == 'q') // ESC [ 0 SP q => ESC [ 6 SP q
                        return new NumbersSequence(new Range(start, start + 4), TerminalSequenceCode.DECSCUSR, [(short)(num - '0')]);
                }
            }

            // read any number of numbers separated by ';'
            var numbers = new List<short>();
            var offset = data[start + 1] == '?' ? 2 : 1;
            do
            {
                var number = parseNumber(data[(start + offset)..], out var size);
                if (number != null)
                {
                    numbers.Add(number.Value);
                    offset += size;
                }

                if (data.Length > start + offset && data[start + offset] == ';')
                {
                    offset += 1; // for ';'
                }
                else
                    break;
            }
            while (true);

            var nextByte = data[start + offset];
            var rangeEnd = start + offset + 1;

            if (data[start + 1] == '?')
            {
                if (nextByte == 'h')
                    return new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.DECSET, numbers);

                if (nextByte == 'l')
                    return new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.DECRST, numbers);

                return new UnsupportedSequence(new Range(start, data.Length));
            }

            // note we don't validate the correct number of parameters here (can vary a lot)
            return nextByte switch
            {
                (byte)'A' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.CUU, numbers), // ESC [ <n> A
                (byte)'B' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.CUD, numbers), // ESC [ <n> B
                (byte)'C' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.CUF, numbers), // ESC [ <n> C
                (byte)'D' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.CUB, numbers), // ESC [ <n> D
                (byte)'E' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.CNL, numbers), // ESC [ <n> E
                (byte)'F' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.CPL, numbers), // ESC [ <n> F
                (byte)'G' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.CHA, numbers), // ESC [ <n> G
                (byte)'d' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.VPA, numbers), // ESC [ <n> d
                (byte)'S' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.SU, numbers), // ESC [ <n> S
                (byte)'T' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.SD, numbers), // ESC [ <n> T  
                (byte)'@' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.ICH, numbers), // ESC [ <n> @ 
                (byte)'P' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.DCH, numbers), // ESC [ <n> P
                (byte)'X' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.ECH, numbers), // ESC [ <n> X
                (byte)'L' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.IL, numbers), // ESC [ <n> L
                (byte)'M' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.DL, numbers), // ESC [ <n> M
                (byte)'J' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.ED, numbers), // ESC [ <n> J 
                (byte)'K' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.EL, numbers), // ESC [ <n> K
                (byte)'m' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.SGR, numbers), // ESC [ <n> m
                (byte)'I' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.CHT, numbers), // ESC [ <n> I
                (byte)'Z' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.CBT, numbers), // ESC [ <n> Z
                (byte)'H' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.CUP, numbers), // ESC [ <y> ; <x> H
                (byte)'f' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.HVP, numbers), // ESC [ <y> ; <x> f
                (byte)'r' => new NumbersSequence(new Range(start, rangeEnd), TerminalSequenceCode.DECSTBM, numbers), // ESC [ <t> ; <b> r
                _ => new UnsupportedSequence(new Range(start, data.Length))
            };
        }

        static bool isDigit(byte b) => b >= (byte)'0' && b <= (byte)'9';
        static short? parseNumber(ReadOnlySpan<byte> span, out int end)
        {
            end = 0;
            if (span.Length == 0 || !isDigit(span[0]))
                return null;

            var result = 0;
            for (var i = 0; i < span.Length; i++)
            {
                var b = span[i];
                if (!isDigit(b))
                {
                    end = i;
                    break;
                }

                result = (short)(result * 10 + (b - (byte)'0'));
            }

            if (result < 0 || result > short.MaxValue)
                return null;

            return (short)result;
        }
    }
}
