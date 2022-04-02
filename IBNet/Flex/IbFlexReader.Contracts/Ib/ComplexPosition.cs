using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ComplexPosition : SecurityInfo
    {
        public string  AccountId     { get; set; }
        public string  AcctAlias     { get; set; }
        public string  LevelOfDetail { get; set; }
        public double? Quantity      { get; set; }
        public double? MtmPnl        { get; set; }
        public double? Value         { get; set; }
        public double? ClosePrice    { get; set; }
    }
}
