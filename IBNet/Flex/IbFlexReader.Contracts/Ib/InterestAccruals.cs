using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class InterestAccruals
    {
        public List<InterestAccrualsCurrency> InterestAccrualsCurrency { get; set; }
    }
}
