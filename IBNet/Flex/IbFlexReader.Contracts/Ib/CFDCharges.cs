using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CFDCharges
    {
        public List<CFDCharge> CFDCharge { get; set; }
    }
}