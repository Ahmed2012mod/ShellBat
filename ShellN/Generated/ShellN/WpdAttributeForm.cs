#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/wpdattributeform
public enum WpdAttributeForm
{
    WPD_PROPERTY_ATTRIBUTE_FORM_UNSPECIFIED = 0,
    WPD_PROPERTY_ATTRIBUTE_FORM_RANGE = 1,
    WPD_PROPERTY_ATTRIBUTE_FORM_ENUMERATION = 2,
    WPD_PROPERTY_ATTRIBUTE_FORM_REGULAR_EXPRESSION = 3,
    WPD_PROPERTY_ATTRIBUTE_FORM_OBJECT_IDENTIFIER = 4,
}
