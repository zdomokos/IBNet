using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class ComplexPositions
{
    [TypeConverter(typeof(ListCountConverter))]
    public List<ComplexPosition> ComplexPosition { get; set; }

    public override string ToString()
    {
        return $"Count: {ComplexPosition?.Count}";
    }
}