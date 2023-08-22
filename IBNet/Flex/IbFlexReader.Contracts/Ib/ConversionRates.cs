using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ConversionRates
    {
        [TypeConverter(typeof(ListCountConverter))]
        public List<ConversionRate> ConversionRate { get; set; }
        
        public override string ToString() { return $"Count: {ConversionRate?.Count}"; }
    }
}
