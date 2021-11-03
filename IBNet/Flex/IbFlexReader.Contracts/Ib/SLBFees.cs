using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SLBFees
    {
        [TypeConverter(typeof(ListCountConverter))] public List<SLBFee> SLBFee { get; set; }
        
        public override string ToString() { return $"Count: {SLBFee?.Count}"; }
    }
}
