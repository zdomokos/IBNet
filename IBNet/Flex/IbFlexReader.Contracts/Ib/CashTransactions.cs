using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CashTransactions
    {
        [TypeConverter(typeof(ListCountConverter))]
        public List<CashTransaction> CashTransaction { get; set; }
    }
}