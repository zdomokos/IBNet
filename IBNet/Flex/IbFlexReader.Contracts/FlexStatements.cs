using System.ComponentModel;

namespace IbFlexReader.Contracts
{
    using System.Collections.Generic;
    using IbFlexReader.Contracts.Ib;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FlexStatements
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public List<FlexStatement> FlexStatement { get; set; }

        public int? Count { get; set; }
    }
}