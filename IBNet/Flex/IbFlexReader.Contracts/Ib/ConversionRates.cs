using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ConversionRates
    {
        public List<ConversionRate> ConversionRate { get; set; }
    }
}