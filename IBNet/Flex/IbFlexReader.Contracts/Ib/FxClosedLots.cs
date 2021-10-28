using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FxClosedLots
    {
        public List<FxClosedLot> FxClosedLot { get; set; }
    }
}