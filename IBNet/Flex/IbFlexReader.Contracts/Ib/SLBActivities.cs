using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SLBActivities
    {
        [TypeConverter(typeof(ListCountConverter))] public List<SLBActivity> SLBActivity { get; set; }
    }
}