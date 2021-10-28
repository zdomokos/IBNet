using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class TransactionTaxes
    {
        public List<TransactionTax> TransactionTax { get; set; }
    }
}
