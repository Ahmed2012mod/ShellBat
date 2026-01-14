namespace ShellBat.Terminals;

public sealed partial class Pipe : IDisposable
{
    private nint _read;
    private nint _write;

    public Pipe()
    {
        if (!Interop.Functions.CreatePipe(out var read, out var write, 0, 0))
            Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());

        _read = read;
        _write = write;
    }

    public HANDLE Read { get { ObjectDisposedException.ThrowIf(IsDisposed, this); return _read; } }
    public HANDLE Write { get { ObjectDisposedException.ThrowIf(IsDisposed, this); return _write; } }
    public bool IsDisposed => _read == 0 || _write == 0;

    ~Pipe() { Dispose(); }
    public void Dispose()
    {
        // closing a pipe can hang (race condition, doesn't seem to happen on W11), so we use a timeout
        var read = Interlocked.Exchange(ref _read, 0);
        if (read != 0)
        {
            TaskUtilities.RunWithAbort(() => DirectN.Functions.CloseHandle(read), 200);
        }

        var write = Interlocked.Exchange(ref _write, 0);
        if (write != 0)
        {
            TaskUtilities.RunWithAbort(() => DirectN.Functions.CloseHandle(write), 200);
        }
        GC.SuppressFinalize(this);
    }
}
