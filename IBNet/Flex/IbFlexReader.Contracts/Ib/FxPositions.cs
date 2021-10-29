using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FxPositions
    {
        [TypeConverter(typeof(ListCountConverter))] public List<FxPosition> FxPosition { get; set; }
        public FxLots           FxLots     { get; set; }
    }
}
