namespace ShellBat.Utilities;

public class TerminalWriter
{
    public virtual IList<TerminalSequence> Sequences { get; } = [];

    public void Load(ReadOnlySpan<byte> data)
    {
        var reader = new TerminalReader(data);
        Load(reader);
    }

    public virtual void Load(TerminalReader reader)
    {
        do
        {
            var sequence = reader.Read();
            if (sequence == null)
                break;

            Sequences.Add(sequence);
        }
        while (true);
    }

    public virtual byte[] Rebuild(ReadOnlySpan<byte> data)
    {
        var ms = new MemoryStream();
        foreach (var sequence in Sequences)
        {
            sequence.Write(data, ms);
        }
        return ms.ToArray();
    }
}
