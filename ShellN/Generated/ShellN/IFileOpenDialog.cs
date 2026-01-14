#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifileopendialog
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d57c7288-d4ad-4768-be02-9d969532d960")]
public partial interface IFileOpenDialog : IFileDialog
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileopendialog-getresults
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResults([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] out IShellItemArray ppenum);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileopendialog-getselecteditems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelectedItems([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] out IShellItemArray ppsai);
}
