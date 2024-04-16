namespace IbFlexReader.Xml.Contracts.QueryResponse;

using System.Xml.Serialization;

[XmlRoot(ElementName = "FifoPerformanceSummaryUnderlying")]
public class FifoPerformanceSummaryUnderlying
{
    [XmlAttribute(AttributeName = "accountId")]
    public string AccountId { get; set; }

    [XmlAttribute(AttributeName = "acctAlias")]
    public string AcctAlias { get; set; }

    [XmlAttribute(AttributeName = "model")]
    public string Model { get; set; }

    [XmlAttribute(AttributeName = "assetCategory")]
    public string AssetCategory { get; set; }

    [XmlAttribute(AttributeName = "symbol")]
    public string Symbol { get; set; }

    [XmlAttribute(AttributeName = "description")]
    public string Description { get; set; }

    [XmlAttribute(AttributeName = "conid")]
    public string Conid { get; set; }

    [XmlAttribute(AttributeName = "securityID")]
    public string SecurityID { get; set; }

    [XmlAttribute(AttributeName = "securityIDType")]
    public string SecurityIDType { get; set; }

    [XmlAttribute(AttributeName = "cusip")]
    public string Cusip { get; set; }

    [XmlAttribute(AttributeName = "isin")] public string Isin { get; set; }

    [XmlAttribute(AttributeName = "listingExchange")]
    public string ListingExchange { get; set; }

    [XmlAttribute(AttributeName = "underlyingConid")]
    public string UnderlyingConid { get; set; }

    [XmlAttribute(AttributeName = "underlyingSymbol")]
    public string UnderlyingSymbol { get; set; }

    [XmlAttribute(AttributeName = "underlyingSecurityID")]
    public string UnderlyingSecurityID { get; set; }

    [XmlAttribute(AttributeName = "underlyingListingExchange")]
    public string UnderlyingListingExchange { get; set; }

    [XmlAttribute(AttributeName = "issuer")]
    public string Issuer { get; set; }

    [XmlAttribute(AttributeName = "multiplier")]
    public string Multiplier { get; set; }

    [XmlAttribute(AttributeName = "strike")]
    public string Strike { get; set; }

    [XmlAttribute(AttributeName = "expiry")]
    public string Expiry { get; set; }

    [XmlAttribute(AttributeName = "putCall")]
    public string PutCall { get; set; }

    [XmlAttribute(AttributeName = "principalAdjustFactor")]
    public string PrincipalAdjustFactor { get; set; }

    [XmlAttribute(AttributeName = "serialNumber")]
    public string SerialNumber { get; set; }

    [XmlAttribute(AttributeName = "deliveryType")]
    public string DeliveryType { get; set; }

    [XmlAttribute(AttributeName = "commodityType")]
    public string CommodityType { get; set; }

    [XmlAttribute(AttributeName = "fineness")]
    public string Fineness { get; set; }

    [XmlAttribute(AttributeName = "weight")]
    public string Weight { get; set; }

    [XmlAttribute(AttributeName = "reportDate")]
    public string ReportDate { get; set; }

    [XmlAttribute(AttributeName = "costAdj")]
    public string CostAdj { get; set; }

    [XmlAttribute(AttributeName = "realizedSTProfit")]
    public string RealizedSTProfit { get; set; }

    [XmlAttribute(AttributeName = "realizedSTLoss")]
    public string RealizedSTLoss { get; set; }

    [XmlAttribute(AttributeName = "realizedLTProfit")]
    public string RealizedLTProfit { get; set; }

    [XmlAttribute(AttributeName = "realizedLTLoss")]
    public string RealizedLTLoss { get; set; }

    [XmlAttribute(AttributeName = "totalRealizedPnl")]
    public string TotalRealizedPnl { get; set; }

    [XmlAttribute(AttributeName = "unrealizedProfit")]
    public string UnrealizedProfit { get; set; }

    [XmlAttribute(AttributeName = "unrealizedLoss")]
    public string UnrealizedLoss { get; set; }

    [XmlAttribute(AttributeName = "unrealizedSTProfit")]
    public string UnrealizedSTProfit { get; set; }

    [XmlAttribute(AttributeName = "unrealizedSTLoss")]
    public string UnrealizedSTLoss { get; set; }

    [XmlAttribute(AttributeName = "unrealizedLTProfit")]
    public string UnrealizedLTProfit { get; set; }

    [XmlAttribute(AttributeName = "unrealizedLTLoss")]
    public string UnrealizedLTLoss { get; set; }

    [XmlAttribute(AttributeName = "totalUnrealizedPnl")]
    public string TotalUnrealizedPnl { get; set; }

    [XmlAttribute(AttributeName = "totalFifoPnl")]
    public string TotalFifoPnl { get; set; }

    [XmlAttribute(AttributeName = "transferredPnl")]
    public string TransferredPnl { get; set; }

    [XmlAttribute(AttributeName = "code")] public string Code { get; set; }
}