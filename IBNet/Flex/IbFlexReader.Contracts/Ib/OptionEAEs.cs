using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class OptionEAEs
    {
        [TypeConverter(typeof(ListCountConverter))] public List<OptionEAE> OptionEAE { get; set; }
        
        public override string ToString() { return $"Count: {OptionEAE?.Count}"; }
    }
}
