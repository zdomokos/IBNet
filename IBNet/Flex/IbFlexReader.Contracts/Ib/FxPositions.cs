using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class FxPositions
{
    [TypeConverter(typeof(ListCountConverter))] public List<FxPosition> FxPosition { get; set; }
    public                                             FxLots           FxLots     { get; set; }
        
    public override string ToString() { return $"Count: {FxPosition?.Count}"; }
}