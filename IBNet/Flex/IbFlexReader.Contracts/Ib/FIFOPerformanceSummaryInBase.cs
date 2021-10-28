using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FIFOPerformanceSummaryInBase
    {
        public List<FIFOPerformanceSummaryUnderlying> FIFOPerformanceSummaryUnderlying { get; set; }
    }
}
