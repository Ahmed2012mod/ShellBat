namespace ShellBat;

public partial class ShellBatRemoteInstance : InterlockedComObject<IOleCommandTarget>, IEquatable<ShellBatRemoteInstance>, IShellBatInstance
{
    private readonly Lazy<Uri?> _httpServerUrl;
    private readonly Dispatch _dispatch;
    private uint _eventsCookie;

    public event EventHandler<ShellBatRemoteInstanceEventArgs>? RemoteInstanceEvent;

    public ShellBatRemoteInstance(string name, int processId, IComObject<IOleCommandTarget>? comObject)
        : base(comObject)
    {
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(comObject);
        Name = name;
        if (IOUtilities.NameToValidFileName(Name) != Name)
            throw new ShellBatException($"0011: Remote instance name '{Name}' is invalid.");

        _httpServerUrl = new Lazy<Uri?>(() => GetHttpServerUrl(null));
        ProcessId = processId;
        _dispatch = new Dispatch(this);
    }

    public string Name { get; }
    public int ProcessId { get; }
    public ShellBatInstanceOptions Options { get; protected set; }
    public Uri? HttpServerUrl => _httpServerUrl.Value;
    public string? CurrentParsingName => GetCurrentParsingName();

    public override int GetHashCode() => ProcessId;
    public override bool Equals(object? obj) => Equals(obj as ShellBatRemoteInstance);
    public bool Equals(ShellBatRemoteInstance? other) => other?.ProcessId == ProcessId;

    public override string ToString()
    {
        var str = $"{Name}/{ProcessId}";
        try
        {
            var pn = Process.GetProcessById(ProcessId)?.ProcessName;
            if (!string.IsNullOrWhiteSpace(pn))
            {
                str += " (" + pn + ")";
            }
            return str;
        }
        catch
        {
            // process has probably exited
        }
        return str;
    }

    public virtual Uri? GetHttpServerUrl(Guid? desktopId = null)
    {
        var result = Send(desktopId, ShellBatInstanceCommandId.HttpServerUrl).FirstOrDefault();
        if (result == null)
            return null;

        if (result != null &&
            result.HResult == DirectN.Constants.S_OK &&
            result.Output is string url &&
            Uri.TryCreate(url, UriKind.Absolute, out var uri))
            return uri;

        return null;
    }

    public virtual Uri? GetConnectedToHttpServerUrl(Guid? desktopId = null)
    {
        var result = Send(desktopId, ShellBatInstanceCommandId.ConnectedToHttpServerUrl).FirstOrDefault();
        if (result == null)
            return null;

        if (result != null &&
            result.HResult == DirectN.Constants.S_OK &&
            result.Output is string url &&
            Uri.TryCreate(url, UriKind.Absolute, out var uri))
            return uri;

        return null;
    }

    public virtual RECT? GetMainWindowRect(Guid? desktopId = null)
    {
        var result = Send(desktopId, ShellBatInstanceCommandId.GetMainWindowRect).FirstOrDefault();
        if (result == null ||
            result.HResult.IsError ||
            result.Output is not string str ||
            !RECT.TryParse(str, null, out var rect) ||
            rect.Width <= 0 ||
            rect.Height <= 0)
            return null;

        return rect;
    }

    public virtual string? GetCurrentParsingName(Guid? desktopId = null)
    {
        var result = Send(desktopId, ShellBatInstanceCommandId.GetCurrentParsingName).FirstOrDefault();
        if (result == null || result.HResult.IsError)
            return null;

        return result.Output as string;
    }

    public virtual void UpdateOptions(Guid? desktopId = null)
    {
        var options = GetOptions(desktopId);
        if (options != null)
        {
            Options = options.Value;
        }
    }

    public virtual ShellBatInstanceOptions? GetOptions(Guid? desktopId = null)
    {
        var result = Send(desktopId, ShellBatInstanceCommandId.GetOptions).FirstOrDefault();
        if (result == null || result.HResult.IsError)
            return null;

        if (Conversions.TryChangeType<ShellBatInstanceOptions>(result.Output, out var options))
            return options;

        return null;
    }

    public virtual HRESULT SetWindowRect(RECT rect, Guid? desktopId = null)
    {
        var result = Send(desktopId, ShellBatInstanceCommandId.SetMainWindowRect, rect.ToString()).FirstOrDefault();
        return result?.HResult ?? DirectN.Constants.E_FAIL;
    }

    public virtual HRESULT SwitchTo(Guid? desktopId = null)
    {
        var result = Send(desktopId, ShellBatInstanceCommandId.SwitchTo).FirstOrDefault();
        return result?.HResult ?? DirectN.Constants.E_FAIL;
    }

    public virtual HRESULT ShowProperties(string parsingName, Guid? desktopId = null)
    {
        ArgumentNullException.ThrowIfNull(parsingName);
        var result = Send(desktopId, ShellBatInstanceCommandId.ShowProperties, parsingName).FirstOrDefault();
        return result?.HResult ?? DirectN.Constants.E_FAIL;
    }

    public virtual HRESULT ContinueShowProperties(string parsingName, Guid? desktopId = null)
    {
        ArgumentNullException.ThrowIfNull(parsingName);
        var result = Send(desktopId, ShellBatInstanceCommandId.ContinueShowProperties, parsingName).FirstOrDefault();
        return result?.HResult ?? DirectN.Constants.E_FAIL;
    }

    public virtual string? Update(string authId, Guid? desktopId = null)
    {
        ArgumentException.ThrowIfNullOrEmpty(authId);
        var result = Send(desktopId, ShellBatInstanceCommandId.Update, authId).FirstOrDefault();
        if (result == null || result.HResult.IsError)
            return null;

        return result.Output as string;
    }

    // IEnumerables here *must* be drained to fully complete the command execution
    public IEnumerable<CommandResult> Quit(Guid? desktopId = null) => Send(desktopId, ShellBatInstanceCommandId.Quit);
    public IEnumerable<CommandResult> Ping(Guid? desktopId = null) => Send(desktopId, ShellBatInstanceCommandId.Ping);
    public IEnumerable<CommandResult> Send(Guid? desktopId, ShellBatInstanceCommandId id, params object?[]? arguments) => Send(desktopId, (uint)id, arguments);
    public virtual IEnumerable<CommandResult> Send(Guid? desktopId, uint type, params object?[]? arguments)
    {
        var input = new List<object?>();
        ShellBatInstanceCommand.AddWellKnownArguments(desktopId, input);
        if (arguments != null && arguments.Length > 0)
        {
            input.AddRange(arguments!);
        }

        DirectN.Functions.AllowSetForegroundWindow((uint)ProcessId);
        return CommandTarget.TryExec(ProcessId, $"{Program.AppId}:{ShellBatInstance.MonikerPrefix:N}:{Name}", ShellBatInstance.CommandGroupId, type, input.ToArray());
    }

    protected virtual void OnRemoteInstanceEvent(object sender, ShellBatRemoteInstanceEventArgs e) => RemoteInstanceEvent?.Invoke(sender, e);

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            // unhook 
            if (_eventsCookie != 0)
            {
                var cpc = ComObject.As<IConnectionPointContainer>();
                if (cpc != null)
                {
                    cpc.Object.FindConnectionPoint(ShellBatInstance.ConnectionPointInterfaceId, out var unk);
                    using var cp = new ComObject<DirectN.IConnectionPoint>(unk);
                    cp?.Object.Unadvise(_eventsCookie);
                }
            }
        }
        base.Dispose(disposing);
    }

    [System.Runtime.InteropServices.Marshalling.GeneratedComClass]
    private sealed partial class Dispatch(ShellBatRemoteInstance instance) : DirectN.IDispatch
    {
        public HRESULT GetTypeInfoCount(out uint pctinfo) { pctinfo = 0; return DirectN.Constants.E_NOTIMPL; }
        public HRESULT GetTypeInfo(uint iTInfo, uint lcid, out ITypeInfo ppTInfo) { ppTInfo = null!; return DirectN.Constants.E_NOTIMPL; }
        public HRESULT GetIDsOfNames(in Guid riid, PWSTR[] rgszNames, uint cNames, uint lcid, int[] rgDispId) => DirectN.Constants.E_NOTIMPL;
        public unsafe HRESULT Invoke(int dispIdMember, in Guid riid, uint lcid, DISPATCH_FLAGS wFlags, in DISPPARAMS pDispParams, nint pVarResult, nint pExcepInfo, nint puArgErr)
        {
            object?[]? args = null;
            if (pDispParams.cArgs > 0)
            {
                args = new object[pDispParams.cArgs];
                for (var i = 0; i < pDispParams.cArgs; i++)
                {
                    var pv = (VARIANT*)(pDispParams.rgvarg + i * sizeof(VARIANT));
                    using var v = Variant.Attach(ref Unsafe.AsRef<VARIANT>(pv), false);
                    args[i] = v.Value;
                }
            }

            var id = (ShellBatInstanceRemoteEventType)dispIdMember;
            instance.OnRemoteInstanceEvent(instance, new ShellBatRemoteInstanceEventArgs(id, args));
            ShellBatInstance.LogVerbose($"{id} ({string.Join(", ", args ?? [])})");
            return DirectN.Constants.S_OK;
        }
    }

    internal static ShellBatRemoteInstance[] UpdateInstances()
    {
        DirectN.Functions.CreateBindCtx(0, out var ctx);
        if (ctx == null)
            return [];

        var list = new List<ShellBatRemoteInstance>();
        var prefix = $"{CommandTarget.Delimiter}{$"{Program.AppId}:{ShellBatInstance.MonikerPrefix:N}"}:";
        foreach (var mk in RunningObjectTable.Enumerate(false))
        {
            try
            {
                var name = getName();
                if (name == null)
                    continue;

                if (!name.StartsWith(prefix))
                    continue;

                var nameAndPid = name[prefix.Length..].Split(':', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                if (nameAndPid.Length != 2)
                    continue;

                var instanceName = nameAndPid[0];
                if (IOUtilities.NameToValidFileName(instanceName) != instanceName)
                    continue;

                if (!int.TryParse(nameAndPid[1], out var pid))
                    continue;

                if (pid == Environment.ProcessId)
                    continue;

                var unk = RunningObjectTable.GetObject(mk.Object, false);
                if (unk != 0)
                {
                    var co = DirectN.Extensions.Com.ComObject.FromPointer<IOleCommandTarget>(unk);
                    if (co != null)
                    {
                        var instance = new ShellBatRemoteInstance(instanceName, pid, co);

                        // hook on possible events
                        var cpc = co.As<IConnectionPointContainer>();
                        if (cpc != null)
                        {
                            cpc.Object.FindConnectionPoint(ShellBatInstance.ConnectionPointInterfaceId, out var pcpp);
                            if (pcpp != null)
                            {
                                using var cp = new ComObject<DirectN.IConnectionPoint>(pcpp);
                                if (cp != null)
                                {
                                    var unkDisp = DirectN.Extensions.Com.ComObject.GetOrCreateComInstance(instance._dispatch);
                                    if (unkDisp != 0)
                                    {
                                        cp.Object.Advise(unkDisp, out instance._eventsCookie);
                                        Marshal.Release(unkDisp);
                                    }
                                }
                            }
                        }

                        list.Add(instance);
                    }
                }
            }
            finally
            {
                mk.Dispose();
            }

            string? getName()
            {
                try
                {
                    mk.Object.GetDisplayName(ctx, null!, out var dn);
                    return dn.ToString();
                }
                catch
                {
                    return null;
                }
            }
        }

        return [.. list.OrderBy(i => i.ProcessId)];
    }
}
