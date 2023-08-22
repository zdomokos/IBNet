using System;
using Ztg.Common.DataStructures.Enums;

namespace IBNet.Enums
{
    /// <summary>
    /// Contract Security Types
    /// </summary>
    [Serializable]
    public class SecurityType : Enumeration<SecurityType, string>
    {
        public static SecurityType Stock        = new SecurityType("STK", nameof(Stock));
        public static SecurityType Option       = new SecurityType("OPT", nameof(Option));
        public static SecurityType Future       = new SecurityType("FUT", nameof(Future));
        public static SecurityType Index        = new SecurityType("IND", nameof(Index));
        public static SecurityType FutureOption = new SecurityType("FOP", nameof(FutureOption));
        public static SecurityType Cash         = new SecurityType("CASH", nameof(Cash));
        public static SecurityType Bag          = new SecurityType("BAG", nameof(Bag));
        public static SecurityType Bond         = new SecurityType("BOND", nameof(Bond));
        public static SecurityType Warrant      = new SecurityType("WAR", nameof(Warrant));
        public static SecurityType Commodity    = new SecurityType("CMDTY", nameof(Commodity));
        public static SecurityType Bill         = new SecurityType("BILL", nameof(Bill));
        public static SecurityType Undefined    = new SecurityType("", nameof(Undefined));

        public SecurityType(string value, string name) : base(value, name)
        { }
    }
}
