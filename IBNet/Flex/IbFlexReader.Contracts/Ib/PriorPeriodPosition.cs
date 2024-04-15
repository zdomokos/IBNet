using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib;

using System;
using IbFlexReader.Contracts.Attributes;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class PriorPeriodPosition : SecurityInfo
{
    public string  AccountId    { get; set; }
    public string  AcctAlias    { get; set; }
    public string  Model        { get; set; }
    public double? FxRateToBase { get; set; }
        
    [Format(Constants.DateFormat)]
    public DateTime? Date { get; set; }

    public double? Price       { get; set; }
    public double? PriorMtmPnl { get; set; }
}