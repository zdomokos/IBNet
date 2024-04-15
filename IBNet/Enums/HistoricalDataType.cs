using System;
using Headspring;

namespace IBNet.Enums;
//     * @param durationStr the amount of time for which the data needs to be retrieved:
//     *      - " S (seconds)
//     *      - " D (days)
//     *      - " W (weeks)
//     *      - " M (months)
//     *      - " Y (years)

/// <summary>
/// determines whether to return all data available during the requested time span, or only data that falls within regular trading hours. Valid values include:
/// </summary>
[Serializable]
public class UseRth : Enumeration<UseRth, int>
{
    // 0 - all data is returned even where the market in question was outside of its regular trading hours.
    public static UseRth No = new(0, nameof(No));
    // 1 - only data within the regular trading hours is returned, even if the requested time span falls partially or completely outside of the RTH.
    public static UseRth Yes = new(1, nameof(Yes));

    public UseRth(int value, string name) : base(value, name) { }
}

//@param formatDate set to 1 to obtain the bars' time as yyyyMMdd HH:mm:ss, set to 2 to obtain it like system time format in seconds
[Serializable]
public class BarTimeFormat : Enumeration<BarTimeFormat>
{
    public static BarTimeFormat YMD         = new(1, nameof(YMD));
    public static BarTimeFormat UnixSeconds = new(2, nameof(UnixSeconds));

    public BarTimeFormat(int value, string name) : base(value, name) { }
}
    
/// <summary>
/// Historical Data Request Return Types
/// </summary>
[Serializable]
public class HistoricalDataType : Enumeration<HistoricalDataType, string>
{
    public static HistoricalDataType Trades        = new("TRADES", nameof(Trades));
    public static HistoricalDataType Midpoint      = new("MIDPOINT", nameof(Midpoint));
    public static HistoricalDataType Bid           = new("BID", nameof(Bid));
    public static HistoricalDataType Ask           = new("ASK", nameof(Ask));
    public static HistoricalDataType BidAsk        = new("BID_ASK", nameof(BidAsk));
    public static HistoricalDataType HistVol       = new("HISTORICAL_VOLATILITY", nameof(HistVol));
    public static HistoricalDataType OptionImplVol = new("OPTION_IMPLIED_VOLATILITY", nameof(OptionImplVol));
    public static HistoricalDataType FeeRate       = new("FEE_RATE", nameof(FeeRate));
    public static HistoricalDataType RebateRate    = new("REBATE_RATE", nameof(RebateRate));

    public HistoricalDataType(string value, string name) : base(value, name) { }
}