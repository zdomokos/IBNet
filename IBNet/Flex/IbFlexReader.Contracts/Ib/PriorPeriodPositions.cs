using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class PriorPeriodPositions
    {
        [TypeConverter(typeof(ListCountConverter))] public List<PriorPeriodPosition> PriorPeriodPosition { get; set; }
    }
}