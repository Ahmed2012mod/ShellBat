namespace ShellBat.Terminals;

public partial class Terminal : IDisposable
{
    private bool _disposedValue;
    private Stream? _readStream;
    private Stream? _writeStream;
    private readonly Pipe _input = new();
    private readonly Pipe _output = new();

    public event EventHandler? OutputReady;
    public event EventHandler? ProcessExited;
    public Exception? ProcessStartError { get; private set; }

    public Terminal(short consoleWidth = 80, short consoleHeight = 30)
    {
        Console = PseudoConsole.Create(_input.Read, _output.Write, consoleWidth, consoleHeight);
    }

    // cf https://docs.microsoft.com/en-us/windows/console/creating-a-pseudoconsole-session#creating-the-pseudoconsole
    public virtual NativeProcess? Start(string commandline, string? currentDirectory, bool monitorProcessExit = true, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(commandline);
        Process = NativeProcess.Start(commandline, currentDirectory, (nint)Interop.Constants.PROC_THREAD_ATTRIBUTE_PSEUDOCONSOLE, Console.Handle, out var error, throwOnError);
        if (Process == null)
        {
            ProcessStartError = error;
            return null;
        }

        if (monitorProcessExit)
        {
            var waitHandle = Process.GetWaitForExitEvent();
            ThreadPool.RegisterWaitForSingleObject(waitHandle, (state, timedOut) =>
            {
                OnProcessExited(this, EventArgs.Empty);
                waitHandle.SafeDispose();
            }, null, -1, executeOnlyOnce: true);
        }

        _readStream = new FileStream(new SafeFileHandle(_output.Read, false), FileAccess.Read);
        _writeStream = new FileStream(new SafeFileHandle(_input.Write, false), FileAccess.Write);

        OnOutputReady(this, EventArgs.Empty);
        return Process;
    }

    public PseudoConsole Console { get; }
    public NativeProcess? Process { get; private set; }
    public Stream? ReadStream => _readStream;
    public Stream? WriteStream => _writeStream;
    public string? WorkingDirectory => ProcessUtilities.GetCurrentDirectory(Process?.ProcessId ?? 0, false);
    public bool IsDisposed => _disposedValue;

    protected virtual void OnOutputReady(object? sender, EventArgs e) => OutputReady?.Invoke(sender, e);
    protected virtual void OnProcessExited(object? sender, EventArgs e) => ProcessExited?.Invoke(sender, e);

    ~Terminal() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            var disposed = Interlocked.Exchange(ref _disposedValue, true);
            if (!disposed)
            {
                Process?.Dispose();
                Console.Dispose();

                Interlocked.Exchange(ref _readStream, Stream.Null)?.Dispose();
                Interlocked.Exchange(ref _writeStream, Stream.Null)?.Dispose();

                _input.Dispose();
                _output.Dispose();
            }
        }
    }
}
