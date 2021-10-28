using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class OptionEAEs
    {
        public List<OptionEAE> OptionEAE { get; set; }
    }
}
