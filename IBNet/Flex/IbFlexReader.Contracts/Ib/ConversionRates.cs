using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class ConversionRates
{
    [TypeConverter(typeof(ListCountConverter))]
    public List<ConversionRate> ConversionRate { get; set; }
        
    public override string ToString() { return $"Count: {ConversionRate?.Count}"; }
}