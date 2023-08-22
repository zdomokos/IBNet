using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class EquitySummaryInBase
    {
        [TypeConverter(typeof(ListCountConverter))]
        public List<EquitySummaryByReportDateInBase> EquitySummaryByReportDateInBase { get; set; }
        
        public override string ToString() { return $"Count: {EquitySummaryByReportDateInBase?.Count}"; }
    }
}
