using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class TradeConfirms
{
    [TypeConverter(typeof(ListCountConverter))] public List<TradeConfirm>  TradeConfirm  { get; set; }
    [TypeConverter(typeof(ListCountConverter))] public List<SymbolSummary> SymbolSummary { get; set; }
        
    public override string ToString() { return $"Count: {TradeConfirm?.Count},{SymbolSummary?.Count}"; }
}