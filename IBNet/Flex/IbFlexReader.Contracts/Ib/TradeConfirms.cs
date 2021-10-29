using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class TradeConfirms
    {
        [TypeConverter(typeof(ListCountConverter))] public List<TradeConfirm> TradeConfirm { get; set; }
    }
}