using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Order : Trade
{
}