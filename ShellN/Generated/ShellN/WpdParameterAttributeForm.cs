#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/wpd-parameter-attribute-form
public enum WpdParameterAttributeForm
{
    WPD_PARAMETER_ATTRIBUTE_FORM_UNSPECIFIED = 0,
    WPD_PARAMETER_ATTRIBUTE_FORM_RANGE = 1,
    WPD_PARAMETER_ATTRIBUTE_FORM_ENUMERATION = 2,
    WPD_PARAMETER_ATTRIBUTE_FORM_REGULAR_EXPRESSION = 3,
    WPD_PARAMETER_ATTRIBUTE_FORM_OBJECT_IDENTIFIER = 4,
}
