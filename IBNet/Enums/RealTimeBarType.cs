using System;
using System.ComponentModel;
using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Real Time Bar Type - "What to Show"
/// </summary>
[Serializable]
public class RealTimeBarType : Enumeration<RealTimeBarType, string>
{
    public static RealTimeBarType Trades   = new("TRADES", nameof(Trades));
    public static RealTimeBarType Midpoint = new("MIDPOINT", nameof(Midpoint));
    public static RealTimeBarType Bid      = new("BID", nameof(Bid));
    public static RealTimeBarType Ask      = new("ASK", nameof(Ask));

    public RealTimeBarType(string value, string name) : base(value, name) { }
}