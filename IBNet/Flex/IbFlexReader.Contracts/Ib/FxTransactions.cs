using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FxTransactions
    {
        [TypeConverter(typeof(ListCountConverter))] public List<FxTransaction> FxTransaction { get; set; }
        [TypeConverter(typeof(ListCountConverter))] public List<FxClosedLots>  FxClosedLots  { get; set; }
        
        public override string ToString() { return $"Count: {FxTransaction?.Count},{FxClosedLots?.Count}"; }
    }
}
