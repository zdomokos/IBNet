using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SecuritiesInfo
    {
        [TypeConverter(typeof(ListCountConverter))] public List<SecurityInfo> SecurityInfo { get; set; }
        
        public override string ToString() { return $"Count: {SecurityInfo?.Count}"; }
    }
}