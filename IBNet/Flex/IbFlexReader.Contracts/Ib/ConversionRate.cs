namespace IbFlexReader.Contracts.Ib
{
    using IbFlexReader.Contracts.Enums;

    public class ConversionRate
    {
        //Note: The reportDate XML attribute may contain either a date or a string, i.e. reportDate="MULTI"
        public string ReportDate { get; set; }

        public string FromCurrency { get; set; }

        public string ToCurrency { get; set; }

        public string Rate { get; set; }
    }
}