using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Transfers
    {
        [TypeConverter(typeof(ListCountConverter))] public List<Transfer> Transfer { get; set; }
        
        public override string ToString() { return $"Count: {Transfer?.Count}"; }
    }
}
