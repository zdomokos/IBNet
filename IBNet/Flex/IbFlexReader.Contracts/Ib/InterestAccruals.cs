using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class InterestAccruals
{
    [TypeConverter(typeof(ListCountConverter))] public List<InterestAccrualsCurrency> InterestAccrualsCurrency { get; set; }
        
    public override string ToString() { return $"Count: {InterestAccrualsCurrency?.Count}"; }
}