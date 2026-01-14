namespace ShellBat.Terminals;

public partial class PseudoConsole(HPCON handle) : IDisposable
{
    private nint _handle = handle;

    public bool IsDisposed => _handle == 0;
    public HPCON Handle { get { var handle = _handle; ObjectDisposedException.ThrowIf(handle == 0, this); return _handle; } }

    public virtual void Release() => Interop.Functions.ReleasePseudoConsole(Handle).ThrowOnError();
    public virtual void Resize(short width, short height) => Interop.Functions.ResizePseudoConsole(Handle, new Interop.COORD { X = width, Y = height }).ThrowOnError();
    public override string ToString() => Handle.ToString();

    ~PseudoConsole() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            var handle = Interlocked.Exchange(ref _handle, 0);
            if (handle != 0)
            {
                Interop.Functions.ClosePseudoConsole(handle);
            }
        }
    }

    public static PseudoConsole Create(HANDLE readPipe, HANDLE writePipe, short width, short height)
    {
        Interop.Functions.CreatePseudoConsole(new Interop.COORD { X = width, Y = height }, readPipe, writePipe, 0, out var hPC).ThrowOnError();
        return new PseudoConsole(hPC);
    }
}
