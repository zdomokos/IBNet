using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CorporateActions
    {
        public List<CorporateAction> CorporateAction { get; set; }
    }
}
