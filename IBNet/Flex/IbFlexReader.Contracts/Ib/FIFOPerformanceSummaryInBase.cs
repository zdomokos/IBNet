using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FIFOPerformanceSummaryInBase
    {
        [TypeConverter(typeof(ListCountConverter))]
        public List<FIFOPerformanceSummaryUnderlying> FIFOPerformanceSummaryUnderlying { get; set; }
        
        public override string ToString() { return $"Count: {FIFOPerformanceSummaryUnderlying?.Count}"; }
    }
}
