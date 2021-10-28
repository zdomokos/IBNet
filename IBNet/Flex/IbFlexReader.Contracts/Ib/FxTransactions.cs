using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FxTransactions
    {
        public List<FxTransaction> FxTransaction { get; set; }
        public List<FxClosedLots>  FxClosedLots  { get; set; }
    }
}
