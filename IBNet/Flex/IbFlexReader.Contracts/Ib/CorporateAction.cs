using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib;

using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class CorporateAction : SecurityInfo
{
    public string AccountId         { get; set; }
    public string AcctAlias         { get; set; }
    public string Model             { get; set; }
    public string FxRateToBase      { get; set; }
    public string ReportDate        { get; set; }
    public string DateTime          { get; set; }
    public string ActionDescription { get; set; }
    public string Amount            { get; set; }
    public string Proceeds          { get; set; }
    public string Value             { get; set; }
    public string Quantity          { get; set; }
    public string FifoPnlRealized   { get; set; }
    public string MtmPnl            { get; set; }
    public string Type              { get; set; }
    public string TransactionID     { get; set; }
    public string LevelOfDetail     { get; set; }
}