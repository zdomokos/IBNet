using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SLBActivities
    {
        public List<SLBActivity> SLBActivity { get; set; }
    }
}