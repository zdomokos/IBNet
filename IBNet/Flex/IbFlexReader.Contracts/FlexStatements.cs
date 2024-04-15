using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts;

using System.Collections.Generic;
using IbFlexReader.Contracts.Ib;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class FlexStatements
{
    [TypeConverter(typeof(ListCountConverter))]
    public List<FlexStatement> FlexStatement { get; set; }

    public int? Count { get; set; }

    public override string ToString() { return $"Count: {FlexStatement?.Count}"; }
}