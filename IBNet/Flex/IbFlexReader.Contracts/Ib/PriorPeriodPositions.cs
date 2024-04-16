using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class PriorPeriodPositions
{
    [TypeConverter(typeof(ListCountConverter))]
    public List<PriorPeriodPosition> PriorPeriodPosition { get; set; }

    public override string ToString()
    {
        return $"Count: {PriorPeriodPosition?.Count}";
    }
}