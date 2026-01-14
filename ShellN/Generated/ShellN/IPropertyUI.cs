#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ipropertyui
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("757a7d9f-919a-4118-99d7-dbb208c8cc66")]
public partial interface IPropertyUI
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipropertyui-parsepropertyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParsePropertyName(PWSTR pszName, out Guid pfmtid, out uint ppid, ref uint pchEaten);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCannonicalName(in Guid fmtid, uint pid, [MarshalUsing(CountElementName = nameof(cchText))] PWSTR pwszText, uint cchText);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipropertyui-getdisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayName(in Guid fmtid, uint pid, PROPERTYUI_NAME_FLAGS flags, [MarshalUsing(CountElementName = nameof(cchText))] PWSTR pwszText, uint cchText);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipropertyui-getpropertydescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyDescription(in Guid fmtid, uint pid, [MarshalUsing(CountElementName = nameof(cchText))] PWSTR pwszText, uint cchText);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipropertyui-getdefaultwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultWidth(in Guid fmtid, uint pid, out uint pcxChars);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipropertyui-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(in Guid fmtid, uint pid, out PROPERTYUI_FLAGS pflags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipropertyui-formatfordisplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FormatForDisplay(in Guid fmtid, uint pid, in PROPVARIANT ppropvar, PROPERTYUI_FORMAT_FLAGS puiff, [MarshalUsing(CountElementName = nameof(cchText))] PWSTR pwszText, uint cchText);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipropertyui-gethelpinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHelpInfo(in Guid fmtid, uint pid, [MarshalUsing(CountElementName = nameof(cch))] PWSTR pwszHelpFile, uint cch, out uint puHelpID);
}
