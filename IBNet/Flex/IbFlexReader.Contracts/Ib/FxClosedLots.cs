using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class FxClosedLots
{
    [TypeConverter(typeof(ListCountConverter))]
    public List<FxClosedLot> FxClosedLot { get; set; }

    public override string ToString()
    {
        return $"Count: {FxClosedLot?.Count}";
    }
}