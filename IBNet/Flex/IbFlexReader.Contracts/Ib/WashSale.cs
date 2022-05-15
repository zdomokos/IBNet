using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class WashSale : SecurityInfo
    {
        public string AccountId                 { get; set; }
        public string AcctAlias                 { get; set; }
        public string Model                     { get; set; }
        public string FxRateToBase              { get; set; }
        public string TradeID                   { get; set; }
        public string ReportDate                { get; set; }
        public string DateTime                  { get; set; }
        public string TradeDate                 { get; set; }
        public string SettleDateTarget          { get; set; }
        public string TransactionType           { get; set; }
        public string Exchange                  { get; set; }
        public string Quantity                  { get; set; }
        public string TradePrice                { get; set; }
        public string TradeMoney                { get; set; }
        public string Proceeds                  { get; set; }
        public string Taxes                     { get; set; }
        public string IbCommission              { get; set; }
        public string IbCommissionCurrency      { get; set; }
        public string NetCash                   { get; set; }
        public string ClosePrice                { get; set; }
        public string OpenCloseIndicator        { get; set; }
        public string Notes                     { get; set; }
        public string Cost                      { get; set; }
        public string FifoPnlRealized           { get; set; }
        public string FxPnl                     { get; set; }
        public string MtmPnl                    { get; set; }
        public string OrigTradePrice            { get; set; }
        public string OrigTradeDate             { get; set; }
        public string OrigTradeID               { get; set; }
        public string OrigOrderID               { get; set; }
        public string ClearingFirmID            { get; set; }
        public string TransactionID             { get; set; }
        public string BuySell                   { get; set; }
        public string IbOrderID                 { get; set; }
        public string IbExecID                  { get; set; }
        public string BrokerageOrderID          { get; set; }
        public string OrderReference            { get; set; }
        public string VolatilityOrderLink       { get; set; }
        public string ExchOrderId               { get; set; }
        public string ExtExecID                 { get; set; }
        public string OrderTime                 { get; set; }
        public string OpenDateTime              { get; set; }
        public string HoldingPeriodDateTime     { get; set; }
        public string WhenRealized              { get; set; }
        public string WhenReopened              { get; set; }
        public string LevelOfDetail             { get; set; }
        public string ChangeInPrice             { get; set; }
        public string ChangeInQuantity          { get; set; }
        public string OrderType                 { get; set; }
        public string TraderID                  { get; set; }
        public string IsAPIOrder                { get; set; }
        public string AccruedInt                { get; set; }
    }
}
