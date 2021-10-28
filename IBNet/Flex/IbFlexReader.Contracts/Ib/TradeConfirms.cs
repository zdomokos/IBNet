using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class TradeConfirms
    {
        public List<TradeConfirm> TradeConfirm { get; set; }
    }
}