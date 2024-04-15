using System;
using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Order Time in Force Values
/// </summary>
[Serializable]
public class TimeInForce : Enumeration<TimeInForce, string>
{
    /// <summary>
    /// Day
    /// </summary>
    public static TimeInForce Day = new TimeInForce("DAY", nameof(Day));

    /// <summary>
    /// Good Till Cancel
    /// </summary>
    public static TimeInForce GoodTillCancel = new TimeInForce("GTC", nameof(GoodTillCancel));

    /// <summary>
    /// You can set the time in force for MARKET or LIMIT orders as IOC. This dictates that any portion of the order not executed immediately after it becomes available on the market will be cancelled.
    /// </summary>
    public static TimeInForce ImmediateOrCancel = new TimeInForce("IOC", nameof(ImmediateOrCancel));

    /// <summary>
    /// Setting FOK as the time in force dictates that the entire order must execute immediately or be canceled.
    /// </summary>
    public static TimeInForce FillOrKill = new TimeInForce("FOK", nameof(FillOrKill));

    /// <summary>
    /// Good Till Date
    /// </summary>
    public static TimeInForce GoodTillDate = new TimeInForce("GTD", nameof(GoodTillDate));

    /// <summary>
    /// Market On Open
    /// </summary>
    public static TimeInForce MarketOnOpen = new TimeInForce("OPG", nameof(MarketOnOpen));

    /// <summary>
    /// Undefined
    /// </summary>
    public static TimeInForce Undefined = new TimeInForce("", nameof(Undefined));

    public TimeInForce(string value, string name) : base(value, name) { }
}