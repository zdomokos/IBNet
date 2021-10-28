using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ComplexPositions
    {
        public List<ComplexPosition> ComplexPosition { get; set; }
    }
}
