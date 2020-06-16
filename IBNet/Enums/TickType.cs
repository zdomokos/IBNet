using System;
using Ztg.Common.DataStructures.Enums;
using IBTick = IBApi.TickType;

namespace IBNet.Enums
{
    /// <summary>
    /// Incoming Tick Types
    /// </summary>
    [Serializable]
    public class TickType : Enumeration<TickType>
    {
        public static TickType BidSize                = new TickType(IBTick.BID_SIZE, nameof(BidSize));
        public static TickType Bid                    = new TickType(IBTick.BID, nameof(Bid));
        public static TickType Ask                    = new TickType(IBTick.ASK, nameof(Ask));
        public static TickType AskSize                = new TickType(IBTick.ASK_SIZE, nameof(AskSize));
        public static TickType Last                   = new TickType(IBTick.LAST, nameof(Last));
        public static TickType LastSize               = new TickType(IBTick.LAST_SIZE, nameof(LastSize));
        public static TickType High                   = new TickType(IBTick.HIGH, nameof(High));
        public static TickType Low                    = new TickType(IBTick.LOW, nameof(Low));
        public static TickType Volume                 = new TickType(IBTick.VOLUME, nameof(Volume));
        public static TickType Close                  = new TickType(IBTick.CLOSE, nameof(Close));
        public static TickType BidOption              = new TickType(IBTick.BID_OPTION, nameof(BidOption));
        public static TickType AskOption              = new TickType(IBTick.ASK_OPTION, nameof(AskOption));
        public static TickType LastOption             = new TickType(IBTick.LAST_OPTION, nameof(LastOption));
        public static TickType ModelOption            = new TickType(IBTick.MODEL_OPTION, nameof(ModelOption));
        public static TickType Open                   = new TickType(IBTick.OPEN, nameof(Open));
        public static TickType Low13Week              = new TickType(IBTick.LOW_13_WEEK, nameof(Low13Week));
        public static TickType High13Week             = new TickType(IBTick.HIGH_13_WEEK, nameof(High13Week));
        public static TickType Low26Week              = new TickType(IBTick.LOW_26_WEEK, nameof(Low26Week));
        public static TickType High26Week             = new TickType(IBTick.HIGH_26_WEEK, nameof(High26Week));
        public static TickType Low52Week              = new TickType(IBTick.LOW_52_WEEK, nameof(Low52Week));
        public static TickType High52Week             = new TickType(IBTick.HIGH_52_WEEK, nameof(High52Week));
        public static TickType AvgVolume              = new TickType(IBTick.AVG_VOLUME, nameof(AvgVolume));
        public static TickType OpenInterest           = new TickType(IBTick.OPEN_INTEREST, nameof(OpenInterest));
        public static TickType OptionHistoricalVol    = new TickType(IBTick.OPTION_HISTORICAL_VOL, nameof(OptionHistoricalVol));
        public static TickType OptionImpliedVol       = new TickType(IBTick.OPTION_IMPLIED_VOL, nameof(OptionImpliedVol));
        public static TickType OptionBidExch          = new TickType(IBTick.OPTION_BID_EXCH, nameof(OptionBidExch));
        public static TickType OptionAskExch          = new TickType(IBTick.OPTION_ASK_EXCH, nameof(OptionAskExch));
        public static TickType OptionCallOpenInterest = new TickType(IBTick.OPTION_CALL_OPEN_INTEREST, nameof(OptionCallOpenInterest));
        public static TickType OptionPutOpenInterest  = new TickType(IBTick.OPTION_PUT_OPEN_INTEREST, nameof(OptionPutOpenInterest));
        public static TickType OptionCallVolume       = new TickType(IBTick.OPTION_CALL_VOLUME, nameof(OptionCallVolume));
        public static TickType OptionPutVolume        = new TickType(IBTick.OPTION_PUT_VOLUME, nameof(OptionPutVolume));
        public static TickType IndexFuturePremium     = new TickType(IBTick.INDEX_FUTURE_PREMIUM, nameof(IndexFuturePremium));
        public static TickType BidExch                = new TickType(IBTick.BID_EXCH, nameof(BidExch));
        public static TickType AskExch                = new TickType(IBTick.ASK_EXCH, nameof(AskExch));
        public static TickType AuctionVolume          = new TickType(IBTick.AUCTION_VOLUME, nameof(AuctionVolume));
        public static TickType AuctionPrice           = new TickType(IBTick.AUCTION_PRICE, nameof(AuctionPrice));
        public static TickType AuctionImbalance       = new TickType(IBTick.AUCTION_IMBALANCE, nameof(AuctionImbalance));
        public static TickType MarkPrice              = new TickType(IBTick.MARK_PRICE, nameof(MarkPrice));
        public static TickType BidEfpComputation      = new TickType(IBTick.BID_EFP_COMPUTATION, nameof(BidEfpComputation));
        public static TickType AskEfpComputation      = new TickType(IBTick.ASK_EFP_COMPUTATION, nameof(AskEfpComputation));
        public static TickType LastEfpComputation     = new TickType(IBTick.LAST_EFP_COMPUTATION, nameof(LastEfpComputation));
        public static TickType OpenEfpComputation     = new TickType(IBTick.OPEN_EFP_COMPUTATION, nameof(OpenEfpComputation));
        public static TickType HighEfpComputation     = new TickType(IBTick.HIGH_EFP_COMPUTATION, nameof(HighEfpComputation));
        public static TickType LowEfpComputation      = new TickType(IBTick.LOW_EFP_COMPUTATION, nameof(LowEfpComputation));
        public static TickType CloseEfpComputation    = new TickType(IBTick.CLOSE_EFP_COMPUTATION, nameof(CloseEfpComputation));
        public static TickType LastTimestamp          = new TickType(IBTick.LAST_TIMESTAMP, nameof(LastTimestamp));
        public static TickType Shortable              = new TickType(IBTick.SHORTABLE, nameof(Shortable));
        public static TickType FundamentalRatios      = new TickType(IBTick.FUNDAMENTAL_RATIOS, nameof(FundamentalRatios));
        public static TickType RtVolume               = new TickType(IBTick.RT_VOLUME, nameof(RtVolume));
        public static TickType Halted                 = new TickType(IBTick.HALTED, nameof(Halted));
        public static TickType BidYield               = new TickType(IBTick.BID_YIELD, nameof(BidYield));
        public static TickType AskYield               = new TickType(IBTick.ASK_YIELD, nameof(AskYield));
        public static TickType LastYield              = new TickType(IBTick.LAST_YIELD, nameof(LastYield));
        public static TickType CustOptionComputation  = new TickType(IBTick.CUST_OPTION_COMPUTATION, nameof(CustOptionComputation));
        public static TickType TradeCount             = new TickType(IBTick.TRADE_COUNT, nameof(TradeCount));
        public static TickType TradeRate              = new TickType(IBTick.TRADE_RATE, nameof(TradeRate));
        public static TickType VolumeRate             = new TickType(IBTick.VOLUME_RATE, nameof(VolumeRate));
        public static TickType LastRthTrade           = new TickType(IBTick.LAST_RTH_TRADE, nameof(LastRthTrade));
        public static TickType RtHistoricalVol        = new TickType(IBTick.RT_HISTORICAL_VOL, nameof(RtHistoricalVol));
        public static TickType IbDividends            = new TickType(IBTick.IB_DIVIDENDS, nameof(IbDividends));
        public static TickType BondFactorMultiplier   = new TickType(IBTick.BOND_FACTOR_MULTIPLIER, nameof(BondFactorMultiplier));
        public static TickType RegulatoryImbalance    = new TickType(IBTick.REGULATORY_IMBALANCE, nameof(RegulatoryImbalance));
        public static TickType NewsTick               = new TickType(IBTick.NEWS_TICK, nameof(NewsTick));
        public static TickType ShortTermVolume3Min    = new TickType(IBTick.SHORT_TERM_VOLUME_3_MIN, nameof(ShortTermVolume3Min));
        public static TickType ShortTermVolume5Min    = new TickType(IBTick.SHORT_TERM_VOLUME_5_MIN, nameof(ShortTermVolume5Min));
        public static TickType ShortTermVolume10Min   = new TickType(IBTick.SHORT_TERM_VOLUME_10_MIN, nameof(ShortTermVolume10Min));
        public static TickType DelayedBid             = new TickType(IBTick.DELAYED_BID, nameof(DelayedBid));
        public static TickType DelayedAsk             = new TickType(IBTick.DELAYED_ASK, nameof(DelayedAsk));
        public static TickType DelayedLast            = new TickType(IBTick.DELAYED_LAST, nameof(DelayedLast));
        public static TickType DelayedBidSize         = new TickType(IBTick.DELAYED_BID_SIZE, nameof(DelayedBidSize));
        public static TickType DelayedAskSize         = new TickType(IBTick.DELAYED_ASK_SIZE, nameof(DelayedAskSize));
        public static TickType DelayedLastSize        = new TickType(IBTick.DELAYED_LAST_SIZE, nameof(DelayedLastSize));
        public static TickType DelayedHigh            = new TickType(IBTick.DELAYED_HIGH, nameof(DelayedHigh));
        public static TickType DelayedLow             = new TickType(IBTick.DELAYED_LOW, nameof(DelayedLow));
        public static TickType DelayedVolume          = new TickType(IBTick.DELAYED_VOLUME, nameof(DelayedVolume));
        public static TickType DelayedClose           = new TickType(IBTick.DELAYED_CLOSE, nameof(DelayedClose));
        public static TickType DelayedOpen            = new TickType(IBTick.DELAYED_OPEN, nameof(DelayedOpen));
        public static TickType RtTrdVolume            = new TickType(IBTick.RT_TRD_VOLUME, nameof(RtTrdVolume));
        public static TickType CreditmanMarkPrice     = new TickType(IBTick.CREDITMAN_MARK_PRICE, nameof(CreditmanMarkPrice));
        public static TickType CreditmanSlowMarkPrice = new TickType(IBTick.CREDITMAN_SLOW_MARK_PRICE, nameof(CreditmanSlowMarkPrice));
        public static TickType DelayedBidOption       = new TickType(IBTick.DELAYED_BID_OPTION, nameof(DelayedBidOption));
        public static TickType DelayedAskOption       = new TickType(IBTick.DELAYED_ASK_OPTION, nameof(DelayedAskOption));
        public static TickType DelayedLastOption      = new TickType(IBTick.DELAYED_LAST_OPTION, nameof(DelayedLastOption));
        public static TickType DelayedModelOption     = new TickType(IBTick.DELAYED_MODEL_OPTION, nameof(DelayedModelOption));
        public static TickType LastExch               = new TickType(IBTick.LAST_EXCH, nameof(LastExch));
        public static TickType LastRegTime            = new TickType(IBTick.LAST_REG_TIME, nameof(LastRegTime));
        public static TickType FuturesOpenInterest    = new TickType(IBTick.FUTURES_OPEN_INTEREST, nameof(FuturesOpenInterest));
        public static TickType AvgOptVolume           = new TickType(IBTick.AVG_OPT_VOLUME, nameof(AvgOptVolume));
        public static TickType DelayedLastTimestamp   = new TickType(IBTick.DELAYED_LAST_TIMESTAMP, nameof(DelayedLastTimestamp));
        public static TickType ShortableShares        = new TickType(IBTick.SHORTABLE_SHARES, nameof(ShortableShares));
        public static TickType DelayedHalted          = new TickType(IBTick.DELAYED_HALTED, nameof(DelayedHalted));
        public static TickType Reuters2MutualFunds    = new TickType(IBTick.REUTERS_2_MUTUAL_FUNDS, nameof(Reuters2MutualFunds));
        public static TickType EtfNavClose            = new TickType(IBTick.ETF_NAV_CLOSE, nameof(EtfNavClose));
        public static TickType EtfNavPriorClose       = new TickType(IBTick.ETF_NAV_PRIOR_CLOSE, nameof(EtfNavPriorClose));
        public static TickType EtfNavBid              = new TickType(IBTick.ETF_NAV_BID, nameof(EtfNavBid));
        public static TickType EtfNavAsk              = new TickType(IBTick.ETF_NAV_ASK, nameof(EtfNavAsk));
        public static TickType EtfNavLast             = new TickType(IBTick.ETF_NAV_LAST, nameof(EtfNavLast));
        public static TickType EtfFrozenNavLast       = new TickType(IBTick.ETF_FROZEN_NAV_LAST, nameof(EtfFrozenNavLast));
        public static TickType EtfNavHigh             = new TickType(IBTick.ETF_NAV_HIGH, nameof(EtfNavHigh));
        public static TickType EtfNavLow              = new TickType(IBTick.ETF_NAV_LOW, nameof(EtfNavLow));

        public TickType(int value, string name) : base(value, name)
        { }

        public string FieldName => IBTick.getField(Value);
    }
}