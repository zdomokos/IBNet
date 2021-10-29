using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CorporateActions
    {
        [TypeConverter(typeof(ListCountConverter))]
        public List<CorporateAction> CorporateAction { get; set; }
    }
}
