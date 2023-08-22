using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FxClosedLots
    {
        [TypeConverter(typeof(ListCountConverter))] public List<FxClosedLot> FxClosedLot { get; set; }
        
        public override string ToString() { return $"Count: {FxClosedLot?.Count}"; }
    }
}
