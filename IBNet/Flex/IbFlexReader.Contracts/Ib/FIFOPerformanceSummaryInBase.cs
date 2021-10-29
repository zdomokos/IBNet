using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FIFOPerformanceSummaryInBase
    {
        [TypeConverter(typeof(ListCountConverter))]
        public List<FIFOPerformanceSummaryUnderlying> FIFOPerformanceSummaryUnderlying { get; set; }
    }
}
