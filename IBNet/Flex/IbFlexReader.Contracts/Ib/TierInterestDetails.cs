using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class TierInterestDetails
    {
        public List<TierInterestDetail> TierInterestDetail { get; set; }
    }
}
