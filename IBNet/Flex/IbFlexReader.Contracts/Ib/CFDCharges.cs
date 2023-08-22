using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CFDCharges
    {
        [TypeConverter(typeof(ListCountConverter))]
        public List<CFDCharge> CFDCharge { get; set; }
        
        public override string ToString() { return $"Count: {CFDCharge?.Count}"; }
    }
}
