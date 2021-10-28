using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SecuritiesInfo
    {
        public List<SecurityInfo> SecurityInfo { get; set; }
    }
}