using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class StmtFunds
{
    [TypeConverter(typeof(ListCountConverter))]
    public List<StatementOfFundsLine> StatementOfFundsLine { get; set; }

    public override string ToString()
    {
        return $"Count: {StatementOfFundsLine?.Count}";
    }
}