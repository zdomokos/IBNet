using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SLBFees
    {
        public List<SLBFee> SLBFee { get; set; }
    }
}
