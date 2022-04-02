using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Transfer : SecurityInfo
    {
        public string         AccountId                 { get; set; }
        public string         AcctAlias                 { get; set; }
        public string         Model                     { get; set; }
        public double?        FxRateToBase              { get; set; }
        
        //Note: The reportDate XML attribute may contain either a date or a string, i.e. reportDate="MULTI"
        public string ReportDate { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? Date { get; set; }

        [Format(Constants.DateTimeFormat, 0)]
        // alternative format
        [Format(Constants.DateFormat, 1)]
        public DateTime? TradeDateTime { get; set; }

        public string  Type                 { get; set; }
        public string  Direction            { get; set; }
        public string  Company              { get; set; }
        public string  Account              { get; set; }
        public string  AccountName          { get; set; }
        public double? Quantity             { get; set; }
        public double? TransferPrice        { get; set; }
        public double? PositionAmount       { get; set; }
        public double? PositionAmountInBase { get; set; }
        public double? PnlAmount            { get; set; }
        public double? PnlAmountInBase      { get; set; }
        public double? FxPnl                { get; set; }
        public double? CashTransfer         { get; set; }
        public string  ClientReference      { get; set; }
        public long?   TransactionID        { get; set; }
    }
}
