using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class ChangeInDividendAccruals
{
    [TypeConverter(typeof(ListCountConverter))]
    public List<ChangeInDividendAccrual> ChangeInDividendAccrual { get; set; }
        
    public override string ToString() { return $"Count: {ChangeInDividendAccrual?.Count}"; }
}