using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Outgoing Message Ids
/// </summary>
[Serializable]
public class OutgoingMessage : Enumeration<OutgoingMessage, string>
{
    public static OutgoingMessage Undefined                    = new("", nameof(Undefined));
    public static OutgoingMessage RequestMarketData            = new("REQ_MKT_DATA", nameof(RequestMarketData));
    public static OutgoingMessage CancelMarketData             = new("CANCEL_MKT_DATA", nameof(CancelMarketData));
    public static OutgoingMessage PlaceOrder                   = new("PLACE_ORDER", nameof(PlaceOrder));
    public static OutgoingMessage CancelOrder                  = new("CANCEL_ORDER", nameof(CancelOrder));
    public static OutgoingMessage RequestOpenOrders            = new("REQ_OPEN_ORDERS", nameof(RequestOpenOrders));
    public static OutgoingMessage RequestAccountData           = new("REQ_ACCOUNT_DATA", nameof(RequestAccountData));
    public static OutgoingMessage RequestExecutions            = new("REQ_EXECUTIONS", nameof(RequestExecutions));
    public static OutgoingMessage RequestIds                   = new("REQ_IDS", nameof(RequestIds));
    public static OutgoingMessage RequestContractData          = new("REQ_CONTRACT_DATA", nameof(RequestContractData));
    public static OutgoingMessage RequestMarketDepth           = new("REQ_MKT_DEPTH", nameof(RequestMarketDepth));
    public static OutgoingMessage CancelMarketDepth            = new("CANCEL_MKT_DEPTH", nameof(CancelMarketDepth));
    public static OutgoingMessage RequestNewsBulletins         = new("REQ_NEWS_BULLETINS", nameof(RequestNewsBulletins));
    public static OutgoingMessage CancelNewsBulletins          = new("CANCEL_NEWS_BULLETINS", nameof(CancelNewsBulletins));
    public static OutgoingMessage SetServerLogLevel            = new("SET_SERVER_LOGLEVEL", nameof(SetServerLogLevel));
    public static OutgoingMessage RequestAutoOpenOrders        = new("REQ_AUTO_OPEN_ORDERS", nameof(RequestAutoOpenOrders));
    public static OutgoingMessage RequestAllOpenOrders         = new("REQ_ALL_OPEN_ORDERS", nameof(RequestAllOpenOrders));
    public static OutgoingMessage RequestManagedAccounts       = new("REQ_MANAGED_ACCTS", nameof(RequestManagedAccounts));
    public static OutgoingMessage RequestFA                    = new("REQ_FA", nameof(RequestFA));
    public static OutgoingMessage ReplaceFA                    = new("REPLACE_FA", nameof(ReplaceFA));
    public static OutgoingMessage RequestHistoricalData        = new("REQ_HISTORICAL_DATA", nameof(RequestHistoricalData));
    public static OutgoingMessage ExerciseOptions              = new("EXERCISE_OPTIONS", nameof(ExerciseOptions));
    public static OutgoingMessage RequestScannerSubscription   = new("REQ_SCANNER_SUBSCRIPTION", nameof(RequestScannerSubscription));
    public static OutgoingMessage CancelScannerSubscription    = new("CANCEL_SCANNER_SUBSCRIPTION", nameof(CancelScannerSubscription));
    public static OutgoingMessage RequestScannerParameters     = new("REQ_SCANNER_PARAMETERS", nameof(RequestScannerParameters));
    public static OutgoingMessage CancelHistoricalData         = new("CANCEL_HISTORICAL_DATA", nameof(CancelHistoricalData));
    public static OutgoingMessage RequestCurrentTime           = new("REQ_CURRENT_TIME", nameof(RequestCurrentTime));
    public static OutgoingMessage RequestRealTimeBars          = new("REQ_REAL_TIME_BARS", nameof(RequestRealTimeBars));
    public static OutgoingMessage CancelRealTimeBars           = new("CANCEL_REAL_TIME_BARS", nameof(CancelRealTimeBars));
    public static OutgoingMessage RequestFundamentalData       = new("REQ_FUNDAMENTAL_DATA", nameof(RequestFundamentalData));
    public static OutgoingMessage CancelFundamentalData        = new("CANCEL_FUNDAMENTAL_DATA", nameof(CancelFundamentalData));
    public static OutgoingMessage RequestCalcImpliedVolatility = new("REQ_CALC_IMPLIED_VOLAT", nameof(RequestCalcImpliedVolatility));
    public static OutgoingMessage RequestCalcOptionPrice       = new("REQ_CALC_OPTION_PRICE", nameof(RequestCalcOptionPrice));
    public static OutgoingMessage CancelCalcImpliedVolatility  = new("CANCEL_CALC_IMPLIED_VOLAT", nameof(CancelCalcImpliedVolatility));
    public static OutgoingMessage CancelCalcOptionPrice        = new("CANCEL_CALC_OPTION_PRICE", nameof(CancelCalcOptionPrice));
    public static OutgoingMessage RequestGlobalCancel          = new("REQ_GLOBAL_CANCEL", nameof(RequestGlobalCancel));
    public static OutgoingMessage RequestMarketDataType        = new("REQ_MARKET_DATA_TYPE", nameof(RequestMarketDataType));

    public OutgoingMessage(string value, string name) : base(value, name)
    { }
}