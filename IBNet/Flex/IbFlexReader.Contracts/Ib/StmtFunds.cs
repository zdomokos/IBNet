using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StmtFunds
    {
        public List<StatementOfFundsLine> StatementOfFundsLine { get; set; }
    }
}
