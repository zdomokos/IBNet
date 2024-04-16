using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class FifoPerformanceSummaryInBase
{
    [TypeConverter(typeof(ListCountConverter))]
    public List<FifoPerformanceSummaryUnderlying> FifoPerformanceSummaryUnderlying { get; set; }

    public override string ToString()
    {
        return $"Count: {FifoPerformanceSummaryUnderlying?.Count}";
    }
}