#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shdeprecated/nn-shdeprecated-itravellog
[GeneratedComInterface, Guid("66a9cb08-4802-11d2-a561-00a0c92dbfe8")]
public partial interface ITravelLog
{
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravellog-addentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEntry(nint punk, BOOL fIsLocalAnchor);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravellog-updateentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateEntry(nint punk, BOOL fIsLocalAnchor);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravellog-updateexternal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateExternal(nint punk, nint punkHLBrowseContext);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravellog-travel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Travel(nint punk, int iOffset);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravellog-gettravelentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTravelEntry(nint punk, int iOffset, nint /* optional ITravelEntry* */ ppte);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravellog-findtravelentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindTravelEntry(nint punk, nint pidl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITravelEntry>))] out ITravelEntry ppte);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravellog-gettooltiptext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetToolTipText(nint punk, int iOffset, int idsTemplate, [MarshalUsing(CountElementName = nameof(cchText))] PWSTR pwzText, uint cchText);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravellog-insertmenuentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertMenuEntries(nint punk, HMENU hmenu, int nPos, int idFirst, int idLast, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravellog-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITravelLog>))] out ITravelLog pptl);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravellog-countentries
    [PreserveSig]
    uint CountEntries(nint punk);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravellog-revert
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Revert();
}
