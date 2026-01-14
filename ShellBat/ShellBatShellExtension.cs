namespace ShellBat;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
[Guid("f01de33a-a509-4404-99af-335eb4f02ffc")]
public partial class ShellBatShellExtension : IExecuteCommand, IObjectWithSite, IObjectWithSelection, IInitializeCommand
{
    private IComObject<DirectN.IServiceProvider>? _serviceProvider;
    private POINT? _position;
    private IComObject<IShellItemArray>? _array;

    public HRESULT GetSite(in Guid riid, out nint ppvSite)
    {
        if (_serviceProvider == null)
        {
            ppvSite = 0;
            //Application.TraceVerbose("Site get: no site");
            return DirectN.Constants.E_NOINTERFACE;
        }

        return _serviceProvider.QueryInterface(riid, out ppvSite);
    }

    public HRESULT SetSite(nint pUnkSite)
    {
        _serviceProvider?.Dispose();
        _serviceProvider = ComObject.FromPointer<DirectN.IServiceProvider>(pUnkSite);
        //Application.TraceVerbose($"Site set {pUnkSite} sp {_serviceProvider}");

        if (pUnkSite == 0)
        {
            _position = null;
            Interlocked.Exchange(ref _array, null)?.Dispose();
            Interlocked.Exchange(ref _serviceProvider, null)?.Dispose();
        }
        return DirectN.Constants.S_OK;
    }

    private ShellItem[] GetItems()
    {
        var items = _array.Enumerate().ToArray();
        //Application.TraceVerbose($"Items count: {items.Length}");
        // array is empty when invoked from folder background, etc.
        if (items.Length > 0 || _serviceProvider == null)
            return items;

        _serviceProvider.Object.QueryService(ShellN.Constants.SID_STopLevelBrowser, typeof(IShellBrowser).GUID, out var ppv);
        using var browser = ComObject.FromPointer<IShellBrowser>(ppv);
        if (browser == null)
            return items;

        browser.Object.QueryActiveShellView(out var shellViewObj);
        if (shellViewObj == null)
            return items;

        using var shellView = ShellView.FromObject(shellViewObj);
        if (shellView == null)
            return items;

        var folder = shellView.GetFolder();
        if (folder == null)
            return items;

        return [folder];
    }

    HRESULT IExecuteCommand.Execute()
    {
        //Application.TraceVerbose();
        var items = GetItems();
        //Application.TraceVerbose($"Items count: {items.Length}");
        if (items.Length == 0)
            return DirectN.Constants.S_OK;

        try
        {
            RECT? rect = null;
            var padding = Math.Max(ShellBatInstanceSettings.DefaultDockPadding, ShellBatInstance.Current.Settings.DockPadding) * 2;
            if (_position.HasValue)
            {
                var monitor = new DirectN.Extensions.Utilities.Monitor(DirectN.Extensions.Utilities.Monitor.GetNearestFromPoint(_position.Value.x, _position.Value.y));
                var rc = new RECT();
                var area = monitor.WorkingArea;

                var width = area.Width * 3 / 4;
                var height = area.Height * 3 / 4;
                rc.left = area.left + (area.Width - width) / 2 - padding * items.Length - 1;
                rc.top = area.top + (area.Height - height) / 2 - padding * items.Length - 1;
                rc.Width = width;
                rc.Height = height;
                rect = rc;
            }

            var i = 0;
            foreach (var item in items)
            {
                var parsingName = item.GetDisplayName(SIGDN.SIGDN_DESKTOPABSOLUTEPARSING);
                if (parsingName == null)
                    continue;

                //Application.TraceVerbose($"Item: {parsingName}");
                if (i == 0 && !VIRTUAL_KEY.VK_CONTROL.IsPressed())
                {
                    Program.MainWindow?.Navigate(parsingName, false);
                }
                else
                {
                    var options = new OpenNewInstanceOptions
                    {
                        ParsingName = parsingName,
                    };

                    if (rect != null)
                    {
                        var rc = rect.Value;
                        rc.left += i * padding;
                        rc.top += i * padding;
                        rc.right += i * padding;
                        rc.bottom += i * padding;
                        options.Rect = rc;
                    }

                    ShellBatInstance.OpenNewInstance(options);
                }

                i++;
            }
        }
        finally
        {
            items.Dispose();
        }

        return DirectN.Constants.S_OK;
    }

    HRESULT IObjectWithSelection.GetSelection(in Guid riid, out nint ppv)
    {
        //Application.TraceVerbose($"riid: {riid:B}");
        throw new NotImplementedException();
    }

    HRESULT IInitializeCommand.Initialize(PWSTR pszCommandName, IPropertyBag ppb)
    {
        // to support multiple commands, we would check pszCommandName here
        //Application.TraceVerbose($"'{pszCommandName}' bag: {ppb}");
        return DirectN.Constants.S_OK;
    }

    HRESULT IExecuteCommand.SetDirectory(PWSTR pszDirectory)
    {
        //Application.TraceVerbose($"'{pszDirectory}");
        return DirectN.Constants.S_OK;
    }

    HRESULT IExecuteCommand.SetKeyState(uint grfKeyState)
    {
        //Application.TraceVerbose($"{grfKeyState:X8}");
        return DirectN.Constants.S_OK;
    }

    HRESULT IExecuteCommand.SetNoShowUI(BOOL fNoShowUI)
    {
        //Application.TraceVerbose($"{fNoShowUI}");
        return DirectN.Constants.S_OK;
    }

    HRESULT IExecuteCommand.SetParameters(PWSTR pszParameters)
    {
        //Application.TraceVerbose($"{pszParameters}");
        return DirectN.Constants.S_OK;
    }

    HRESULT IExecuteCommand.SetPosition(POINT pt)
    {
        _position = pt;
        //Application.TraceVerbose($"{pt}");
        return DirectN.Constants.S_OK;
    }

    HRESULT IObjectWithSelection.SetSelection(IShellItemArray psia)
    {
        //Application.TraceVerbose($"psia: {psia}");
        Interlocked.Exchange(ref _array, null)?.Dispose();
        if (psia != null)
        {
            _array = new ComObject<IShellItemArray>(psia);
        }
        return DirectN.Constants.S_OK;
    }

    HRESULT IExecuteCommand.SetShowWindow(int nShow)
    {
        //Application.TraceVerbose($"{(SHOW_WINDOW_CMD)nShow}");
        return DirectN.Constants.S_OK;
    }
}
