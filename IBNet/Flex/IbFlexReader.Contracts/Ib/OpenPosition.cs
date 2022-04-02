using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class OpenPosition : SecurityInfo
    {
        public string         AccountId                 { get; set; }
        public string         AcctAlias                 { get; set; }
        public string         Model                     { get; set; }
        public double?        FxRateToBase              { get; set; }

        //Note: The reportDate XML attribute may contain either a date or a string, i.e. reportDate="MULTI"
        public string     ReportDate        { get; set; }
        public int?       Position          { get; set; }
        public double?    MarkPrice         { get; set; }
        public double?    PositionValue     { get; set; }
        public double?    OpenPrice         { get; set; }
        public double?    CostBasisPrice    { get; set; }
        public double?    CostBasisMoney    { get; set; }
        public double?    PercentOfNAV      { get; set; }
        public double?    FifoPnlUnrealized { get; set; }
        public LongShort? Side              { get; set; }
        public string     LevelOfDetail     { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? OpenDateTime { get; set; }

        [Format(Constants.DateTimeFormat)]
        public DateTime? HoldingPeriodDateTime { get; set; }

        public long?   OriginatingOrderID       { get; set; }
        public long?   OriginatingTransactionID { get; set; }
        public double? AccruedInt               { get; set; }
        public string  VestingDate              { get; set; }
    }
}
