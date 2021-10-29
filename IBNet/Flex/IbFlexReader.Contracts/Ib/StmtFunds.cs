using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StmtFunds
    {
        [TypeConverter(typeof(ListCountConverter))] public List<StatementOfFundsLine> StatementOfFundsLine { get; set; }
    }
}
