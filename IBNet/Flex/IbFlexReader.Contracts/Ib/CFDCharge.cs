using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib;

using System;
using IbFlexReader.Contracts.Attributes;
using IbFlexReader.Contracts.Enums;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFDCharge : SecurityInfo
{
    public string  AccountId    { get; set; }
    public string  AcctAlias    { get; set; }
    public string  Model        { get; set; }
    public double? FxRateToBase { get; set; }

    [Format(Constants.DateFormat)]
    public DateTime? Date { get; set; }

    public double? Received      { get; set; }
    public double? Paid          { get; set; }
    public double? Total         { get; set; }
    public string  TransactionID { get; set; }
}