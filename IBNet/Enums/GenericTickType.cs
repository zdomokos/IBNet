using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Generic Ticks
/// </summary>
[Serializable]
public class GenericTickType : Enumeration<GenericTickType, int>
{
    public static GenericTickType Undefined    = new(0, nameof(Undefined), "");
    public static GenericTickType OptionVolume = new(100, nameof(OptionVolume), "Option Volume (currently for stocks)");

    public static GenericTickType OptionOpenInterest =
        new(101, nameof(OptionOpenInterest), "Option Open Interest (currently for stocks)");

    public static GenericTickType HistoricalVolatility =
        new(104, nameof(HistoricalVolatility), "Historical Volatility (currently for stocks)");

    public static GenericTickType AvgOptionVolume =
        new(105, nameof(AvgOptionVolume), "Average Option Volume (currently for stocks)");

    public static GenericTickType OptionImpliedVolatility =
        new(106, nameof(OptionImpliedVolatility), "Option Implied Volatility (currently for stocks)");

    public static GenericTickType IndexFuturePremium = new(162, nameof(IndexFuturePremium), "Index Future Premium");
    public static GenericTickType MiscellaneousStats = new(165, nameof(MiscellaneousStats), "Miscellaneous Stats");
    public static GenericTickType MarkPrice = new(221, nameof(MarkPrice), "Mark Price (used in TWS P&L computations)");

    public static GenericTickType AuctionPrice =
        new(225, nameof(AuctionPrice), "Auction values (volume, price and imbalance)");

    public static GenericTickType RTVolume = new(233, nameof(RTVolume),
                                                 "RTVolume - contains the last trade price, last trade size, last trade time, total volume, VWAP, and single trade flag.");

    public static GenericTickType Shortable         = new(236, nameof(Shortable), "Shortable");
    public static GenericTickType Inventory         = new(256, nameof(Inventory), "Inventory");
    public static GenericTickType FundamentalRatios = new(258, nameof(FundamentalRatios), "Fundamental Ratios");
    public static GenericTickType RTHistVol         = new(411, nameof(RTHistVol), "Realtime Historical Volatility");
    public static GenericTickType IBDividends       = new(456, nameof(IBDividends), "IBDividends");

    public GenericTickType(int value, string name, string description) : base(value, name)
    {
        Description = description;
    }

    public string Description { get; }
}