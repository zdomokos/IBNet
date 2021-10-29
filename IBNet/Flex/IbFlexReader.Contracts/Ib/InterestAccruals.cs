using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class InterestAccruals
    {
        [TypeConverter(typeof(ListCountConverter))] public List<InterestAccrualsCurrency> InterestAccrualsCurrency { get; set; }
    }
}
