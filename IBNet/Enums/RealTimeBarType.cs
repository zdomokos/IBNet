using System;
using System.ComponentModel;
using Ztg.Common.DataStructures.Enums;

namespace IBNet.Enums
{
    /// <summary>
    /// Real Time Bar Type - "What to Show"
    /// </summary>
    [Serializable]
    public class RealTimeBarType : Enumeration<RealTimeBarType, string>
    {
        public static RealTimeBarType Trades   = new RealTimeBarType("TRADES", nameof(Trades));
        public static RealTimeBarType Midpoint = new RealTimeBarType("MIDPOINT", nameof(Midpoint));
        public static RealTimeBarType Bid      = new RealTimeBarType("BID", nameof(Bid));
        public static RealTimeBarType Ask      = new RealTimeBarType("ASK", nameof(Ask));

        public RealTimeBarType(string value, string name) : base(value, name) { }
    }
}
