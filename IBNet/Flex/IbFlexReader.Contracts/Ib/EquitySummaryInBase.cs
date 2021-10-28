using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class EquitySummaryInBase
    {
        public List<EquitySummaryByReportDateInBase> EquitySummaryByReportDateInBase { get; set; }
    }
}