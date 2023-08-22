using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class OpenPositions
    {
        [TypeConverter(typeof(ListCountConverter))] 
        public List<OpenPosition> OpenPosition { get; set; }
        
        public override string ToString() { return $"Count: {OpenPosition?.Count}"; }
    }
}
