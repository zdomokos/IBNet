#region ZGT
// (c) Copyright 2021 ZTG LLC. All Rights Reserved.
// NOTICE: This file contains source code, ideas, techniques, and information (the Information) which are
// Proprietary and Confidential Information of ZTG LLC. This Information may not be used by or disclosed to any
// third party except under written license, and shall be subject to the limitations prescribed under license.
#endregion

using System.Collections.Generic;
using System.Xml.Serialization;

namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    [XmlRoot(ElementName = "CorporateActions")]
    public class CorporateActions
    {
        [XmlElement(ElementName = "CorporateAction")]
        public List<CorporateAction> CorporateAction { get; set; }
    }
    
    [XmlRoot(ElementName = "CorporateAction")]
    public class CorporateAction
    {
        [XmlAttribute(AttributeName = "accountId")] public string AccountId { get; set; }
        [XmlAttribute(AttributeName = "acctAlias")] public string AcctAlias { get; set; }
        [XmlAttribute(AttributeName = "model")] public string Model { get; set; }
        [XmlAttribute(AttributeName = "currency")] public string Currency { get; set; }
        [XmlAttribute(AttributeName = "fxRateToBase")] public string FxRateToBase { get; set; }
        [XmlAttribute(AttributeName = "assetCategory")] public string AssetCategory { get; set; }
        [XmlAttribute(AttributeName = "symbol")] public string Symbol { get; set; }
        [XmlAttribute(AttributeName = "description")] public string Description { get; set; }
        [XmlAttribute(AttributeName = "conid")] public string Conid { get; set; }
        [XmlAttribute(AttributeName = "securityID")] public string SecurityID { get; set; }
        [XmlAttribute(AttributeName = "securityIDType")] public string SecurityIDType { get; set; }
        [XmlAttribute(AttributeName = "cusip")] public string Cusip { get; set; }
        [XmlAttribute(AttributeName = "isin")] public string Isin { get; set; }
        [XmlAttribute(AttributeName = "listingExchange")] public string ListingExchange { get; set; }
        [XmlAttribute(AttributeName = "underlyingConid")] public string UnderlyingConid { get; set; }
        [XmlAttribute(AttributeName = "underlyingSymbol")] public string UnderlyingSymbol { get; set; }
        [XmlAttribute(AttributeName = "underlyingSecurityID")] public string UnderlyingSecurityID { get; set; }
        [XmlAttribute(AttributeName = "underlyingListingExchange")] public string UnderlyingListingExchange { get; set; }
        [XmlAttribute(AttributeName = "issuer")] public string Issuer { get; set; }
        [XmlAttribute(AttributeName = "multiplier")] public string Multiplier { get; set; }
        [XmlAttribute(AttributeName = "strike")] public string Strike { get; set; }
        [XmlAttribute(AttributeName = "expiry")] public string Expiry { get; set; }
        [XmlAttribute(AttributeName = "putCall")] public string PutCall { get; set; }
        [XmlAttribute(AttributeName = "principalAdjustFactor")] public string PrincipalAdjustFactor { get; set; }
        [XmlAttribute(AttributeName = "serialNumber")] public string SerialNumber { get; set; }
        [XmlAttribute(AttributeName = "deliveryType")] public string DeliveryType { get; set; }
        [XmlAttribute(AttributeName = "commodityType")] public string CommodityType { get; set; }
        [XmlAttribute(AttributeName = "fineness")] public string Fineness { get; set; }
        [XmlAttribute(AttributeName = "weight")] public string Weight { get; set; }
        [XmlAttribute(AttributeName = "reportDate")] public string ReportDate { get; set; }
        [XmlAttribute(AttributeName = "dateTime")] public string DateTime { get; set; }
        [XmlAttribute(AttributeName = "actionDescription")] public string ActionDescription { get; set; }
        [XmlAttribute(AttributeName = "amount")] public string Amount { get; set; }
        [XmlAttribute(AttributeName = "proceeds")] public string Proceeds { get; set; }
        [XmlAttribute(AttributeName = "value")] public string Value { get; set; }
        [XmlAttribute(AttributeName = "quantity")] public string Quantity { get; set; }
        [XmlAttribute(AttributeName = "fifoPnlRealized")] public string FifoPnlRealized { get; set; }
        [XmlAttribute(AttributeName = "mtmPnl")] public string MtmPnl { get; set; }
        [XmlAttribute(AttributeName = "type")] public string Type { get; set; }
        [XmlAttribute(AttributeName = "transactionID")] public string TransactionID { get; set; }
        [XmlAttribute(AttributeName = "levelOfDetail")] public string LevelOfDetail { get; set; }
        
        // accountId="-"
        // acctAlias="-"
        // model=""
        // currency="USD"
        // fxRateToBase="0.8309"
        // assetCategory="STK"
        // symbol="MRVL"
        // description="MRVL(BMG5876H1051) CUSIP/ISIN CHANGE TO (US5738741041) (MRVL, MARVELL TECHNOLOGY GROUP LTD, US5738741041)"
        // conid="483492393"
        // securityID="US5738741041"
        // securityIDType="ISIN"
        // cusip="573874104"
        // isin="US5738741041"
        // listingExchange="NASDAQ"
        // underlyingConid=""
        // underlyingSymbol=""
        // underlyingSecurityID=""
        // underlyingListingExchange=""
        // issuer=""
        // multiplier="1"
        // strike=""
        // expiry=""
        // putCall=""
        // principalAdjustFactor=""
        // serialNumber=""
        // deliveryType=""
        // commodityType=""
        // fineness="0.0"
        // weight="0.0 ()"
        // reportDate="20210421"
        // dateTime="20210420"
        // actionDescription="MRVL(BMG5876H1051) CUSIP/ISIN CHANGE TO (US5738741041) (MRVL, MARVELL TECHNOLOGY GROUP LTD, US5738741041)"
        // amount="0"
        // proceeds="0"
        // value="0"
        // quantity="40"
        // fifoPnlRealized="0"
        // mtmPnl="0" code=""
        // type="IC"
        // transactionID=""
        // levelOfDetail="SUMMARY" />
    }
}
