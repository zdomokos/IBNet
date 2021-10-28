using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CashTransactions
    {
        public List<CashTransaction> CashTransaction { get; set; }
    }
}