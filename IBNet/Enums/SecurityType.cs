using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Contract Security Types
/// </summary>
[Serializable]
public class SecurityType : Enumeration<SecurityType, string>
{
    public static SecurityType Stock        = new("STK", nameof(Stock));
    public static SecurityType Option       = new("OPT", nameof(Option));
    public static SecurityType Future       = new("FUT", nameof(Future));
    public static SecurityType Index        = new("IND", nameof(Index));
    public static SecurityType FutureOption = new("FOP", nameof(FutureOption));
    public static SecurityType Cash         = new("CASH", nameof(Cash));
    public static SecurityType Bag          = new("BAG", nameof(Bag));
    public static SecurityType Bond         = new("BOND", nameof(Bond));
    public static SecurityType Warrant      = new("WAR", nameof(Warrant));
    public static SecurityType Commodity    = new("CMDTY", nameof(Commodity));
    public static SecurityType Bill         = new("BILL", nameof(Bill));
    public static SecurityType Undefined    = new("", nameof(Undefined));

    public SecurityType(string value, string name) : base(value, name)
    {
    }
}

