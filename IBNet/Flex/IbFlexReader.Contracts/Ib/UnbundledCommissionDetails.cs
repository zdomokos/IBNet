using System.ComponentModel;
using IBNet.Utils;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class UnbundledCommissionDetails
{
    [TypeConverter(typeof(ListCountConverter))] public List<UnbundledCommissionDetail> UnbundledCommissionDetail { get; set; }
        
    public override string ToString() { return $"Count: {UnbundledCommissionDetail?.Count}"; }
}