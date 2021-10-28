using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ChangeInDividendAccruals
    {
        public List<ChangeInDividendAccrual> ChangeInDividendAccrual { get; set; }
    }
}