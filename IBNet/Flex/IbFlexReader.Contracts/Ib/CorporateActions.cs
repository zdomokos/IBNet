#region ZGT
// (c) Copyright 2021 ZTG LLC. All Rights Reserved.
// NOTICE: This file contains source code, ideas, techniques, and information (the Information) which are
// Proprietary and Confidential Information of ZTG LLC. This Information may not be used by or disclosed to any
// third party except under written license, and shall be subject to the limitations prescribed under license.
#endregion

using System.Collections.Generic;
using IbFlexReader.Xml.Contracts.QueryResponse;

namespace IbFlexReader.Contracts.Ib
{
    public class CorporateActions
    {
        public List<CorporateAction> CorporateAction { get; set; }
    }

    public class CorporateAction
    {
        public string AccountId                 { get; set; }
        public string AcctAlias                 { get; set; }
        public string Model                     { get; set; }
        public string Currency                  { get; set; }
        public string FxRateToBase              { get; set; }
        public string AssetCategory             { get; set; }
        public string Symbol                    { get; set; }
        public string Description               { get; set; }
        public string Conid                     { get; set; }
        public string SecurityID                { get; set; }
        public string SecurityIDType            { get; set; }
        public string Cusip                     { get; set; }
        public string Isin                      { get; set; }
        public string ListingExchange           { get; set; }
        public string UnderlyingConid           { get; set; }
        public string UnderlyingSymbol          { get; set; }
        public string UnderlyingSecurityID      { get; set; }
        public string UnderlyingListingExchange { get; set; }
        public string Issuer                    { get; set; }
        public string Multiplier                { get; set; }
        public string Strike                    { get; set; }
        public string Expiry                    { get; set; }
        public string PutCall                   { get; set; }
        public string PrincipalAdjustFactor     { get; set; }
        public string SerialNumber              { get; set; }
        public string DeliveryType              { get; set; }
        public string CommodityType             { get; set; }
        public string Fineness                  { get; set; }
        public string Weight                    { get; set; }
        public string ReportDate                { get; set; }
        public string DateTime                  { get; set; }
        public string ActionDescription         { get; set; }
        public string Amount                    { get; set; }
        public string Proceeds                  { get; set; }
        public string Value                     { get; set; }
        public string Quantity                  { get; set; }
        public string FifoPnlRealized           { get; set; }
        public string MtmPnl                    { get; set; }
        public string Type                      { get; set; }
        public string TransactionID             { get; set; }
        public string LevelOfDetail             { get; set; }

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
