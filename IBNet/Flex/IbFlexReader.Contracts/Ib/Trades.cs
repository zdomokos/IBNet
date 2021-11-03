using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Trades
    {
        [TypeConverter(typeof(ListCountConverter))] public List<Lot>           Lot           { get; set; }
        [TypeConverter(typeof(ListCountConverter))] public List<Trade>         Trade         { get; set; }
        [TypeConverter(typeof(ListCountConverter))] public List<AssetSummary>  AssetSummary  { get; set; }
        [TypeConverter(typeof(ListCountConverter))] public List<SymbolSummary> SymbolSummary { get; set; }
        [TypeConverter(typeof(ListCountConverter))] public List<Order>         Order         { get; set; }
        [TypeConverter(typeof(ListCountConverter))] public List<WashSale>      WashSale      { get; set; }
        
        public override string ToString() { return $"Count: {Lot?.Count},{Trade?.Count},{AssetSummary?.Count},{SymbolSummary?.Count},{Order?.Count},{WashSale?.Count}"; }
    }
}