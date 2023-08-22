using System.Collections.Generic;
using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class OpenDividendAccruals
    {
        [TypeConverter(typeof(ListCountConverter))]
        public List<OpenDividendAccrual> OpenDividendAccrual { get; set; }
        
        public override string ToString() { return $"Count: {OpenDividendAccrual?.Count}"; }
    }
}
