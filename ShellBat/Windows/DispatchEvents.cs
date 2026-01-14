namespace ShellBat.Windows;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class DispatchEvents : DirectN.IDispatch, IDisposable
{
    public event EventHandler<DispatchEventArgs>? Event;

    private uint _cookie;
    private IComObject<DirectN.IConnectionPoint>? _connectionPoint;

    public DispatchEvents(Guid interfaceId, object connectionPointContainer)
    {
        InterfaceId = interfaceId;
        SetConnectionPointContainer(connectionPointContainer);
    }

    public Guid InterfaceId { get; }

    protected virtual void SetConnectionPointContainer(object connectionPointContainer)
    {
        ArgumentNullException.ThrowIfNull(connectionPointContainer);

        var cpc = ComObject.Unwrap<IConnectionPointContainer>(connectionPointContainer) ?? throw new ArgumentException(null, nameof(connectionPointContainer));
        cpc.FindConnectionPoint(InterfaceId, out var connectionPoint);
        if (connectionPoint == null)
            throw new InvalidOperationException("Failed to find connection point for interface " + InterfaceId);

        _connectionPoint = new ComObject<DirectN.IConnectionPoint>(connectionPoint);
        ComObject.WithComInstance(this, unk => _connectionPoint.Object.Advise(unk, out _cookie).ThrowOnError(), createIfNeeded: true);
    }

    protected virtual void OnEvent(object sender, DispatchEventArgs e) => Event?.Invoke(sender, e);
    protected virtual unsafe object?[] BuildArguments(in DISPPARAMS parameters)
    {
        var varArgs = (VARIANT*)parameters.rgvarg;
        var args = new object?[parameters.cArgs];
        for (var i = 0; i < parameters.cArgs; i++)
        {
            object? value;
            // note arguments are stored in in reverse order
            var varArgsIndex = parameters.cArgs - i - 1;
            if (varArgsIndex < 0 || varArgsIndex >= parameters.cArgs)
            {
                value = null;
            }
            else
            {
                value = Variant.Unwrap(varArgs[varArgsIndex]);
            }

            args[i] = value;
        }
        return [.. args];
    }

    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            var cp = Interlocked.Exchange(ref _connectionPoint, null);
            if (cp != null)
            {
                var cookie = Interlocked.Exchange(ref _cookie, 0);
                if (cookie != 0)
                {
                    cp.Object.Unadvise(cookie); // don't check errors
                }
            }
        }
    }

    protected unsafe virtual HRESULT Invoke(int dispIdMember, in Guid riid, uint lcid, DISPATCH_FLAGS wFlags, in DISPPARAMS pDispParams, nint pVarResult, nint pExcepInfo, nint puArgErr)
    {
        try
        {
            var e = new DispatchEventArgs(dispIdMember, wFlags, BuildArguments(in pDispParams));
            OnEvent(this, e);
            if (pVarResult != 0)
            {
                using var va = new Variant(e.Result);
                va.DetachTo(pVarResult);
            }
            return DirectN.Constants.S_OK;
        }
        catch (Exception ex)
        {
            Application.TraceError($" Exception: {ex}");
            if (pExcepInfo != 0)
            {
                var excepInfo = new EXCEPINFO
                {
                    bstrSource = new(Marshal.StringToBSTR(GetType().FullName)),
                    scode = ex.HResult,
                    bstrDescription = new(Marshal.StringToBSTR(ex.ToString())),
                };

                *(EXCEPINFO*)pExcepInfo = excepInfo;
            }
            return DirectN.Constants.E_FAIL;
        }
    }

    HRESULT DirectN.IDispatch.Invoke(int dispIdMember, in Guid riid, uint lcid, DISPATCH_FLAGS wFlags, in DISPPARAMS pDispParams, nint pVarResult, nint pExcepInfo, nint puArgErr)
        => Invoke(dispIdMember, in riid, lcid, wFlags, in pDispParams, pVarResult, pExcepInfo, puArgErr);
    HRESULT DirectN.IDispatch.GetIDsOfNames(in Guid riid, PWSTR[] rgszNames, uint cNames, uint lcid, int[] rgDispId) => throw new NotImplementedException();
    HRESULT DirectN.IDispatch.GetTypeInfo(uint iTInfo, uint lcid, out ITypeInfo ppTInfo) => throw new NotImplementedException();
    HRESULT DirectN.IDispatch.GetTypeInfoCount(out uint pctinfo) => throw new NotImplementedException();
}
