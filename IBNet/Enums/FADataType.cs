using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Financial Advisor Data Message
/// </summary>
[Serializable]
public class FADataType : Enumeration<FADataType, int>
{
    public static FADataType Groups   = new(1, nameof(Groups));
    public static FADataType Profiles = new(2, nameof(Profiles));
    public static FADataType Aliases  = new(3, nameof(Aliases));

    public FADataType(int value, string name) : base(value, name)
    {
    }
}