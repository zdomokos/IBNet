using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SymbolSummary : Trade
    {
    }
}
