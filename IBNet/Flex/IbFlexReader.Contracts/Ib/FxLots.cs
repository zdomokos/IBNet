using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FxLots
    {
        [TypeConverter(typeof(ListCountConverter))] public List<FxLot> FxLot { get; set; }
    }
}
