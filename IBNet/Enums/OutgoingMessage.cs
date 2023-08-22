using System;
using System.ComponentModel;
using Ztg.Common.DataStructures.Enums;

namespace IBNet.Enums
{
    /// <summary>
    /// Outgoing Message Ids
    /// </summary>
    [Serializable]
    public class OutgoingMessage : Enumeration<OutgoingMessage, string>
    {
        public static OutgoingMessage Undefined                    = new OutgoingMessage("", nameof(Undefined));
        public static OutgoingMessage RequestMarketData            = new OutgoingMessage("REQ_MKT_DATA", nameof(RequestMarketData));
        public static OutgoingMessage CancelMarketData             = new OutgoingMessage("CANCEL_MKT_DATA", nameof(CancelMarketData));
        public static OutgoingMessage PlaceOrder                   = new OutgoingMessage("PLACE_ORDER", nameof(PlaceOrder));
        public static OutgoingMessage CancelOrder                  = new OutgoingMessage("CANCEL_ORDER", nameof(CancelOrder));
        public static OutgoingMessage RequestOpenOrders            = new OutgoingMessage("REQ_OPEN_ORDERS", nameof(RequestOpenOrders));
        public static OutgoingMessage RequestAccountData           = new OutgoingMessage("REQ_ACCOUNT_DATA", nameof(RequestAccountData));
        public static OutgoingMessage RequestExecutions            = new OutgoingMessage("REQ_EXECUTIONS", nameof(RequestExecutions));
        public static OutgoingMessage RequestIds                   = new OutgoingMessage("REQ_IDS", nameof(RequestIds));
        public static OutgoingMessage RequestContractData          = new OutgoingMessage("REQ_CONTRACT_DATA", nameof(RequestContractData));
        public static OutgoingMessage RequestMarketDepth           = new OutgoingMessage("REQ_MKT_DEPTH", nameof(RequestMarketDepth));
        public static OutgoingMessage CancelMarketDepth            = new OutgoingMessage("CANCEL_MKT_DEPTH", nameof(CancelMarketDepth));
        public static OutgoingMessage RequestNewsBulletins         = new OutgoingMessage("REQ_NEWS_BULLETINS", nameof(RequestNewsBulletins));
        public static OutgoingMessage CancelNewsBulletins          = new OutgoingMessage("CANCEL_NEWS_BULLETINS", nameof(CancelNewsBulletins));
        public static OutgoingMessage SetServerLogLevel            = new OutgoingMessage("SET_SERVER_LOGLEVEL", nameof(SetServerLogLevel));
        public static OutgoingMessage RequestAutoOpenOrders        = new OutgoingMessage("REQ_AUTO_OPEN_ORDERS", nameof(RequestAutoOpenOrders));
        public static OutgoingMessage RequestAllOpenOrders         = new OutgoingMessage("REQ_ALL_OPEN_ORDERS", nameof(RequestAllOpenOrders));
        public static OutgoingMessage RequestManagedAccounts       = new OutgoingMessage("REQ_MANAGED_ACCTS", nameof(RequestManagedAccounts));
        public static OutgoingMessage RequestFA                    = new OutgoingMessage("REQ_FA", nameof(RequestFA));
        public static OutgoingMessage ReplaceFA                    = new OutgoingMessage("REPLACE_FA", nameof(ReplaceFA));
        public static OutgoingMessage RequestHistoricalData        = new OutgoingMessage("REQ_HISTORICAL_DATA", nameof(RequestHistoricalData));
        public static OutgoingMessage ExerciseOptions              = new OutgoingMessage("EXERCISE_OPTIONS", nameof(ExerciseOptions));
        public static OutgoingMessage RequestScannerSubscription   = new OutgoingMessage("REQ_SCANNER_SUBSCRIPTION", nameof(RequestScannerSubscription));
        public static OutgoingMessage CancelScannerSubscription    = new OutgoingMessage("CANCEL_SCANNER_SUBSCRIPTION", nameof(CancelScannerSubscription));
        public static OutgoingMessage RequestScannerParameters     = new OutgoingMessage("REQ_SCANNER_PARAMETERS", nameof(RequestScannerParameters));
        public static OutgoingMessage CancelHistoricalData         = new OutgoingMessage("CANCEL_HISTORICAL_DATA", nameof(CancelHistoricalData));
        public static OutgoingMessage RequestCurrentTime           = new OutgoingMessage("REQ_CURRENT_TIME", nameof(RequestCurrentTime));
        public static OutgoingMessage RequestRealTimeBars          = new OutgoingMessage("REQ_REAL_TIME_BARS", nameof(RequestRealTimeBars));
        public static OutgoingMessage CancelRealTimeBars           = new OutgoingMessage("CANCEL_REAL_TIME_BARS", nameof(CancelRealTimeBars));
        public static OutgoingMessage RequestFundamentalData       = new OutgoingMessage("REQ_FUNDAMENTAL_DATA", nameof(RequestFundamentalData));
        public static OutgoingMessage CancelFundamentalData        = new OutgoingMessage("CANCEL_FUNDAMENTAL_DATA", nameof(CancelFundamentalData));
        public static OutgoingMessage RequestCalcImpliedVolatility = new OutgoingMessage("REQ_CALC_IMPLIED_VOLAT", nameof(RequestCalcImpliedVolatility));
        public static OutgoingMessage RequestCalcOptionPrice       = new OutgoingMessage("REQ_CALC_OPTION_PRICE", nameof(RequestCalcOptionPrice));
        public static OutgoingMessage CancelCalcImpliedVolatility  = new OutgoingMessage("CANCEL_CALC_IMPLIED_VOLAT", nameof(CancelCalcImpliedVolatility));
        public static OutgoingMessage CancelCalcOptionPrice        = new OutgoingMessage("CANCEL_CALC_OPTION_PRICE", nameof(CancelCalcOptionPrice));
        public static OutgoingMessage RequestGlobalCancel          = new OutgoingMessage("REQ_GLOBAL_CANCEL", nameof(RequestGlobalCancel));
        public static OutgoingMessage RequestMarketDataType        = new OutgoingMessage("REQ_MARKET_DATA_TYPE", nameof(RequestMarketDataType));

        public OutgoingMessage(string value, string name) : base(value, name)
        { }
    }
}
