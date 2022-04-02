using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using IbFlexReader.Contracts.Enums;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ConversionRate
    {
        //Note: The reportDate XML attribute may contain either a date or a string, i.e. reportDate="MULTI"
        public string     ReportDate   { get; set; }
        public Currencies FromCurrency { get; set; }
        public Currencies ToCurrency   { get; set; }
        public double     Rate         { get; set; }
    }
}
