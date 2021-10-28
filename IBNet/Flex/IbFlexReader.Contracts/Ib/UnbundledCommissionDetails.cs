using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class UnbundledCommissionDetails
    {
        public List<UnbundledCommissionDetail> UnbundledCommissionDetail { get; set; }
    }
}
