using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Option Right Type (Put or Call)
/// </summary>
[Serializable]
public class RightType : Enumeration<RightType, string>
{
    public static RightType Put  = new("P", nameof(Put));
    public static RightType Call = new("C", nameof(Call));

    public RightType(string value, string name) : base(value, name) { }
}