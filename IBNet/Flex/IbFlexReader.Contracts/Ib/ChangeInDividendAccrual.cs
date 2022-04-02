using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ChangeInDividendAccrual : SecurityInfo
    {
        public string         AccountId                 { get; set; }
        public string         AcctAlias                 { get; set; }
        public string         Model                     { get; set; }
        public double?        FxRateToBase              { get; set; }

        //Note: The reportDate XML attribute may contain either a date or a string, i.e. reportDate="MULTI"
        public string ReportDate { get; set; }

        [Format(Constants.DateFormat)]
        public DateTime? Date { get; set; }

        public string  ExDate        { get; set; }
        public string  PayDate       { get; set; }
        public double? Quantity      { get; set; }
        public double? Tax           { get; set; }
        public double? Fee           { get; set; }
        public double? GrossRate     { get; set; }
        public double? GrossAmount   { get; set; }
        public double? NetAmount     { get; set; }
        public string  FromAcct      { get; set; }
        public string  ToAcct        { get; set; }
        public string  LevelOfDetail { get; set; }
    }
}
