using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class TransactionTaxes
    {
        [TypeConverter(typeof(ListCountConverter))] public List<TransactionTax> TransactionTax { get; set; }
    }
}
