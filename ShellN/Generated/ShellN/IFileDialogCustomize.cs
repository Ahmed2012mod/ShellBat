#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifiledialogcustomize
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e6fdd21a-163f-4975-9c8c-a69f1ba37034")]
public partial interface IFileDialogCustomize
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-enableopendropdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableOpenDropDown(uint dwIDCtl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-addmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddMenu(uint dwIDCtl, PWSTR pszLabel);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-addpushbutton
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPushButton(uint dwIDCtl, PWSTR pszLabel);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-addcombobox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddComboBox(uint dwIDCtl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-addradiobuttonlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRadioButtonList(uint dwIDCtl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-addcheckbutton
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddCheckButton(uint dwIDCtl, PWSTR pszLabel, BOOL bChecked);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-addeditbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEditBox(uint dwIDCtl, PWSTR pszText);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-addseparator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSeparator(uint dwIDCtl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-addtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddText(uint dwIDCtl, PWSTR pszText);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-setcontrollabel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetControlLabel(uint dwIDCtl, PWSTR pszLabel);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-getcontrolstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetControlState(uint dwIDCtl, out CDCONTROLSTATEF pdwState);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-setcontrolstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetControlState(uint dwIDCtl, CDCONTROLSTATEF dwState);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-geteditboxtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEditBoxText(uint dwIDCtl, out nint ppszText);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-seteditboxtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEditBoxText(uint dwIDCtl, PWSTR pszText);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-getcheckbuttonstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCheckButtonState(uint dwIDCtl, out BOOL pbChecked);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-setcheckbuttonstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCheckButtonState(uint dwIDCtl, BOOL bChecked);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-addcontrolitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddControlItem(uint dwIDCtl, uint dwIDItem, PWSTR pszLabel);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-removecontrolitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveControlItem(uint dwIDCtl, uint dwIDItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-removeallcontrolitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllControlItems(uint dwIDCtl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-getcontrolitemstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetControlItemState(uint dwIDCtl, uint dwIDItem, out CDCONTROLSTATEF pdwState);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-setcontrolitemstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetControlItemState(uint dwIDCtl, uint dwIDItem, CDCONTROLSTATEF dwState);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-getselectedcontrolitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelectedControlItem(uint dwIDCtl, out uint pdwIDItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-setselectedcontrolitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSelectedControlItem(uint dwIDCtl, uint dwIDItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-startvisualgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartVisualGroup(uint dwIDCtl, PWSTR pszLabel);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-endvisualgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndVisualGroup();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-makeprominent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MakeProminent(uint dwIDCtl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogcustomize-setcontrolitemtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetControlItemText(uint dwIDCtl, uint dwIDItem, PWSTR pszLabel);
}
