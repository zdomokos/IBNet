using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class OpenPositions
    {
        public List<OpenPosition> OpenPosition { get; set; }
    }
}