using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class CashTransactions
{
    [TypeConverter(typeof(ListCountConverter))]
    public List<CashTransaction> CashTransaction { get; set; }
        
    public override string ToString() { return $"Count: {CashTransaction?.Count}"; }
}