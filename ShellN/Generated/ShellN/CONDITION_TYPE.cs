#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/structuredquerycondition/ne-structuredquerycondition-condition_type
public enum CONDITION_TYPE
{
    CT_AND_CONDITION = 0,
    CT_OR_CONDITION = 1,
    CT_NOT_CONDITION = 2,
    CT_LEAF_CONDITION = 3,
}
