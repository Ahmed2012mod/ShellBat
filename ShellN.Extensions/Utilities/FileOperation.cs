namespace ShellN.Extensions.Utilities;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class FileOperation : InterlockedComObject<IFileOperation>, IFileOperationProgressSink
{
    public event EventHandler? PauseTimer;
    public event EventHandler? ResetTimer;
    public event EventHandler? ResumeTimer;
    public event EventHandler? StartOperations;
    public event EventHandler<UpdateProgressEventArgs>? UpdateProgress;
    public event EventHandler<FinishOperationsEventArgs>? FinishOperations;
    public event EventHandler<PreRenameItemEventArgs>? PreRenameItem;
    public event EventHandler<PreMoveItemEventArgs>? PreMoveItem;
    public event EventHandler<PreDeleteItemEventArgs>? PreDeleteItem;
    public event EventHandler<PreCopyItemEventArgs>? PreCopyItem;
    public event EventHandler<PreNewItemEventArgs>? PreNewItem;
    public event EventHandler<PostCopyItemEventArgs>? PostCopyItem;
    public event EventHandler<PostDeleteItemEventArgs>? PostDeleteItem;
    public event EventHandler<PostMoveItemEventArgs>? PostMoveItem;
    public event EventHandler<PostNewItemEventArgs>? PostNewItem;
    public event EventHandler<PostRenameItemEventArgs>? PostRenameItem;

    private uint _cookie;
    private bool _eventsEnabled;

    public FileOperation(nint site = 0)
        : base(DirectN.Extensions.Com.ComObject.CoCreate<IFileOperation>(Constants.FileOperation))
    {
        if (site != 0 && NativeObject is IObjectWithSite ows)
        {
            ows.SetSite(site).ThrowOnError();
        }
    }

    public bool HasAnyOperationsAborted { get { NativeObject.GetAnyOperationsAborted(out var b); return b; } }
    public virtual bool PerformOperationsOnDispose { get; set; } = true;
    public virtual bool EventsEnabled
    {
        get => _eventsEnabled;
        set
        {
            if (_eventsEnabled == value)
                return;

            _eventsEnabled = value;

            try
            {
                if (_eventsEnabled)
                {
                    NativeObject.Advise(this, out _cookie).ThrowOnError();
                }
                else
                {
                    if (_cookie != 0)
                    {
                        NativeObject.Unadvise(_cookie).ThrowOnError();
                        _cookie = 0;
                    }
                }
            }
            catch (InvalidCastException)
            {
                if (Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
                    throw new InvalidOperationException("The current thread is not in STA mode.");

                throw;
            }
        }
    }

    public virtual HRESULT SetProgressMessage(string message, bool throwOnError = true) => NativeObject.SetProgressMessage(PWSTR.From(message)).ThrowOnError(throwOnError);
    public virtual HRESULT SetProgressDialog(IOperationsProgressDialog progressDialog, bool throwOnError = true) => NativeObject.SetProgressDialog(progressDialog).ThrowOnError(throwOnError);
    public virtual HRESULT SetOwnerWindow(HWND windowHandle, bool throwOnError = true) => NativeObject.SetOwnerWindow(windowHandle).ThrowOnError(throwOnError);
    public virtual HRESULT PerformOperations(bool throwOnError = true) => NativeObject.PerformOperations().ThrowOnError(throwOnError);

    public virtual HRESULT SetOperationFlags(FILEOPERATION_FLAGS flags, bool throwOnError = true) => NativeObject.SetOperationFlags(flags).ThrowOnError(throwOnError);
    public virtual HRESULT SetOperationFlags2(FILE_OPERATION_FLAGS2 flags, bool throwOnError = true)
    {
        var fo2 = ComObject.As<IFileOperation2>();
        if (fo2 == null)
            return DirectN.Constants.E_NOINTERFACE;

        return fo2.Object.SetOperationFlags2(flags).ThrowOnError(throwOnError);
    }

    public virtual HRESULT SetProperties(IEnumerable<KeyValuePair<PROPERTYKEY, object?>> properties, bool throwOnError = true)
    {
        if (properties == null)
            return 0;

        var hr = Functions.PSCreatePropertyChangeArray(0, 0, 0, 0, typeof(IPropertyChangeArray).GUID, out var obj).ThrowOnError(throwOnError);
        if (hr.IsError)
            return hr;

        using var array = DirectN.Extensions.Com.ComObject.FromPointer<IPropertyChangeArray>(obj)!;
        foreach (var kv in properties)
        {
            using var pv = new PropVariant(kv.Value);
            hr = Functions.PSCreateSimplePropertyChange(PKA_FLAGS.PKA_SET, kv.Key, pv.Detached, typeof(IPropertyChange).GUID, out var ppv).ThrowOnError(throwOnError);
            if (hr.IsError)
                return hr;

            using var ipc = DirectN.Extensions.Com.ComObject.FromPointer<IPropertyChange>(ppv)!;
            hr = array.Object.Append(ipc.Object).ThrowOnError(throwOnError);
            if (hr.IsError)
                return hr;
        }
        return NativeObject.SetProperties(array.Object).ThrowOnError(throwOnError);
    }

    public HRESULT ApplyPropertiesToItem(ShellItem item, bool throwOnError = true) => ApplyPropertiesToItem(item?.NativeObject!, throwOnError);
    public virtual HRESULT ApplyPropertiesToItem(IShellItem item, bool throwOnError = true) => NativeObject.ApplyPropertiesToItem(item).ThrowOnError(throwOnError);
    public virtual HRESULT ApplyPropertiesToItems(IEnumerable<IShellItem> items, bool throwOnError = true)
    {
        if (items == null)
            return 0;

        return DirectN.Extensions.Com.ComObject.WithComInstance(new EnumShellItems(items), unk => NativeObject.ApplyPropertiesToItems(unk).ThrowOnError(throwOnError), createIfNeeded: true);
    }

    public HRESULT RenameItem(ShellItem item, string newName, bool throwOnError = true) => RenameItem(item?.NativeObject!, newName, throwOnError);
    public virtual HRESULT RenameItem(IShellItem item, string newName, bool throwOnError = true) => NativeObject.RenameItem(item, PWSTR.From(newName), this).ThrowOnError(throwOnError);
    public virtual HRESULT RenameItems(IEnumerable<IShellItem> items, string newName, bool throwOnError = true)
    {
        if (items == null)
            return 0;

        return DirectN.Extensions.Com.ComObject.WithComInstance(new EnumShellItems(items), unk => NativeObject.RenameItems(unk, PWSTR.From(newName)).ThrowOnError(throwOnError), createIfNeeded: true);
    }

    public HRESULT MoveItem(ShellItem item, ShellItem destinationFolder, string? newName = null, bool throwOnError = true) => MoveItem(item?.NativeObject!, destinationFolder?.NativeObject!, newName, throwOnError);
    public virtual HRESULT MoveItem(IShellItem item, IShellItem destinationFolder, string? newName = null, bool throwOnError = true) => NativeObject.MoveItem(item, destinationFolder, PWSTR.From(newName), this).ThrowOnError(throwOnError);
    public virtual HRESULT MoveItems(IEnumerable<IShellItem> items, IShellItem destinationFolder, bool throwOnError = true)
    {
        if (items == null)
            return 0;

        return DirectN.Extensions.Com.ComObject.WithComInstance(new EnumShellItems(items), unk => NativeObject.MoveItems(unk, destinationFolder).ThrowOnError(throwOnError), createIfNeeded: true);
    }

    public HRESULT CopyItem(ShellItem item, ShellItem destinationFolder, string? newName = null, bool throwOnError = true) => CopyItem(item?.NativeObject!, destinationFolder?.NativeObject!, newName, throwOnError);
    public virtual HRESULT CopyItem(IShellItem item, IShellItem destinationFolder, string? newName = null, bool throwOnError = true) => NativeObject.CopyItem(item, destinationFolder, PWSTR.From(newName), this).ThrowOnError(throwOnError);
    public virtual HRESULT CopyItems(IEnumerable<IShellItem> items, IShellItem destinationFolder, bool throwOnError = true)
    {
        if (items == null)
            return 0;

        return DirectN.Extensions.Com.ComObject.WithComInstance(new EnumShellItems(items), unk => NativeObject.CopyItems(unk, destinationFolder).ThrowOnError(throwOnError), createIfNeeded: true);
    }

    public HRESULT DeleteItem(ShellItem item, bool throwOnError = true) => DeleteItem(item?.NativeObject!, throwOnError);
    public virtual HRESULT DeleteItem(IShellItem item, bool throwOnError = true) => NativeObject.DeleteItem(item, this).ThrowOnError(throwOnError);
    public virtual HRESULT DeleteItems(IEnumerable<IShellItem> items, bool throwOnError = true)
    {
        if (items == null)
            return 0;

        return DirectN.Extensions.Com.ComObject.WithComInstance(new EnumShellItems(items), unk => NativeObject.DeleteItems(unk).ThrowOnError(throwOnError), createIfNeeded: true);
    }

    public HRESULT NewItem(ShellItem destinationFolder, FileAttributes fileAttributes, string newName, string? templateName = null, bool throwOnError = true) =>
        NewItem(destinationFolder?.NativeObject!, fileAttributes, newName, templateName, throwOnError);

    public virtual HRESULT NewItem(IShellItem destinationFolder, FileAttributes fileAttributes, string newName, string? templateName = null, bool throwOnError = true) =>
        NativeObject.NewItem(destinationFolder, (uint)fileAttributes, PWSTR.From(newName), PWSTR.From(templateName), this).ThrowOnError(throwOnError);

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (PerformOperationsOnDispose && RawNativeObject != null)
            {
                PerformOperations(false);
            }

            if (_cookie != 0)
            {
                _cookie = 0;
                NativeObject.Unadvise(_cookie);
            }

            if (RawNativeObject is IObjectWithSite ows)
            {
                ows.SetSite(0);
            }
        }
        base.Dispose(disposing);
    }

    HRESULT IFileOperationProgressSink.StartOperations() { StartOperations?.Invoke(this, EventArgs.Empty); return DirectN.Constants.S_OK; }
    HRESULT IFileOperationProgressSink.FinishOperations(HRESULT hrResult) { FinishOperations?.Invoke(this, new FinishOperationsEventArgs(hrResult)); return DirectN.Constants.S_OK; }

    HRESULT IFileOperationProgressSink.PreRenameItem(uint dwFlags, IShellItem psiItem, PWSTR pszNewName)
    {
        var e = new PreRenameItemEventArgs((_TRANSFER_SOURCE_FLAGS)dwFlags, psiItem, pszNewName.ToString());
        PreRenameItem?.Invoke(this, e);
        return e.HResult;
    }

    HRESULT IFileOperationProgressSink.PostRenameItem(uint dwFlags, IShellItem psiItem, PWSTR pszNewName, HRESULT hrRename, IShellItem psiNewlyCreated)
    {
        var e = new PostRenameItemEventArgs((_TRANSFER_SOURCE_FLAGS)dwFlags, psiItem, pszNewName.ToString(), hrRename, psiNewlyCreated);
        PostRenameItem?.Invoke(this, e);
        return e.HResult;
    }

    HRESULT IFileOperationProgressSink.PreMoveItem(uint dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder, PWSTR pszNewName)
    {
        var e = new PreMoveItemEventArgs((_TRANSFER_SOURCE_FLAGS)dwFlags, psiItem, psiDestinationFolder, pszNewName.ToString());
        PreMoveItem?.Invoke(this, e);
        return e.HResult;
    }

    HRESULT IFileOperationProgressSink.PostMoveItem(uint dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder, PWSTR pszNewName, HRESULT hrMove, IShellItem psiNewlyCreated)
    {
        var e = new PostMoveItemEventArgs((_TRANSFER_SOURCE_FLAGS)dwFlags, psiItem, psiDestinationFolder, pszNewName.ToString(), hrMove, psiNewlyCreated);
        PostMoveItem?.Invoke(this, e);
        return e.HResult;
    }

    HRESULT IFileOperationProgressSink.PreCopyItem(uint dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder, PWSTR pszNewName)
    {
        var e = new PreCopyItemEventArgs((_TRANSFER_SOURCE_FLAGS)dwFlags, psiItem, psiDestinationFolder, pszNewName.ToString());
        PreCopyItem?.Invoke(this, e);
        return e.HResult;
    }

    HRESULT IFileOperationProgressSink.PostCopyItem(uint dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder, PWSTR pszNewName, HRESULT hrCopy, IShellItem psiNewlyCreated)
    {
        var e = new PostCopyItemEventArgs((_TRANSFER_SOURCE_FLAGS)dwFlags, psiItem, psiDestinationFolder, pszNewName.ToString(), hrCopy, psiNewlyCreated);
        PostCopyItem?.Invoke(this, e);
        return e.HResult;
    }

    HRESULT IFileOperationProgressSink.PreDeleteItem(uint dwFlags, IShellItem psiItem)
    {
        var e = new PreDeleteItemEventArgs((_TRANSFER_SOURCE_FLAGS)dwFlags, psiItem);
        PreDeleteItem?.Invoke(this, e);
        return e.HResult;
    }

    HRESULT IFileOperationProgressSink.PostDeleteItem(uint dwFlags, IShellItem psiItem, HRESULT hrDelete, IShellItem psiNewlyCreated)
    {
        var e = new PostDeleteItemEventArgs((_TRANSFER_SOURCE_FLAGS)dwFlags, psiItem, hrDelete, psiNewlyCreated);
        PostDeleteItem?.Invoke(this, e);
        return e.HResult;
    }

    HRESULT IFileOperationProgressSink.PreNewItem(uint dwFlags, IShellItem psiDestinationFolder, PWSTR pszNewName)
    {
        var e = new PreNewItemEventArgs((_TRANSFER_SOURCE_FLAGS)dwFlags, psiDestinationFolder, pszNewName.ToString());
        PreNewItem?.Invoke(this, e);
        return e.HResult;
    }

    HRESULT IFileOperationProgressSink.PostNewItem(uint dwFlags, IShellItem psiDestinationFolder, PWSTR pszNewName, PWSTR pszTemplateName, uint dwFileAttributes, HRESULT hrNew, IShellItem psiNewItem)
    {
        var e = new PostNewItemEventArgs((_TRANSFER_SOURCE_FLAGS)dwFlags, psiDestinationFolder, pszNewName.ToString(), pszTemplateName.ToString(), (FileAttributes)dwFileAttributes, hrNew, psiNewItem);
        PostNewItem?.Invoke(this, e);
        return e.HResult;
    }

    HRESULT IFileOperationProgressSink.UpdateProgress(uint iWorkTotal, uint iWorkSoFar) { UpdateProgress?.Invoke(this, new UpdateProgressEventArgs(iWorkTotal, iWorkSoFar)); return DirectN.Constants.S_OK; }
    HRESULT IFileOperationProgressSink.ResetTimer() { ResetTimer?.Invoke(this, EventArgs.Empty); return DirectN.Constants.S_OK; }
    HRESULT IFileOperationProgressSink.PauseTimer() { PauseTimer?.Invoke(this, EventArgs.Empty); return DirectN.Constants.S_OK; }
    HRESULT IFileOperationProgressSink.ResumeTimer() { ResumeTimer?.Invoke(this, EventArgs.Empty); return DirectN.Constants.S_OK; }
}
