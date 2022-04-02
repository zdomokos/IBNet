using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CashTransaction : SecurityInfo
    {
        public string         AccountId                 { get; set; }
        public string         AcctAlias                 { get; set; }
        public string         Model                     { get; set; }
        public double?        FxRateToBase              { get; set; }
        
        [Format(Constants.DateFormat), Format(Constants.DateTimeFormat, order: 1)]
        public DateTime? DateTime { get; set; }

        public double?              Amount  { get; set; }
        public CashTransactionType? Type    { get; set; }
        public long?                TradeID { get; set; }

        public long? TransactionID { get; set; }

        //Note: The reportDate XML attribute may contain either a date or a string, i.e. reportDate="MULTI"
        public string ReportDate      { get; set; }
        public string ClientReference { get; set; }

        [Format(Constants.DateFormat)]
        public string SettleDate { get; set; }

        public string LevelOfDetail { get; set; }
    }
}
