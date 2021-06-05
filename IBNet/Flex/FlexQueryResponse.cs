/* Visual studio generated xml
using System;
using System.Collections.Generic;
using System.Text;

namespace IBNet.Flex2
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FlexQueryResponse
    {

        private FlexQueryResponseFlexStatements flexStatementsField;

        private string queryNameField;

        private string typeField;

        /// <remarks/>
        public FlexQueryResponseFlexStatements FlexStatements
        {
            get
            {
                return this.flexStatementsField;
            }
            set
            {
                this.flexStatementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string queryName
        {
            get
            {
                return this.queryNameField;
            }
            set
            {
                this.queryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatements
    {

        private FlexQueryResponseFlexStatementsFlexStatement[] flexStatementField;

        private byte countField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlexStatement")]
        public FlexQueryResponseFlexStatementsFlexStatement[] FlexStatement
        {
            get
            {
                return this.flexStatementField;
            }
            set
            {
                this.flexStatementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatement
    {

        private FlexQueryResponseFlexStatementsFlexStatementAccountInformation accountInformationField;

        private FlexQueryResponseFlexStatementsFlexStatementEquitySummaryByReportDateInBase[] equitySummaryInBaseField;

        private object fIFOPerformanceSummaryInBaseField;

        private FlexQueryResponseFlexStatementsFlexStatementOpenPosition[] openPositionsField;

        private FlexQueryResponseFlexStatementsFlexStatementTrades tradesField;

        private object transactionTaxesField;

        private FlexQueryResponseFlexStatementsFlexStatementOptionEAE[] optionEAEField;

        private FlexQueryResponseFlexStatementsFlexStatementPriorPeriodPosition[] priorPeriodPositionsField;

        private FlexQueryResponseFlexStatementsFlexStatementCashTransaction[] cashTransactionsField;

        private object cFDChargesField;

        private FlexQueryResponseFlexStatementsFlexStatementTransfer[] transfersField;

        private FlexQueryResponseFlexStatementsFlexStatementChangeInDividendAccrual[] changeInDividendAccrualsField;

        private FlexQueryResponseFlexStatementsFlexStatementOpenDividendAccrual[] openDividendAccrualsField;

        private FlexQueryResponseFlexStatementsFlexStatementSecurityInfo[] securitiesInfoField;

        private string accountIdField;

        private uint fromDateField;

        private uint toDateField;

        private string periodField;

        private string whenGeneratedField;

        /// <remarks/>
        public FlexQueryResponseFlexStatementsFlexStatementAccountInformation AccountInformation
        {
            get
            {
                return this.accountInformationField;
            }
            set
            {
                this.accountInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EquitySummaryByReportDateInBase", IsNullable = false)]
        public FlexQueryResponseFlexStatementsFlexStatementEquitySummaryByReportDateInBase[] EquitySummaryInBase
        {
            get
            {
                return this.equitySummaryInBaseField;
            }
            set
            {
                this.equitySummaryInBaseField = value;
            }
        }

        /// <remarks/>
        public object FIFOPerformanceSummaryInBase
        {
            get
            {
                return this.fIFOPerformanceSummaryInBaseField;
            }
            set
            {
                this.fIFOPerformanceSummaryInBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OpenPosition", IsNullable = false)]
        public FlexQueryResponseFlexStatementsFlexStatementOpenPosition[] OpenPositions
        {
            get
            {
                return this.openPositionsField;
            }
            set
            {
                this.openPositionsField = value;
            }
        }

        /// <remarks/>
        public FlexQueryResponseFlexStatementsFlexStatementTrades Trades
        {
            get
            {
                return this.tradesField;
            }
            set
            {
                this.tradesField = value;
            }
        }

        /// <remarks/>
        public object TransactionTaxes
        {
            get
            {
                return this.transactionTaxesField;
            }
            set
            {
                this.transactionTaxesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OptionEAE", IsNullable = false)]
        public FlexQueryResponseFlexStatementsFlexStatementOptionEAE[] OptionEAE
        {
            get
            {
                return this.optionEAEField;
            }
            set
            {
                this.optionEAEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PriorPeriodPosition", IsNullable = false)]
        public FlexQueryResponseFlexStatementsFlexStatementPriorPeriodPosition[] PriorPeriodPositions
        {
            get
            {
                return this.priorPeriodPositionsField;
            }
            set
            {
                this.priorPeriodPositionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CashTransaction", IsNullable = false)]
        public FlexQueryResponseFlexStatementsFlexStatementCashTransaction[] CashTransactions
        {
            get
            {
                return this.cashTransactionsField;
            }
            set
            {
                this.cashTransactionsField = value;
            }
        }

        /// <remarks/>
        public object CFDCharges
        {
            get
            {
                return this.cFDChargesField;
            }
            set
            {
                this.cFDChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transfer", IsNullable = false)]
        public FlexQueryResponseFlexStatementsFlexStatementTransfer[] Transfers
        {
            get
            {
                return this.transfersField;
            }
            set
            {
                this.transfersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ChangeInDividendAccrual", IsNullable = false)]
        public FlexQueryResponseFlexStatementsFlexStatementChangeInDividendAccrual[] ChangeInDividendAccruals
        {
            get
            {
                return this.changeInDividendAccrualsField;
            }
            set
            {
                this.changeInDividendAccrualsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OpenDividendAccrual", IsNullable = false)]
        public FlexQueryResponseFlexStatementsFlexStatementOpenDividendAccrual[] OpenDividendAccruals
        {
            get
            {
                return this.openDividendAccrualsField;
            }
            set
            {
                this.openDividendAccrualsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SecurityInfo", IsNullable = false)]
        public FlexQueryResponseFlexStatementsFlexStatementSecurityInfo[] SecuritiesInfo
        {
            get
            {
                return this.securitiesInfoField;
            }
            set
            {
                this.securitiesInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint fromDate
        {
            get
            {
                return this.fromDateField;
            }
            set
            {
                this.fromDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint toDate
        {
            get
            {
                return this.toDateField;
            }
            set
            {
                this.toDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string whenGenerated
        {
            get
            {
                return this.whenGeneratedField;
            }
            set
            {
                this.whenGeneratedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementAccountInformation
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private string currencyField;

        private string nameField;

        private string accountTypeField;

        private string customerTypeField;

        private string accountCapabilitiesField;

        private string tradingPermissionsField;

        private string accountRepNameField;

        private string accountRepPhoneField;

        private uint dateOpenedField;

        private uint dateFundedField;

        private string dateClosedField;

        private string streetField;

        private string street2Field;

        private string cityField;

        private string stateField;

        private string countryField;

        private ushort postalCodeField;

        private string streetResidentialAddressField;

        private string street2ResidentialAddressField;

        private string cityResidentialAddressField;

        private string stateResidentialAddressField;

        private string countryResidentialAddressField;

        private ushort postalCodeResidentialAddressField;

        private string masterNameField;

        private string ibEntityField;

        private string primaryEmailField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountType
        {
            get
            {
                return this.accountTypeField;
            }
            set
            {
                this.accountTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string customerType
        {
            get
            {
                return this.customerTypeField;
            }
            set
            {
                this.customerTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountCapabilities
        {
            get
            {
                return this.accountCapabilitiesField;
            }
            set
            {
                this.accountCapabilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tradingPermissions
        {
            get
            {
                return this.tradingPermissionsField;
            }
            set
            {
                this.tradingPermissionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountRepName
        {
            get
            {
                return this.accountRepNameField;
            }
            set
            {
                this.accountRepNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountRepPhone
        {
            get
            {
                return this.accountRepPhoneField;
            }
            set
            {
                this.accountRepPhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint dateOpened
        {
            get
            {
                return this.dateOpenedField;
            }
            set
            {
                this.dateOpenedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint dateFunded
        {
            get
            {
                return this.dateFundedField;
            }
            set
            {
                this.dateFundedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateClosed
        {
            get
            {
                return this.dateClosedField;
            }
            set
            {
                this.dateClosedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string street2
        {
            get
            {
                return this.street2Field;
            }
            set
            {
                this.street2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort postalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string streetResidentialAddress
        {
            get
            {
                return this.streetResidentialAddressField;
            }
            set
            {
                this.streetResidentialAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string street2ResidentialAddress
        {
            get
            {
                return this.street2ResidentialAddressField;
            }
            set
            {
                this.street2ResidentialAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cityResidentialAddress
        {
            get
            {
                return this.cityResidentialAddressField;
            }
            set
            {
                this.cityResidentialAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string stateResidentialAddress
        {
            get
            {
                return this.stateResidentialAddressField;
            }
            set
            {
                this.stateResidentialAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string countryResidentialAddress
        {
            get
            {
                return this.countryResidentialAddressField;
            }
            set
            {
                this.countryResidentialAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort postalCodeResidentialAddress
        {
            get
            {
                return this.postalCodeResidentialAddressField;
            }
            set
            {
                this.postalCodeResidentialAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string masterName
        {
            get
            {
                return this.masterNameField;
            }
            set
            {
                this.masterNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ibEntity
        {
            get
            {
                return this.ibEntityField;
            }
            set
            {
                this.ibEntityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string primaryEmail
        {
            get
            {
                return this.primaryEmailField;
            }
            set
            {
                this.primaryEmailField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementEquitySummaryByReportDateInBase
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private uint reportDateField;

        private decimal cashField;

        private decimal cashLongField;

        private decimal cashShortField;

        private decimal brokerCashComponentField;

        private decimal brokerCashComponentLongField;

        private decimal brokerCashComponentShortField;

        private byte fdicInsuredBankSweepAccountCashComponentField;

        private byte fdicInsuredBankSweepAccountCashComponentLongField;

        private byte fdicInsuredBankSweepAccountCashComponentShortField;

        private byte slbCashCollateralField;

        private byte slbCashCollateralLongField;

        private byte slbCashCollateralShortField;

        private decimal stockField;

        private decimal stockLongField;

        private byte stockShortField;

        private byte ipoSubscriptionField;

        private byte ipoSubscriptionLongField;

        private byte ipoSubscriptionShortField;

        private byte slbDirectSecuritiesBorrowedField;

        private byte slbDirectSecuritiesBorrowedLongField;

        private byte slbDirectSecuritiesBorrowedShortField;

        private byte slbDirectSecuritiesLentField;

        private byte slbDirectSecuritiesLentLongField;

        private byte slbDirectSecuritiesLentShortField;

        private decimal optionsField;

        private decimal optionsLongField;

        private byte optionsShortField;

        private byte bondsField;

        private byte bondsLongField;

        private byte bondsShortField;

        private byte commoditiesField;

        private byte commoditiesLongField;

        private byte commoditiesShortField;

        private byte notesField;

        private byte notesLongField;

        private byte notesShortField;

        private byte fundsField;

        private byte fundsLongField;

        private byte fundsShortField;

        private decimal dividendAccrualsField;

        private decimal dividendAccrualsLongField;

        private byte dividendAccrualsShortField;

        private decimal interestAccrualsField;

        private byte interestAccrualsLongField;

        private decimal interestAccrualsShortField;

        private byte brokerInterestAccrualsComponentField;

        private byte brokerInterestAccrualsComponentLongField;

        private byte brokerInterestAccrualsComponentShortField;

        private byte fdicInsuredAccountInterestAccrualsComponentField;

        private byte fdicInsuredAccountInterestAccrualsComponentLongField;

        private byte fdicInsuredAccountInterestAccrualsComponentShortField;

        private byte bondInterestAccrualsComponentField;

        private byte bondInterestAccrualsComponentLongField;

        private byte bondInterestAccrualsComponentShortField;

        private byte brokerFeesAccrualsComponentField;

        private byte brokerFeesAccrualsComponentLongField;

        private byte brokerFeesAccrualsComponentShortField;

        private byte softDollarsField;

        private byte softDollarsLongField;

        private byte softDollarsShortField;

        private byte forexCfdUnrealizedPlField;

        private byte forexCfdUnrealizedPlLongField;

        private byte forexCfdUnrealizedPlShortField;

        private byte cfdUnrealizedPlField;

        private byte cfdUnrealizedPlLongField;

        private byte cfdUnrealizedPlShortField;

        private decimal totalField;

        private decimal totalLongField;

        private decimal totalShortField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint reportDate
        {
            get
            {
                return this.reportDateField;
            }
            set
            {
                this.reportDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cash
        {
            get
            {
                return this.cashField;
            }
            set
            {
                this.cashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cashLong
        {
            get
            {
                return this.cashLongField;
            }
            set
            {
                this.cashLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cashShort
        {
            get
            {
                return this.cashShortField;
            }
            set
            {
                this.cashShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal brokerCashComponent
        {
            get
            {
                return this.brokerCashComponentField;
            }
            set
            {
                this.brokerCashComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal brokerCashComponentLong
        {
            get
            {
                return this.brokerCashComponentLongField;
            }
            set
            {
                this.brokerCashComponentLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal brokerCashComponentShort
        {
            get
            {
                return this.brokerCashComponentShortField;
            }
            set
            {
                this.brokerCashComponentShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fdicInsuredBankSweepAccountCashComponent
        {
            get
            {
                return this.fdicInsuredBankSweepAccountCashComponentField;
            }
            set
            {
                this.fdicInsuredBankSweepAccountCashComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fdicInsuredBankSweepAccountCashComponentLong
        {
            get
            {
                return this.fdicInsuredBankSweepAccountCashComponentLongField;
            }
            set
            {
                this.fdicInsuredBankSweepAccountCashComponentLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fdicInsuredBankSweepAccountCashComponentShort
        {
            get
            {
                return this.fdicInsuredBankSweepAccountCashComponentShortField;
            }
            set
            {
                this.fdicInsuredBankSweepAccountCashComponentShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte slbCashCollateral
        {
            get
            {
                return this.slbCashCollateralField;
            }
            set
            {
                this.slbCashCollateralField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte slbCashCollateralLong
        {
            get
            {
                return this.slbCashCollateralLongField;
            }
            set
            {
                this.slbCashCollateralLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte slbCashCollateralShort
        {
            get
            {
                return this.slbCashCollateralShortField;
            }
            set
            {
                this.slbCashCollateralShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal stock
        {
            get
            {
                return this.stockField;
            }
            set
            {
                this.stockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal stockLong
        {
            get
            {
                return this.stockLongField;
            }
            set
            {
                this.stockLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte stockShort
        {
            get
            {
                return this.stockShortField;
            }
            set
            {
                this.stockShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ipoSubscription
        {
            get
            {
                return this.ipoSubscriptionField;
            }
            set
            {
                this.ipoSubscriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ipoSubscriptionLong
        {
            get
            {
                return this.ipoSubscriptionLongField;
            }
            set
            {
                this.ipoSubscriptionLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ipoSubscriptionShort
        {
            get
            {
                return this.ipoSubscriptionShortField;
            }
            set
            {
                this.ipoSubscriptionShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte slbDirectSecuritiesBorrowed
        {
            get
            {
                return this.slbDirectSecuritiesBorrowedField;
            }
            set
            {
                this.slbDirectSecuritiesBorrowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte slbDirectSecuritiesBorrowedLong
        {
            get
            {
                return this.slbDirectSecuritiesBorrowedLongField;
            }
            set
            {
                this.slbDirectSecuritiesBorrowedLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte slbDirectSecuritiesBorrowedShort
        {
            get
            {
                return this.slbDirectSecuritiesBorrowedShortField;
            }
            set
            {
                this.slbDirectSecuritiesBorrowedShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte slbDirectSecuritiesLent
        {
            get
            {
                return this.slbDirectSecuritiesLentField;
            }
            set
            {
                this.slbDirectSecuritiesLentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte slbDirectSecuritiesLentLong
        {
            get
            {
                return this.slbDirectSecuritiesLentLongField;
            }
            set
            {
                this.slbDirectSecuritiesLentLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte slbDirectSecuritiesLentShort
        {
            get
            {
                return this.slbDirectSecuritiesLentShortField;
            }
            set
            {
                this.slbDirectSecuritiesLentShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal options
        {
            get
            {
                return this.optionsField;
            }
            set
            {
                this.optionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal optionsLong
        {
            get
            {
                return this.optionsLongField;
            }
            set
            {
                this.optionsLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte optionsShort
        {
            get
            {
                return this.optionsShortField;
            }
            set
            {
                this.optionsShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bonds
        {
            get
            {
                return this.bondsField;
            }
            set
            {
                this.bondsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bondsLong
        {
            get
            {
                return this.bondsLongField;
            }
            set
            {
                this.bondsLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bondsShort
        {
            get
            {
                return this.bondsShortField;
            }
            set
            {
                this.bondsShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte commodities
        {
            get
            {
                return this.commoditiesField;
            }
            set
            {
                this.commoditiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte commoditiesLong
        {
            get
            {
                return this.commoditiesLongField;
            }
            set
            {
                this.commoditiesLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte commoditiesShort
        {
            get
            {
                return this.commoditiesShortField;
            }
            set
            {
                this.commoditiesShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte notesLong
        {
            get
            {
                return this.notesLongField;
            }
            set
            {
                this.notesLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte notesShort
        {
            get
            {
                return this.notesShortField;
            }
            set
            {
                this.notesShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte funds
        {
            get
            {
                return this.fundsField;
            }
            set
            {
                this.fundsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fundsLong
        {
            get
            {
                return this.fundsLongField;
            }
            set
            {
                this.fundsLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fundsShort
        {
            get
            {
                return this.fundsShortField;
            }
            set
            {
                this.fundsShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal dividendAccruals
        {
            get
            {
                return this.dividendAccrualsField;
            }
            set
            {
                this.dividendAccrualsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal dividendAccrualsLong
        {
            get
            {
                return this.dividendAccrualsLongField;
            }
            set
            {
                this.dividendAccrualsLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte dividendAccrualsShort
        {
            get
            {
                return this.dividendAccrualsShortField;
            }
            set
            {
                this.dividendAccrualsShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal interestAccruals
        {
            get
            {
                return this.interestAccrualsField;
            }
            set
            {
                this.interestAccrualsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte interestAccrualsLong
        {
            get
            {
                return this.interestAccrualsLongField;
            }
            set
            {
                this.interestAccrualsLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal interestAccrualsShort
        {
            get
            {
                return this.interestAccrualsShortField;
            }
            set
            {
                this.interestAccrualsShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte brokerInterestAccrualsComponent
        {
            get
            {
                return this.brokerInterestAccrualsComponentField;
            }
            set
            {
                this.brokerInterestAccrualsComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte brokerInterestAccrualsComponentLong
        {
            get
            {
                return this.brokerInterestAccrualsComponentLongField;
            }
            set
            {
                this.brokerInterestAccrualsComponentLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte brokerInterestAccrualsComponentShort
        {
            get
            {
                return this.brokerInterestAccrualsComponentShortField;
            }
            set
            {
                this.brokerInterestAccrualsComponentShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fdicInsuredAccountInterestAccrualsComponent
        {
            get
            {
                return this.fdicInsuredAccountInterestAccrualsComponentField;
            }
            set
            {
                this.fdicInsuredAccountInterestAccrualsComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fdicInsuredAccountInterestAccrualsComponentLong
        {
            get
            {
                return this.fdicInsuredAccountInterestAccrualsComponentLongField;
            }
            set
            {
                this.fdicInsuredAccountInterestAccrualsComponentLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fdicInsuredAccountInterestAccrualsComponentShort
        {
            get
            {
                return this.fdicInsuredAccountInterestAccrualsComponentShortField;
            }
            set
            {
                this.fdicInsuredAccountInterestAccrualsComponentShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bondInterestAccrualsComponent
        {
            get
            {
                return this.bondInterestAccrualsComponentField;
            }
            set
            {
                this.bondInterestAccrualsComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bondInterestAccrualsComponentLong
        {
            get
            {
                return this.bondInterestAccrualsComponentLongField;
            }
            set
            {
                this.bondInterestAccrualsComponentLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bondInterestAccrualsComponentShort
        {
            get
            {
                return this.bondInterestAccrualsComponentShortField;
            }
            set
            {
                this.bondInterestAccrualsComponentShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte brokerFeesAccrualsComponent
        {
            get
            {
                return this.brokerFeesAccrualsComponentField;
            }
            set
            {
                this.brokerFeesAccrualsComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte brokerFeesAccrualsComponentLong
        {
            get
            {
                return this.brokerFeesAccrualsComponentLongField;
            }
            set
            {
                this.brokerFeesAccrualsComponentLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte brokerFeesAccrualsComponentShort
        {
            get
            {
                return this.brokerFeesAccrualsComponentShortField;
            }
            set
            {
                this.brokerFeesAccrualsComponentShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte softDollars
        {
            get
            {
                return this.softDollarsField;
            }
            set
            {
                this.softDollarsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte softDollarsLong
        {
            get
            {
                return this.softDollarsLongField;
            }
            set
            {
                this.softDollarsLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte softDollarsShort
        {
            get
            {
                return this.softDollarsShortField;
            }
            set
            {
                this.softDollarsShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte forexCfdUnrealizedPl
        {
            get
            {
                return this.forexCfdUnrealizedPlField;
            }
            set
            {
                this.forexCfdUnrealizedPlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte forexCfdUnrealizedPlLong
        {
            get
            {
                return this.forexCfdUnrealizedPlLongField;
            }
            set
            {
                this.forexCfdUnrealizedPlLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte forexCfdUnrealizedPlShort
        {
            get
            {
                return this.forexCfdUnrealizedPlShortField;
            }
            set
            {
                this.forexCfdUnrealizedPlShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cfdUnrealizedPl
        {
            get
            {
                return this.cfdUnrealizedPlField;
            }
            set
            {
                this.cfdUnrealizedPlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cfdUnrealizedPlLong
        {
            get
            {
                return this.cfdUnrealizedPlLongField;
            }
            set
            {
                this.cfdUnrealizedPlLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cfdUnrealizedPlShort
        {
            get
            {
                return this.cfdUnrealizedPlShortField;
            }
            set
            {
                this.cfdUnrealizedPlShortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal totalLong
        {
            get
            {
                return this.totalLongField;
            }
            set
            {
                this.totalLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal totalShort
        {
            get
            {
                return this.totalShortField;
            }
            set
            {
                this.totalShortField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementOpenPosition
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private string currencyField;

        private byte fxRateToBaseField;

        private string assetCategoryField;

        private string symbolField;

        private string descriptionField;

        private uint conidField;

        private string securityIDField;

        private string securityIDTypeField;

        private string cusipField;

        private string isinField;

        private string listingExchangeField;

        private string underlyingConidField;

        private string underlyingSymbolField;

        private string underlyingSecurityIDField;

        private string underlyingListingExchangeField;

        private string issuerField;

        private byte multiplierField;

        private string strikeField;

        private string expiryField;

        private string putCallField;

        private string principalAdjustFactorField;

        private string serialNumberField;

        private string deliveryTypeField;

        private string commodityTypeField;

        private decimal finenessField;

        private string weightField;

        private uint reportDateField;

        private byte positionField;

        private decimal markPriceField;

        private decimal positionValueField;

        private byte openPriceField;

        private byte costBasisPriceField;

        private byte costBasisMoneyField;

        private decimal percentOfNAVField;

        private byte fifoPnlUnrealizedField;

        private string sideField;

        private string levelOfDetailField;

        private string openDateTimeField;

        private string holdingPeriodDateTimeField;

        private string vestingDateField;

        private string codeField;

        private string originatingOrderIDField;

        private string originatingTransactionIDField;

        private string accruedIntField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fxRateToBase
        {
            get
            {
                return this.fxRateToBaseField;
            }
            set
            {
                this.fxRateToBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetCategory
        {
            get
            {
                return this.assetCategoryField;
            }
            set
            {
                this.assetCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint conid
        {
            get
            {
                return this.conidField;
            }
            set
            {
                this.conidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityIDType
        {
            get
            {
                return this.securityIDTypeField;
            }
            set
            {
                this.securityIDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cusip
        {
            get
            {
                return this.cusipField;
            }
            set
            {
                this.cusipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listingExchange
        {
            get
            {
                return this.listingExchangeField;
            }
            set
            {
                this.listingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingConid
        {
            get
            {
                return this.underlyingConidField;
            }
            set
            {
                this.underlyingConidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSymbol
        {
            get
            {
                return this.underlyingSymbolField;
            }
            set
            {
                this.underlyingSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSecurityID
        {
            get
            {
                return this.underlyingSecurityIDField;
            }
            set
            {
                this.underlyingSecurityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingListingExchange
        {
            get
            {
                return this.underlyingListingExchangeField;
            }
            set
            {
                this.underlyingListingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string putCall
        {
            get
            {
                return this.putCallField;
            }
            set
            {
                this.putCallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string principalAdjustFactor
        {
            get
            {
                return this.principalAdjustFactorField;
            }
            set
            {
                this.principalAdjustFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string commodityType
        {
            get
            {
                return this.commodityTypeField;
            }
            set
            {
                this.commodityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint reportDate
        {
            get
            {
                return this.reportDateField;
            }
            set
            {
                this.reportDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal markPrice
        {
            get
            {
                return this.markPriceField;
            }
            set
            {
                this.markPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal positionValue
        {
            get
            {
                return this.positionValueField;
            }
            set
            {
                this.positionValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte openPrice
        {
            get
            {
                return this.openPriceField;
            }
            set
            {
                this.openPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte costBasisPrice
        {
            get
            {
                return this.costBasisPriceField;
            }
            set
            {
                this.costBasisPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte costBasisMoney
        {
            get
            {
                return this.costBasisMoneyField;
            }
            set
            {
                this.costBasisMoneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal percentOfNAV
        {
            get
            {
                return this.percentOfNAVField;
            }
            set
            {
                this.percentOfNAVField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fifoPnlUnrealized
        {
            get
            {
                return this.fifoPnlUnrealizedField;
            }
            set
            {
                this.fifoPnlUnrealizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string side
        {
            get
            {
                return this.sideField;
            }
            set
            {
                this.sideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string levelOfDetail
        {
            get
            {
                return this.levelOfDetailField;
            }
            set
            {
                this.levelOfDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string openDateTime
        {
            get
            {
                return this.openDateTimeField;
            }
            set
            {
                this.openDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string holdingPeriodDateTime
        {
            get
            {
                return this.holdingPeriodDateTimeField;
            }
            set
            {
                this.holdingPeriodDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vestingDate
        {
            get
            {
                return this.vestingDateField;
            }
            set
            {
                this.vestingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string originatingOrderID
        {
            get
            {
                return this.originatingOrderIDField;
            }
            set
            {
                this.originatingOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string originatingTransactionID
        {
            get
            {
                return this.originatingTransactionIDField;
            }
            set
            {
                this.originatingTransactionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accruedInt
        {
            get
            {
                return this.accruedIntField;
            }
            set
            {
                this.accruedIntField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementTrades
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssetSummary", typeof(FlexQueryResponseFlexStatementsFlexStatementTradesAssetSummary))]
        [System.Xml.Serialization.XmlElementAttribute("Order", typeof(FlexQueryResponseFlexStatementsFlexStatementTradesOrder))]
        [System.Xml.Serialization.XmlElementAttribute("SymbolSummary", typeof(FlexQueryResponseFlexStatementsFlexStatementTradesSymbolSummary))]
        [System.Xml.Serialization.XmlElementAttribute("Trade", typeof(FlexQueryResponseFlexStatementsFlexStatementTradesTrade))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementTradesAssetSummary
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private string currencyField;

        private string fxRateToBaseField;

        private string assetCategoryField;

        private string symbolField;

        private string descriptionField;

        private string conidField;

        private string securityIDField;

        private string securityIDTypeField;

        private string cusipField;

        private string isinField;

        private string listingExchangeField;

        private string underlyingConidField;

        private string underlyingSymbolField;

        private string underlyingSecurityIDField;

        private string underlyingListingExchangeField;

        private string issuerField;

        private string multiplierField;

        private string strikeField;

        private string expiryField;

        private string tradeIDField;

        private string putCallField;

        private string reportDateField;

        private string principalAdjustFactorField;

        private string dateTimeField;

        private string serialNumberField;

        private string tradeDateField;

        private string deliveryTypeField;

        private string commodityTypeField;

        private string settleDateTargetField;

        private string finenessField;

        private string transactionTypeField;

        private string weightField;

        private string exchangeField;

        private ushort quantityField;

        private string tradePriceField;

        private string tradeMoneyField;

        private decimal proceedsField;

        private byte taxesField;

        private decimal ibCommissionField;

        private string ibCommissionCurrencyField;

        private string netCashField;

        private string closePriceField;

        private string openCloseIndicatorField;

        private string notesField;

        private string costField;

        private string fifoPnlRealizedField;

        private string fxPnlField;

        private string mtmPnlField;

        private string origTradePriceField;

        private string origTradeDateField;

        private string origTradeIDField;

        private string origOrderIDField;

        private string clearingFirmIDField;

        private string transactionIDField;

        private string buySellField;

        private string ibOrderIDField;

        private string ibExecIDField;

        private string brokerageOrderIDField;

        private string orderReferenceField;

        private string volatilityOrderLinkField;

        private string exchOrderIdField;

        private string extExecIDField;

        private string orderTimeField;

        private string openDateTimeField;

        private string holdingPeriodDateTimeField;

        private string whenRealizedField;

        private string whenReopenedField;

        private string levelOfDetailField;

        private string changeInPriceField;

        private string changeInQuantityField;

        private string orderTypeField;

        private string traderIDField;

        private string isAPIOrderField;

        private string accruedIntField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fxRateToBase
        {
            get
            {
                return this.fxRateToBaseField;
            }
            set
            {
                this.fxRateToBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetCategory
        {
            get
            {
                return this.assetCategoryField;
            }
            set
            {
                this.assetCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string conid
        {
            get
            {
                return this.conidField;
            }
            set
            {
                this.conidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityIDType
        {
            get
            {
                return this.securityIDTypeField;
            }
            set
            {
                this.securityIDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cusip
        {
            get
            {
                return this.cusipField;
            }
            set
            {
                this.cusipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listingExchange
        {
            get
            {
                return this.listingExchangeField;
            }
            set
            {
                this.listingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingConid
        {
            get
            {
                return this.underlyingConidField;
            }
            set
            {
                this.underlyingConidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSymbol
        {
            get
            {
                return this.underlyingSymbolField;
            }
            set
            {
                this.underlyingSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSecurityID
        {
            get
            {
                return this.underlyingSecurityIDField;
            }
            set
            {
                this.underlyingSecurityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingListingExchange
        {
            get
            {
                return this.underlyingListingExchangeField;
            }
            set
            {
                this.underlyingListingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tradeID
        {
            get
            {
                return this.tradeIDField;
            }
            set
            {
                this.tradeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string putCall
        {
            get
            {
                return this.putCallField;
            }
            set
            {
                this.putCallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string reportDate
        {
            get
            {
                return this.reportDateField;
            }
            set
            {
                this.reportDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string principalAdjustFactor
        {
            get
            {
                return this.principalAdjustFactorField;
            }
            set
            {
                this.principalAdjustFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tradeDate
        {
            get
            {
                return this.tradeDateField;
            }
            set
            {
                this.tradeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string commodityType
        {
            get
            {
                return this.commodityTypeField;
            }
            set
            {
                this.commodityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string settleDateTarget
        {
            get
            {
                return this.settleDateTargetField;
            }
            set
            {
                this.settleDateTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transactionType
        {
            get
            {
                return this.transactionTypeField;
            }
            set
            {
                this.transactionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exchange
        {
            get
            {
                return this.exchangeField;
            }
            set
            {
                this.exchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tradePrice
        {
            get
            {
                return this.tradePriceField;
            }
            set
            {
                this.tradePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tradeMoney
        {
            get
            {
                return this.tradeMoneyField;
            }
            set
            {
                this.tradeMoneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal proceeds
        {
            get
            {
                return this.proceedsField;
            }
            set
            {
                this.proceedsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte taxes
        {
            get
            {
                return this.taxesField;
            }
            set
            {
                this.taxesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ibCommission
        {
            get
            {
                return this.ibCommissionField;
            }
            set
            {
                this.ibCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ibCommissionCurrency
        {
            get
            {
                return this.ibCommissionCurrencyField;
            }
            set
            {
                this.ibCommissionCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string netCash
        {
            get
            {
                return this.netCashField;
            }
            set
            {
                this.netCashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string closePrice
        {
            get
            {
                return this.closePriceField;
            }
            set
            {
                this.closePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string openCloseIndicator
        {
            get
            {
                return this.openCloseIndicatorField;
            }
            set
            {
                this.openCloseIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fifoPnlRealized
        {
            get
            {
                return this.fifoPnlRealizedField;
            }
            set
            {
                this.fifoPnlRealizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fxPnl
        {
            get
            {
                return this.fxPnlField;
            }
            set
            {
                this.fxPnlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mtmPnl
        {
            get
            {
                return this.mtmPnlField;
            }
            set
            {
                this.mtmPnlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origTradePrice
        {
            get
            {
                return this.origTradePriceField;
            }
            set
            {
                this.origTradePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origTradeDate
        {
            get
            {
                return this.origTradeDateField;
            }
            set
            {
                this.origTradeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origTradeID
        {
            get
            {
                return this.origTradeIDField;
            }
            set
            {
                this.origTradeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origOrderID
        {
            get
            {
                return this.origOrderIDField;
            }
            set
            {
                this.origOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clearingFirmID
        {
            get
            {
                return this.clearingFirmIDField;
            }
            set
            {
                this.clearingFirmIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string buySell
        {
            get
            {
                return this.buySellField;
            }
            set
            {
                this.buySellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ibOrderID
        {
            get
            {
                return this.ibOrderIDField;
            }
            set
            {
                this.ibOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ibExecID
        {
            get
            {
                return this.ibExecIDField;
            }
            set
            {
                this.ibExecIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string brokerageOrderID
        {
            get
            {
                return this.brokerageOrderIDField;
            }
            set
            {
                this.brokerageOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderReference
        {
            get
            {
                return this.orderReferenceField;
            }
            set
            {
                this.orderReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string volatilityOrderLink
        {
            get
            {
                return this.volatilityOrderLinkField;
            }
            set
            {
                this.volatilityOrderLinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exchOrderId
        {
            get
            {
                return this.exchOrderIdField;
            }
            set
            {
                this.exchOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string extExecID
        {
            get
            {
                return this.extExecIDField;
            }
            set
            {
                this.extExecIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderTime
        {
            get
            {
                return this.orderTimeField;
            }
            set
            {
                this.orderTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string openDateTime
        {
            get
            {
                return this.openDateTimeField;
            }
            set
            {
                this.openDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string holdingPeriodDateTime
        {
            get
            {
                return this.holdingPeriodDateTimeField;
            }
            set
            {
                this.holdingPeriodDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string whenRealized
        {
            get
            {
                return this.whenRealizedField;
            }
            set
            {
                this.whenRealizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string whenReopened
        {
            get
            {
                return this.whenReopenedField;
            }
            set
            {
                this.whenReopenedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string levelOfDetail
        {
            get
            {
                return this.levelOfDetailField;
            }
            set
            {
                this.levelOfDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string changeInPrice
        {
            get
            {
                return this.changeInPriceField;
            }
            set
            {
                this.changeInPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string changeInQuantity
        {
            get
            {
                return this.changeInQuantityField;
            }
            set
            {
                this.changeInQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderType
        {
            get
            {
                return this.orderTypeField;
            }
            set
            {
                this.orderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string traderID
        {
            get
            {
                return this.traderIDField;
            }
            set
            {
                this.traderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isAPIOrder
        {
            get
            {
                return this.isAPIOrderField;
            }
            set
            {
                this.isAPIOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accruedInt
        {
            get
            {
                return this.accruedIntField;
            }
            set
            {
                this.accruedIntField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementTradesOrder
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private string currencyField;

        private byte fxRateToBaseField;

        private string assetCategoryField;

        private string symbolField;

        private string descriptionField;

        private uint conidField;

        private string securityIDField;

        private string securityIDTypeField;

        private string cusipField;

        private string isinField;

        private string listingExchangeField;

        private string underlyingConidField;

        private string underlyingSymbolField;

        private string underlyingSecurityIDField;

        private string underlyingListingExchangeField;

        private string issuerField;

        private byte multiplierField;

        private string strikeField;

        private string expiryField;

        private string tradeIDField;

        private string putCallField;

        private uint reportDateField;

        private string principalAdjustFactorField;

        private string dateTimeField;

        private string serialNumberField;

        private uint tradeDateField;

        private string deliveryTypeField;

        private string commodityTypeField;

        private uint settleDateTargetField;

        private decimal finenessField;

        private string transactionTypeField;

        private string weightField;

        private string exchangeField;

        private short quantityField;

        private decimal tradePriceField;

        private decimal tradeMoneyField;

        private decimal proceedsField;

        private byte taxesField;

        private decimal ibCommissionField;

        private string ibCommissionCurrencyField;

        private decimal netCashField;

        private decimal closePriceField;

        private string openCloseIndicatorField;

        private string notesField;

        private decimal costField;

        private byte fifoPnlRealizedField;

        private byte fxPnlField;

        private decimal mtmPnlField;

        private string origTradePriceField;

        private string origTradeDateField;

        private string origTradeIDField;

        private string origOrderIDField;

        private string clearingFirmIDField;

        private string transactionIDField;

        private string buySellField;

        private ulong ibOrderIDField;

        private string ibExecIDField;

        private string brokerageOrderIDField;

        private string orderReferenceField;

        private string volatilityOrderLinkField;

        private string exchOrderIdField;

        private string extExecIDField;

        private string orderTimeField;

        private string openDateTimeField;

        private string holdingPeriodDateTimeField;

        private string whenRealizedField;

        private string whenReopenedField;

        private string levelOfDetailField;

        private string changeInPriceField;

        private string changeInQuantityField;

        private string orderTypeField;

        private string traderIDField;

        private string isAPIOrderField;

        private byte accruedIntField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fxRateToBase
        {
            get
            {
                return this.fxRateToBaseField;
            }
            set
            {
                this.fxRateToBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetCategory
        {
            get
            {
                return this.assetCategoryField;
            }
            set
            {
                this.assetCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint conid
        {
            get
            {
                return this.conidField;
            }
            set
            {
                this.conidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityIDType
        {
            get
            {
                return this.securityIDTypeField;
            }
            set
            {
                this.securityIDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cusip
        {
            get
            {
                return this.cusipField;
            }
            set
            {
                this.cusipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listingExchange
        {
            get
            {
                return this.listingExchangeField;
            }
            set
            {
                this.listingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingConid
        {
            get
            {
                return this.underlyingConidField;
            }
            set
            {
                this.underlyingConidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSymbol
        {
            get
            {
                return this.underlyingSymbolField;
            }
            set
            {
                this.underlyingSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSecurityID
        {
            get
            {
                return this.underlyingSecurityIDField;
            }
            set
            {
                this.underlyingSecurityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingListingExchange
        {
            get
            {
                return this.underlyingListingExchangeField;
            }
            set
            {
                this.underlyingListingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tradeID
        {
            get
            {
                return this.tradeIDField;
            }
            set
            {
                this.tradeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string putCall
        {
            get
            {
                return this.putCallField;
            }
            set
            {
                this.putCallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint reportDate
        {
            get
            {
                return this.reportDateField;
            }
            set
            {
                this.reportDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string principalAdjustFactor
        {
            get
            {
                return this.principalAdjustFactorField;
            }
            set
            {
                this.principalAdjustFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint tradeDate
        {
            get
            {
                return this.tradeDateField;
            }
            set
            {
                this.tradeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string commodityType
        {
            get
            {
                return this.commodityTypeField;
            }
            set
            {
                this.commodityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint settleDateTarget
        {
            get
            {
                return this.settleDateTargetField;
            }
            set
            {
                this.settleDateTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transactionType
        {
            get
            {
                return this.transactionTypeField;
            }
            set
            {
                this.transactionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exchange
        {
            get
            {
                return this.exchangeField;
            }
            set
            {
                this.exchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public short quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tradePrice
        {
            get
            {
                return this.tradePriceField;
            }
            set
            {
                this.tradePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tradeMoney
        {
            get
            {
                return this.tradeMoneyField;
            }
            set
            {
                this.tradeMoneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal proceeds
        {
            get
            {
                return this.proceedsField;
            }
            set
            {
                this.proceedsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte taxes
        {
            get
            {
                return this.taxesField;
            }
            set
            {
                this.taxesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ibCommission
        {
            get
            {
                return this.ibCommissionField;
            }
            set
            {
                this.ibCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ibCommissionCurrency
        {
            get
            {
                return this.ibCommissionCurrencyField;
            }
            set
            {
                this.ibCommissionCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal netCash
        {
            get
            {
                return this.netCashField;
            }
            set
            {
                this.netCashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal closePrice
        {
            get
            {
                return this.closePriceField;
            }
            set
            {
                this.closePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string openCloseIndicator
        {
            get
            {
                return this.openCloseIndicatorField;
            }
            set
            {
                this.openCloseIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fifoPnlRealized
        {
            get
            {
                return this.fifoPnlRealizedField;
            }
            set
            {
                this.fifoPnlRealizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fxPnl
        {
            get
            {
                return this.fxPnlField;
            }
            set
            {
                this.fxPnlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal mtmPnl
        {
            get
            {
                return this.mtmPnlField;
            }
            set
            {
                this.mtmPnlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origTradePrice
        {
            get
            {
                return this.origTradePriceField;
            }
            set
            {
                this.origTradePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origTradeDate
        {
            get
            {
                return this.origTradeDateField;
            }
            set
            {
                this.origTradeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origTradeID
        {
            get
            {
                return this.origTradeIDField;
            }
            set
            {
                this.origTradeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origOrderID
        {
            get
            {
                return this.origOrderIDField;
            }
            set
            {
                this.origOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clearingFirmID
        {
            get
            {
                return this.clearingFirmIDField;
            }
            set
            {
                this.clearingFirmIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string buySell
        {
            get
            {
                return this.buySellField;
            }
            set
            {
                this.buySellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong ibOrderID
        {
            get
            {
                return this.ibOrderIDField;
            }
            set
            {
                this.ibOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ibExecID
        {
            get
            {
                return this.ibExecIDField;
            }
            set
            {
                this.ibExecIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string brokerageOrderID
        {
            get
            {
                return this.brokerageOrderIDField;
            }
            set
            {
                this.brokerageOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderReference
        {
            get
            {
                return this.orderReferenceField;
            }
            set
            {
                this.orderReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string volatilityOrderLink
        {
            get
            {
                return this.volatilityOrderLinkField;
            }
            set
            {
                this.volatilityOrderLinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exchOrderId
        {
            get
            {
                return this.exchOrderIdField;
            }
            set
            {
                this.exchOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string extExecID
        {
            get
            {
                return this.extExecIDField;
            }
            set
            {
                this.extExecIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderTime
        {
            get
            {
                return this.orderTimeField;
            }
            set
            {
                this.orderTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string openDateTime
        {
            get
            {
                return this.openDateTimeField;
            }
            set
            {
                this.openDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string holdingPeriodDateTime
        {
            get
            {
                return this.holdingPeriodDateTimeField;
            }
            set
            {
                this.holdingPeriodDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string whenRealized
        {
            get
            {
                return this.whenRealizedField;
            }
            set
            {
                this.whenRealizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string whenReopened
        {
            get
            {
                return this.whenReopenedField;
            }
            set
            {
                this.whenReopenedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string levelOfDetail
        {
            get
            {
                return this.levelOfDetailField;
            }
            set
            {
                this.levelOfDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string changeInPrice
        {
            get
            {
                return this.changeInPriceField;
            }
            set
            {
                this.changeInPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string changeInQuantity
        {
            get
            {
                return this.changeInQuantityField;
            }
            set
            {
                this.changeInQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderType
        {
            get
            {
                return this.orderTypeField;
            }
            set
            {
                this.orderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string traderID
        {
            get
            {
                return this.traderIDField;
            }
            set
            {
                this.traderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isAPIOrder
        {
            get
            {
                return this.isAPIOrderField;
            }
            set
            {
                this.isAPIOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte accruedInt
        {
            get
            {
                return this.accruedIntField;
            }
            set
            {
                this.accruedIntField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementTradesSymbolSummary
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private string currencyField;

        private string fxRateToBaseField;

        private string assetCategoryField;

        private string symbolField;

        private string descriptionField;

        private uint conidField;

        private string securityIDField;

        private string securityIDTypeField;

        private string cusipField;

        private string isinField;

        private string listingExchangeField;

        private string underlyingConidField;

        private string underlyingSymbolField;

        private string underlyingSecurityIDField;

        private string underlyingListingExchangeField;

        private string issuerField;

        private byte multiplierField;

        private string strikeField;

        private string expiryField;

        private string tradeIDField;

        private string putCallField;

        private string reportDateField;

        private string principalAdjustFactorField;

        private string dateTimeField;

        private string serialNumberField;

        private string tradeDateField;

        private string deliveryTypeField;

        private string commodityTypeField;

        private string settleDateTargetField;

        private decimal finenessField;

        private string transactionTypeField;

        private string weightField;

        private string exchangeField;

        private short quantityField;

        private decimal tradePriceField;

        private decimal tradeMoneyField;

        private decimal proceedsField;

        private byte taxesField;

        private decimal ibCommissionField;

        private string ibCommissionCurrencyField;

        private decimal netCashField;

        private string closePriceField;

        private string openCloseIndicatorField;

        private string notesField;

        private decimal costField;

        private byte fifoPnlRealizedField;

        private string fxPnlField;

        private decimal mtmPnlField;

        private string origTradePriceField;

        private string origTradeDateField;

        private string origTradeIDField;

        private string origOrderIDField;

        private string clearingFirmIDField;

        private string transactionIDField;

        private string buySellField;

        private string ibOrderIDField;

        private string ibExecIDField;

        private string brokerageOrderIDField;

        private string orderReferenceField;

        private string volatilityOrderLinkField;

        private string exchOrderIdField;

        private string extExecIDField;

        private string orderTimeField;

        private string openDateTimeField;

        private string holdingPeriodDateTimeField;

        private string whenRealizedField;

        private string whenReopenedField;

        private string levelOfDetailField;

        private string changeInPriceField;

        private string changeInQuantityField;

        private string orderTypeField;

        private string traderIDField;

        private string isAPIOrderField;

        private byte accruedIntField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fxRateToBase
        {
            get
            {
                return this.fxRateToBaseField;
            }
            set
            {
                this.fxRateToBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetCategory
        {
            get
            {
                return this.assetCategoryField;
            }
            set
            {
                this.assetCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint conid
        {
            get
            {
                return this.conidField;
            }
            set
            {
                this.conidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityIDType
        {
            get
            {
                return this.securityIDTypeField;
            }
            set
            {
                this.securityIDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cusip
        {
            get
            {
                return this.cusipField;
            }
            set
            {
                this.cusipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listingExchange
        {
            get
            {
                return this.listingExchangeField;
            }
            set
            {
                this.listingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingConid
        {
            get
            {
                return this.underlyingConidField;
            }
            set
            {
                this.underlyingConidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSymbol
        {
            get
            {
                return this.underlyingSymbolField;
            }
            set
            {
                this.underlyingSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSecurityID
        {
            get
            {
                return this.underlyingSecurityIDField;
            }
            set
            {
                this.underlyingSecurityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingListingExchange
        {
            get
            {
                return this.underlyingListingExchangeField;
            }
            set
            {
                this.underlyingListingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tradeID
        {
            get
            {
                return this.tradeIDField;
            }
            set
            {
                this.tradeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string putCall
        {
            get
            {
                return this.putCallField;
            }
            set
            {
                this.putCallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string reportDate
        {
            get
            {
                return this.reportDateField;
            }
            set
            {
                this.reportDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string principalAdjustFactor
        {
            get
            {
                return this.principalAdjustFactorField;
            }
            set
            {
                this.principalAdjustFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tradeDate
        {
            get
            {
                return this.tradeDateField;
            }
            set
            {
                this.tradeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string commodityType
        {
            get
            {
                return this.commodityTypeField;
            }
            set
            {
                this.commodityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string settleDateTarget
        {
            get
            {
                return this.settleDateTargetField;
            }
            set
            {
                this.settleDateTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transactionType
        {
            get
            {
                return this.transactionTypeField;
            }
            set
            {
                this.transactionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exchange
        {
            get
            {
                return this.exchangeField;
            }
            set
            {
                this.exchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public short quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tradePrice
        {
            get
            {
                return this.tradePriceField;
            }
            set
            {
                this.tradePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tradeMoney
        {
            get
            {
                return this.tradeMoneyField;
            }
            set
            {
                this.tradeMoneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal proceeds
        {
            get
            {
                return this.proceedsField;
            }
            set
            {
                this.proceedsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte taxes
        {
            get
            {
                return this.taxesField;
            }
            set
            {
                this.taxesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ibCommission
        {
            get
            {
                return this.ibCommissionField;
            }
            set
            {
                this.ibCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ibCommissionCurrency
        {
            get
            {
                return this.ibCommissionCurrencyField;
            }
            set
            {
                this.ibCommissionCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal netCash
        {
            get
            {
                return this.netCashField;
            }
            set
            {
                this.netCashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string closePrice
        {
            get
            {
                return this.closePriceField;
            }
            set
            {
                this.closePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string openCloseIndicator
        {
            get
            {
                return this.openCloseIndicatorField;
            }
            set
            {
                this.openCloseIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fifoPnlRealized
        {
            get
            {
                return this.fifoPnlRealizedField;
            }
            set
            {
                this.fifoPnlRealizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fxPnl
        {
            get
            {
                return this.fxPnlField;
            }
            set
            {
                this.fxPnlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal mtmPnl
        {
            get
            {
                return this.mtmPnlField;
            }
            set
            {
                this.mtmPnlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origTradePrice
        {
            get
            {
                return this.origTradePriceField;
            }
            set
            {
                this.origTradePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origTradeDate
        {
            get
            {
                return this.origTradeDateField;
            }
            set
            {
                this.origTradeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origTradeID
        {
            get
            {
                return this.origTradeIDField;
            }
            set
            {
                this.origTradeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origOrderID
        {
            get
            {
                return this.origOrderIDField;
            }
            set
            {
                this.origOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clearingFirmID
        {
            get
            {
                return this.clearingFirmIDField;
            }
            set
            {
                this.clearingFirmIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string buySell
        {
            get
            {
                return this.buySellField;
            }
            set
            {
                this.buySellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ibOrderID
        {
            get
            {
                return this.ibOrderIDField;
            }
            set
            {
                this.ibOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ibExecID
        {
            get
            {
                return this.ibExecIDField;
            }
            set
            {
                this.ibExecIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string brokerageOrderID
        {
            get
            {
                return this.brokerageOrderIDField;
            }
            set
            {
                this.brokerageOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderReference
        {
            get
            {
                return this.orderReferenceField;
            }
            set
            {
                this.orderReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string volatilityOrderLink
        {
            get
            {
                return this.volatilityOrderLinkField;
            }
            set
            {
                this.volatilityOrderLinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exchOrderId
        {
            get
            {
                return this.exchOrderIdField;
            }
            set
            {
                this.exchOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string extExecID
        {
            get
            {
                return this.extExecIDField;
            }
            set
            {
                this.extExecIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderTime
        {
            get
            {
                return this.orderTimeField;
            }
            set
            {
                this.orderTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string openDateTime
        {
            get
            {
                return this.openDateTimeField;
            }
            set
            {
                this.openDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string holdingPeriodDateTime
        {
            get
            {
                return this.holdingPeriodDateTimeField;
            }
            set
            {
                this.holdingPeriodDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string whenRealized
        {
            get
            {
                return this.whenRealizedField;
            }
            set
            {
                this.whenRealizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string whenReopened
        {
            get
            {
                return this.whenReopenedField;
            }
            set
            {
                this.whenReopenedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string levelOfDetail
        {
            get
            {
                return this.levelOfDetailField;
            }
            set
            {
                this.levelOfDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string changeInPrice
        {
            get
            {
                return this.changeInPriceField;
            }
            set
            {
                this.changeInPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string changeInQuantity
        {
            get
            {
                return this.changeInQuantityField;
            }
            set
            {
                this.changeInQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderType
        {
            get
            {
                return this.orderTypeField;
            }
            set
            {
                this.orderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string traderID
        {
            get
            {
                return this.traderIDField;
            }
            set
            {
                this.traderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isAPIOrder
        {
            get
            {
                return this.isAPIOrderField;
            }
            set
            {
                this.isAPIOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte accruedInt
        {
            get
            {
                return this.accruedIntField;
            }
            set
            {
                this.accruedIntField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementTradesTrade
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private string currencyField;

        private byte fxRateToBaseField;

        private string assetCategoryField;

        private string symbolField;

        private string descriptionField;

        private uint conidField;

        private string securityIDField;

        private string securityIDTypeField;

        private string cusipField;

        private string isinField;

        private string listingExchangeField;

        private string underlyingConidField;

        private string underlyingSymbolField;

        private string underlyingSecurityIDField;

        private string underlyingListingExchangeField;

        private string issuerField;

        private byte multiplierField;

        private string strikeField;

        private string expiryField;

        private uint tradeIDField;

        private string putCallField;

        private uint reportDateField;

        private string principalAdjustFactorField;

        private string dateTimeField;

        private string serialNumberField;

        private uint tradeDateField;

        private string deliveryTypeField;

        private string commodityTypeField;

        private uint settleDateTargetField;

        private decimal finenessField;

        private string transactionTypeField;

        private string weightField;

        private string exchangeField;

        private short quantityField;

        private decimal tradePriceField;

        private decimal tradeMoneyField;

        private decimal proceedsField;

        private byte taxesField;

        private decimal ibCommissionField;

        private string ibCommissionCurrencyField;

        private decimal netCashField;

        private decimal closePriceField;

        private string openCloseIndicatorField;

        private string notesField;

        private decimal costField;

        private byte fifoPnlRealizedField;

        private byte fxPnlField;

        private decimal mtmPnlField;

        private byte origTradePriceField;

        private string origTradeDateField;

        private string origTradeIDField;

        private byte origOrderIDField;

        private string clearingFirmIDField;

        private ulong transactionIDField;

        private string buySellField;

        private ulong ibOrderIDField;

        private string ibExecIDField;

        private string brokerageOrderIDField;

        private string orderReferenceField;

        private string volatilityOrderLinkField;

        private string exchOrderIdField;

        private string extExecIDField;

        private string orderTimeField;

        private string openDateTimeField;

        private string holdingPeriodDateTimeField;

        private string whenRealizedField;

        private string whenReopenedField;

        private string levelOfDetailField;

        private byte changeInPriceField;

        private byte changeInQuantityField;

        private string orderTypeField;

        private string traderIDField;

        private string isAPIOrderField;

        private byte accruedIntField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fxRateToBase
        {
            get
            {
                return this.fxRateToBaseField;
            }
            set
            {
                this.fxRateToBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetCategory
        {
            get
            {
                return this.assetCategoryField;
            }
            set
            {
                this.assetCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint conid
        {
            get
            {
                return this.conidField;
            }
            set
            {
                this.conidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityIDType
        {
            get
            {
                return this.securityIDTypeField;
            }
            set
            {
                this.securityIDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cusip
        {
            get
            {
                return this.cusipField;
            }
            set
            {
                this.cusipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listingExchange
        {
            get
            {
                return this.listingExchangeField;
            }
            set
            {
                this.listingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingConid
        {
            get
            {
                return this.underlyingConidField;
            }
            set
            {
                this.underlyingConidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSymbol
        {
            get
            {
                return this.underlyingSymbolField;
            }
            set
            {
                this.underlyingSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSecurityID
        {
            get
            {
                return this.underlyingSecurityIDField;
            }
            set
            {
                this.underlyingSecurityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingListingExchange
        {
            get
            {
                return this.underlyingListingExchangeField;
            }
            set
            {
                this.underlyingListingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint tradeID
        {
            get
            {
                return this.tradeIDField;
            }
            set
            {
                this.tradeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string putCall
        {
            get
            {
                return this.putCallField;
            }
            set
            {
                this.putCallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint reportDate
        {
            get
            {
                return this.reportDateField;
            }
            set
            {
                this.reportDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string principalAdjustFactor
        {
            get
            {
                return this.principalAdjustFactorField;
            }
            set
            {
                this.principalAdjustFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint tradeDate
        {
            get
            {
                return this.tradeDateField;
            }
            set
            {
                this.tradeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string commodityType
        {
            get
            {
                return this.commodityTypeField;
            }
            set
            {
                this.commodityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint settleDateTarget
        {
            get
            {
                return this.settleDateTargetField;
            }
            set
            {
                this.settleDateTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transactionType
        {
            get
            {
                return this.transactionTypeField;
            }
            set
            {
                this.transactionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exchange
        {
            get
            {
                return this.exchangeField;
            }
            set
            {
                this.exchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public short quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tradePrice
        {
            get
            {
                return this.tradePriceField;
            }
            set
            {
                this.tradePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tradeMoney
        {
            get
            {
                return this.tradeMoneyField;
            }
            set
            {
                this.tradeMoneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal proceeds
        {
            get
            {
                return this.proceedsField;
            }
            set
            {
                this.proceedsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte taxes
        {
            get
            {
                return this.taxesField;
            }
            set
            {
                this.taxesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ibCommission
        {
            get
            {
                return this.ibCommissionField;
            }
            set
            {
                this.ibCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ibCommissionCurrency
        {
            get
            {
                return this.ibCommissionCurrencyField;
            }
            set
            {
                this.ibCommissionCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal netCash
        {
            get
            {
                return this.netCashField;
            }
            set
            {
                this.netCashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal closePrice
        {
            get
            {
                return this.closePriceField;
            }
            set
            {
                this.closePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string openCloseIndicator
        {
            get
            {
                return this.openCloseIndicatorField;
            }
            set
            {
                this.openCloseIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fifoPnlRealized
        {
            get
            {
                return this.fifoPnlRealizedField;
            }
            set
            {
                this.fifoPnlRealizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fxPnl
        {
            get
            {
                return this.fxPnlField;
            }
            set
            {
                this.fxPnlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal mtmPnl
        {
            get
            {
                return this.mtmPnlField;
            }
            set
            {
                this.mtmPnlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte origTradePrice
        {
            get
            {
                return this.origTradePriceField;
            }
            set
            {
                this.origTradePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origTradeDate
        {
            get
            {
                return this.origTradeDateField;
            }
            set
            {
                this.origTradeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origTradeID
        {
            get
            {
                return this.origTradeIDField;
            }
            set
            {
                this.origTradeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte origOrderID
        {
            get
            {
                return this.origOrderIDField;
            }
            set
            {
                this.origOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clearingFirmID
        {
            get
            {
                return this.clearingFirmIDField;
            }
            set
            {
                this.clearingFirmIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong transactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string buySell
        {
            get
            {
                return this.buySellField;
            }
            set
            {
                this.buySellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong ibOrderID
        {
            get
            {
                return this.ibOrderIDField;
            }
            set
            {
                this.ibOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ibExecID
        {
            get
            {
                return this.ibExecIDField;
            }
            set
            {
                this.ibExecIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string brokerageOrderID
        {
            get
            {
                return this.brokerageOrderIDField;
            }
            set
            {
                this.brokerageOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderReference
        {
            get
            {
                return this.orderReferenceField;
            }
            set
            {
                this.orderReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string volatilityOrderLink
        {
            get
            {
                return this.volatilityOrderLinkField;
            }
            set
            {
                this.volatilityOrderLinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exchOrderId
        {
            get
            {
                return this.exchOrderIdField;
            }
            set
            {
                this.exchOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string extExecID
        {
            get
            {
                return this.extExecIDField;
            }
            set
            {
                this.extExecIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderTime
        {
            get
            {
                return this.orderTimeField;
            }
            set
            {
                this.orderTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string openDateTime
        {
            get
            {
                return this.openDateTimeField;
            }
            set
            {
                this.openDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string holdingPeriodDateTime
        {
            get
            {
                return this.holdingPeriodDateTimeField;
            }
            set
            {
                this.holdingPeriodDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string whenRealized
        {
            get
            {
                return this.whenRealizedField;
            }
            set
            {
                this.whenRealizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string whenReopened
        {
            get
            {
                return this.whenReopenedField;
            }
            set
            {
                this.whenReopenedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string levelOfDetail
        {
            get
            {
                return this.levelOfDetailField;
            }
            set
            {
                this.levelOfDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte changeInPrice
        {
            get
            {
                return this.changeInPriceField;
            }
            set
            {
                this.changeInPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte changeInQuantity
        {
            get
            {
                return this.changeInQuantityField;
            }
            set
            {
                this.changeInQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderType
        {
            get
            {
                return this.orderTypeField;
            }
            set
            {
                this.orderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string traderID
        {
            get
            {
                return this.traderIDField;
            }
            set
            {
                this.traderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isAPIOrder
        {
            get
            {
                return this.isAPIOrderField;
            }
            set
            {
                this.isAPIOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte accruedInt
        {
            get
            {
                return this.accruedIntField;
            }
            set
            {
                this.accruedIntField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementOptionEAE
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private string currencyField;

        private byte fxRateToBaseField;

        private string assetCategoryField;

        private string symbolField;

        private string descriptionField;

        private uint conidField;

        private string securityIDField;

        private string securityIDTypeField;

        private string cusipField;

        private string isinField;

        private string listingExchangeField;

        private string underlyingConidField;

        private string underlyingSymbolField;

        private string underlyingSecurityIDField;

        private string underlyingListingExchangeField;

        private string issuerField;

        private byte multiplierField;

        private string strikeField;

        private string expiryField;

        private string putCallField;

        private string principalAdjustFactorField;

        private string serialNumberField;

        private string deliveryTypeField;

        private string commodityTypeField;

        private decimal finenessField;

        private string weightField;

        private uint dateField;

        private string transactionTypeField;

        private sbyte quantityField;

        private string tradePriceField;

        private string markPriceField;

        private string proceedsField;

        private decimal commisionsAndTaxField;

        private string costBasisField;

        private decimal realizedPnlField;

        private decimal fxPnlField;

        private string mtmPnlField;

        private uint tradeIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fxRateToBase
        {
            get
            {
                return this.fxRateToBaseField;
            }
            set
            {
                this.fxRateToBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetCategory
        {
            get
            {
                return this.assetCategoryField;
            }
            set
            {
                this.assetCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint conid
        {
            get
            {
                return this.conidField;
            }
            set
            {
                this.conidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityIDType
        {
            get
            {
                return this.securityIDTypeField;
            }
            set
            {
                this.securityIDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cusip
        {
            get
            {
                return this.cusipField;
            }
            set
            {
                this.cusipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listingExchange
        {
            get
            {
                return this.listingExchangeField;
            }
            set
            {
                this.listingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingConid
        {
            get
            {
                return this.underlyingConidField;
            }
            set
            {
                this.underlyingConidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSymbol
        {
            get
            {
                return this.underlyingSymbolField;
            }
            set
            {
                this.underlyingSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSecurityID
        {
            get
            {
                return this.underlyingSecurityIDField;
            }
            set
            {
                this.underlyingSecurityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingListingExchange
        {
            get
            {
                return this.underlyingListingExchangeField;
            }
            set
            {
                this.underlyingListingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string putCall
        {
            get
            {
                return this.putCallField;
            }
            set
            {
                this.putCallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string principalAdjustFactor
        {
            get
            {
                return this.principalAdjustFactorField;
            }
            set
            {
                this.principalAdjustFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string commodityType
        {
            get
            {
                return this.commodityTypeField;
            }
            set
            {
                this.commodityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transactionType
        {
            get
            {
                return this.transactionTypeField;
            }
            set
            {
                this.transactionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tradePrice
        {
            get
            {
                return this.tradePriceField;
            }
            set
            {
                this.tradePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string markPrice
        {
            get
            {
                return this.markPriceField;
            }
            set
            {
                this.markPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string proceeds
        {
            get
            {
                return this.proceedsField;
            }
            set
            {
                this.proceedsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal commisionsAndTax
        {
            get
            {
                return this.commisionsAndTaxField;
            }
            set
            {
                this.commisionsAndTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string costBasis
        {
            get
            {
                return this.costBasisField;
            }
            set
            {
                this.costBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal realizedPnl
        {
            get
            {
                return this.realizedPnlField;
            }
            set
            {
                this.realizedPnlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fxPnl
        {
            get
            {
                return this.fxPnlField;
            }
            set
            {
                this.fxPnlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mtmPnl
        {
            get
            {
                return this.mtmPnlField;
            }
            set
            {
                this.mtmPnlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint tradeID
        {
            get
            {
                return this.tradeIDField;
            }
            set
            {
                this.tradeIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementPriorPeriodPosition
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private string currencyField;

        private byte fxRateToBaseField;

        private string assetCategoryField;

        private string symbolField;

        private string descriptionField;

        private uint conidField;

        private string securityIDField;

        private string securityIDTypeField;

        private string cusipField;

        private string isinField;

        private string listingExchangeField;

        private string underlyingConidField;

        private string underlyingSymbolField;

        private string underlyingSecurityIDField;

        private string underlyingListingExchangeField;

        private string issuerField;

        private byte multiplierField;

        private string strikeField;

        private string expiryField;

        private string putCallField;

        private string principalAdjustFactorField;

        private string serialNumberField;

        private string deliveryTypeField;

        private string commodityTypeField;

        private decimal finenessField;

        private string weightField;

        private uint dateField;

        private decimal priceField;

        private decimal priorMtmPnlField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fxRateToBase
        {
            get
            {
                return this.fxRateToBaseField;
            }
            set
            {
                this.fxRateToBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetCategory
        {
            get
            {
                return this.assetCategoryField;
            }
            set
            {
                this.assetCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint conid
        {
            get
            {
                return this.conidField;
            }
            set
            {
                this.conidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityIDType
        {
            get
            {
                return this.securityIDTypeField;
            }
            set
            {
                this.securityIDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cusip
        {
            get
            {
                return this.cusipField;
            }
            set
            {
                this.cusipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listingExchange
        {
            get
            {
                return this.listingExchangeField;
            }
            set
            {
                this.listingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingConid
        {
            get
            {
                return this.underlyingConidField;
            }
            set
            {
                this.underlyingConidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSymbol
        {
            get
            {
                return this.underlyingSymbolField;
            }
            set
            {
                this.underlyingSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSecurityID
        {
            get
            {
                return this.underlyingSecurityIDField;
            }
            set
            {
                this.underlyingSecurityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingListingExchange
        {
            get
            {
                return this.underlyingListingExchangeField;
            }
            set
            {
                this.underlyingListingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string putCall
        {
            get
            {
                return this.putCallField;
            }
            set
            {
                this.putCallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string principalAdjustFactor
        {
            get
            {
                return this.principalAdjustFactorField;
            }
            set
            {
                this.principalAdjustFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string commodityType
        {
            get
            {
                return this.commodityTypeField;
            }
            set
            {
                this.commodityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal priorMtmPnl
        {
            get
            {
                return this.priorMtmPnlField;
            }
            set
            {
                this.priorMtmPnlField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementCashTransaction
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private string currencyField;

        private byte fxRateToBaseField;

        private string assetCategoryField;

        private string symbolField;

        private string descriptionField;

        private string conidField;

        private string securityIDField;

        private string securityIDTypeField;

        private string cusipField;

        private string isinField;

        private string listingExchangeField;

        private string underlyingConidField;

        private string underlyingSymbolField;

        private string underlyingSecurityIDField;

        private string underlyingListingExchangeField;

        private string issuerField;

        private byte multiplierField;

        private string strikeField;

        private string expiryField;

        private string putCallField;

        private string principalAdjustFactorField;

        private string serialNumberField;

        private string deliveryTypeField;

        private string commodityTypeField;

        private decimal finenessField;

        private string weightField;

        private string dateTimeField;

        private uint settleDateField;

        private decimal amountField;

        private string typeField;

        private string tradeIDField;

        private string codeField;

        private ulong transactionIDField;

        private uint reportDateField;

        private string clientReferenceField;

        private string levelOfDetailField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fxRateToBase
        {
            get
            {
                return this.fxRateToBaseField;
            }
            set
            {
                this.fxRateToBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetCategory
        {
            get
            {
                return this.assetCategoryField;
            }
            set
            {
                this.assetCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string conid
        {
            get
            {
                return this.conidField;
            }
            set
            {
                this.conidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityIDType
        {
            get
            {
                return this.securityIDTypeField;
            }
            set
            {
                this.securityIDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cusip
        {
            get
            {
                return this.cusipField;
            }
            set
            {
                this.cusipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listingExchange
        {
            get
            {
                return this.listingExchangeField;
            }
            set
            {
                this.listingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingConid
        {
            get
            {
                return this.underlyingConidField;
            }
            set
            {
                this.underlyingConidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSymbol
        {
            get
            {
                return this.underlyingSymbolField;
            }
            set
            {
                this.underlyingSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSecurityID
        {
            get
            {
                return this.underlyingSecurityIDField;
            }
            set
            {
                this.underlyingSecurityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingListingExchange
        {
            get
            {
                return this.underlyingListingExchangeField;
            }
            set
            {
                this.underlyingListingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string putCall
        {
            get
            {
                return this.putCallField;
            }
            set
            {
                this.putCallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string principalAdjustFactor
        {
            get
            {
                return this.principalAdjustFactorField;
            }
            set
            {
                this.principalAdjustFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string commodityType
        {
            get
            {
                return this.commodityTypeField;
            }
            set
            {
                this.commodityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint settleDate
        {
            get
            {
                return this.settleDateField;
            }
            set
            {
                this.settleDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tradeID
        {
            get
            {
                return this.tradeIDField;
            }
            set
            {
                this.tradeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong transactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint reportDate
        {
            get
            {
                return this.reportDateField;
            }
            set
            {
                this.reportDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clientReference
        {
            get
            {
                return this.clientReferenceField;
            }
            set
            {
                this.clientReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string levelOfDetail
        {
            get
            {
                return this.levelOfDetailField;
            }
            set
            {
                this.levelOfDetailField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementTransfer
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private string currencyField;

        private byte fxRateToBaseField;

        private string assetCategoryField;

        private string symbolField;

        private string descriptionField;

        private string conidField;

        private string securityIDField;

        private string securityIDTypeField;

        private string cusipField;

        private string isinField;

        private string listingExchangeField;

        private string underlyingConidField;

        private string underlyingSymbolField;

        private string underlyingSecurityIDField;

        private string underlyingListingExchangeField;

        private string issuerField;

        private byte multiplierField;

        private string strikeField;

        private string expiryField;

        private string putCallField;

        private string principalAdjustFactorField;

        private string serialNumberField;

        private string deliveryTypeField;

        private string commodityTypeField;

        private decimal finenessField;

        private string weightField;

        private uint reportDateField;

        private uint dateField;

        private uint dateTimeField;

        private string typeField;

        private string directionField;

        private string companyField;

        private uint accountField;

        private string accountNameField;

        private sbyte quantityField;

        private byte transferPriceField;

        private decimal positionAmountField;

        private decimal positionAmountInBaseField;

        private byte pnlAmountField;

        private byte pnlAmountInBaseField;

        private byte fxPnlField;

        private decimal cashTransferField;

        private string codeField;

        private string clientReferenceField;

        private ulong transactionIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fxRateToBase
        {
            get
            {
                return this.fxRateToBaseField;
            }
            set
            {
                this.fxRateToBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetCategory
        {
            get
            {
                return this.assetCategoryField;
            }
            set
            {
                this.assetCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string conid
        {
            get
            {
                return this.conidField;
            }
            set
            {
                this.conidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityIDType
        {
            get
            {
                return this.securityIDTypeField;
            }
            set
            {
                this.securityIDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cusip
        {
            get
            {
                return this.cusipField;
            }
            set
            {
                this.cusipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listingExchange
        {
            get
            {
                return this.listingExchangeField;
            }
            set
            {
                this.listingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingConid
        {
            get
            {
                return this.underlyingConidField;
            }
            set
            {
                this.underlyingConidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSymbol
        {
            get
            {
                return this.underlyingSymbolField;
            }
            set
            {
                this.underlyingSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSecurityID
        {
            get
            {
                return this.underlyingSecurityIDField;
            }
            set
            {
                this.underlyingSecurityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingListingExchange
        {
            get
            {
                return this.underlyingListingExchangeField;
            }
            set
            {
                this.underlyingListingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string putCall
        {
            get
            {
                return this.putCallField;
            }
            set
            {
                this.putCallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string principalAdjustFactor
        {
            get
            {
                return this.principalAdjustFactorField;
            }
            set
            {
                this.principalAdjustFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string commodityType
        {
            get
            {
                return this.commodityTypeField;
            }
            set
            {
                this.commodityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint reportDate
        {
            get
            {
                return this.reportDateField;
            }
            set
            {
                this.reportDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint dateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint account
        {
            get
            {
                return this.accountField;
            }
            set
            {
                this.accountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountName
        {
            get
            {
                return this.accountNameField;
            }
            set
            {
                this.accountNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte transferPrice
        {
            get
            {
                return this.transferPriceField;
            }
            set
            {
                this.transferPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal positionAmount
        {
            get
            {
                return this.positionAmountField;
            }
            set
            {
                this.positionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal positionAmountInBase
        {
            get
            {
                return this.positionAmountInBaseField;
            }
            set
            {
                this.positionAmountInBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pnlAmount
        {
            get
            {
                return this.pnlAmountField;
            }
            set
            {
                this.pnlAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pnlAmountInBase
        {
            get
            {
                return this.pnlAmountInBaseField;
            }
            set
            {
                this.pnlAmountInBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fxPnl
        {
            get
            {
                return this.fxPnlField;
            }
            set
            {
                this.fxPnlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cashTransfer
        {
            get
            {
                return this.cashTransferField;
            }
            set
            {
                this.cashTransferField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clientReference
        {
            get
            {
                return this.clientReferenceField;
            }
            set
            {
                this.clientReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong transactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementChangeInDividendAccrual
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private string currencyField;

        private byte fxRateToBaseField;

        private string assetCategoryField;

        private string symbolField;

        private string descriptionField;

        private uint conidField;

        private string securityIDField;

        private string securityIDTypeField;

        private string cusipField;

        private string isinField;

        private string listingExchangeField;

        private string underlyingConidField;

        private string underlyingSymbolField;

        private string underlyingSecurityIDField;

        private string underlyingListingExchangeField;

        private string issuerField;

        private byte multiplierField;

        private string strikeField;

        private string expiryField;

        private string putCallField;

        private string principalAdjustFactorField;

        private string serialNumberField;

        private string deliveryTypeField;

        private string commodityTypeField;

        private decimal finenessField;

        private string weightField;

        private uint reportDateField;

        private uint dateField;

        private uint exDateField;

        private uint payDateField;

        private ushort quantityField;

        private byte taxField;

        private byte feeField;

        private decimal grossRateField;

        private decimal grossAmountField;

        private decimal netAmountField;

        private string codeField;

        private string fromAcctField;

        private string toAcctField;

        private string levelOfDetailField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fxRateToBase
        {
            get
            {
                return this.fxRateToBaseField;
            }
            set
            {
                this.fxRateToBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetCategory
        {
            get
            {
                return this.assetCategoryField;
            }
            set
            {
                this.assetCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint conid
        {
            get
            {
                return this.conidField;
            }
            set
            {
                this.conidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityIDType
        {
            get
            {
                return this.securityIDTypeField;
            }
            set
            {
                this.securityIDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cusip
        {
            get
            {
                return this.cusipField;
            }
            set
            {
                this.cusipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listingExchange
        {
            get
            {
                return this.listingExchangeField;
            }
            set
            {
                this.listingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingConid
        {
            get
            {
                return this.underlyingConidField;
            }
            set
            {
                this.underlyingConidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSymbol
        {
            get
            {
                return this.underlyingSymbolField;
            }
            set
            {
                this.underlyingSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSecurityID
        {
            get
            {
                return this.underlyingSecurityIDField;
            }
            set
            {
                this.underlyingSecurityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingListingExchange
        {
            get
            {
                return this.underlyingListingExchangeField;
            }
            set
            {
                this.underlyingListingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string putCall
        {
            get
            {
                return this.putCallField;
            }
            set
            {
                this.putCallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string principalAdjustFactor
        {
            get
            {
                return this.principalAdjustFactorField;
            }
            set
            {
                this.principalAdjustFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string commodityType
        {
            get
            {
                return this.commodityTypeField;
            }
            set
            {
                this.commodityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint reportDate
        {
            get
            {
                return this.reportDateField;
            }
            set
            {
                this.reportDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint exDate
        {
            get
            {
                return this.exDateField;
            }
            set
            {
                this.exDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint payDate
        {
            get
            {
                return this.payDateField;
            }
            set
            {
                this.payDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fee
        {
            get
            {
                return this.feeField;
            }
            set
            {
                this.feeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal grossRate
        {
            get
            {
                return this.grossRateField;
            }
            set
            {
                this.grossRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal grossAmount
        {
            get
            {
                return this.grossAmountField;
            }
            set
            {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal netAmount
        {
            get
            {
                return this.netAmountField;
            }
            set
            {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fromAcct
        {
            get
            {
                return this.fromAcctField;
            }
            set
            {
                this.fromAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string toAcct
        {
            get
            {
                return this.toAcctField;
            }
            set
            {
                this.toAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string levelOfDetail
        {
            get
            {
                return this.levelOfDetailField;
            }
            set
            {
                this.levelOfDetailField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementOpenDividendAccrual
    {

        private string accountIdField;

        private string acctAliasField;

        private string modelField;

        private string currencyField;

        private byte fxRateToBaseField;

        private string assetCategoryField;

        private string symbolField;

        private string descriptionField;

        private ushort conidField;

        private string securityIDField;

        private string securityIDTypeField;

        private uint cusipField;

        private string isinField;

        private string listingExchangeField;

        private string underlyingConidField;

        private string underlyingSymbolField;

        private string underlyingSecurityIDField;

        private string underlyingListingExchangeField;

        private string issuerField;

        private byte multiplierField;

        private string strikeField;

        private string expiryField;

        private string putCallField;

        private string principalAdjustFactorField;

        private string serialNumberField;

        private string deliveryTypeField;

        private string commodityTypeField;

        private decimal finenessField;

        private string weightField;

        private uint exDateField;

        private uint payDateField;

        private byte quantityField;

        private byte taxField;

        private byte feeField;

        private decimal grossRateField;

        private decimal grossAmountField;

        private decimal netAmountField;

        private string codeField;

        private string fromAcctField;

        private string toAcctField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountId
        {
            get
            {
                return this.accountIdField;
            }
            set
            {
                this.accountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string acctAlias
        {
            get
            {
                return this.acctAliasField;
            }
            set
            {
                this.acctAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fxRateToBase
        {
            get
            {
                return this.fxRateToBaseField;
            }
            set
            {
                this.fxRateToBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetCategory
        {
            get
            {
                return this.assetCategoryField;
            }
            set
            {
                this.assetCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort conid
        {
            get
            {
                return this.conidField;
            }
            set
            {
                this.conidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityIDType
        {
            get
            {
                return this.securityIDTypeField;
            }
            set
            {
                this.securityIDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint cusip
        {
            get
            {
                return this.cusipField;
            }
            set
            {
                this.cusipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listingExchange
        {
            get
            {
                return this.listingExchangeField;
            }
            set
            {
                this.listingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingConid
        {
            get
            {
                return this.underlyingConidField;
            }
            set
            {
                this.underlyingConidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSymbol
        {
            get
            {
                return this.underlyingSymbolField;
            }
            set
            {
                this.underlyingSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSecurityID
        {
            get
            {
                return this.underlyingSecurityIDField;
            }
            set
            {
                this.underlyingSecurityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingListingExchange
        {
            get
            {
                return this.underlyingListingExchangeField;
            }
            set
            {
                this.underlyingListingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string putCall
        {
            get
            {
                return this.putCallField;
            }
            set
            {
                this.putCallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string principalAdjustFactor
        {
            get
            {
                return this.principalAdjustFactorField;
            }
            set
            {
                this.principalAdjustFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string commodityType
        {
            get
            {
                return this.commodityTypeField;
            }
            set
            {
                this.commodityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint exDate
        {
            get
            {
                return this.exDateField;
            }
            set
            {
                this.exDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint payDate
        {
            get
            {
                return this.payDateField;
            }
            set
            {
                this.payDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fee
        {
            get
            {
                return this.feeField;
            }
            set
            {
                this.feeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal grossRate
        {
            get
            {
                return this.grossRateField;
            }
            set
            {
                this.grossRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal grossAmount
        {
            get
            {
                return this.grossAmountField;
            }
            set
            {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal netAmount
        {
            get
            {
                return this.netAmountField;
            }
            set
            {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fromAcct
        {
            get
            {
                return this.fromAcctField;
            }
            set
            {
                this.fromAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string toAcct
        {
            get
            {
                return this.toAcctField;
            }
            set
            {
                this.toAcctField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlexQueryResponseFlexStatementsFlexStatementSecurityInfo
    {

        private string currencyField;

        private string assetCategoryField;

        private string symbolField;

        private string descriptionField;

        private uint conidField;

        private string securityIDField;

        private string securityIDTypeField;

        private string cusipField;

        private string isinField;

        private string listingExchangeField;

        private string underlyingConidField;

        private string underlyingSymbolField;

        private string underlyingSecurityIDField;

        private string underlyingListingExchangeField;

        private string issuerField;

        private byte multiplierField;

        private string strikeField;

        private string expiryField;

        private string putCallField;

        private string principalAdjustFactorField;

        private string serialNumberField;

        private string deliveryTypeField;

        private string commodityTypeField;

        private decimal finenessField;

        private string weightField;

        private string maturityField;

        private string issueDateField;

        private string underlyingCategoryField;

        private string subCategoryField;

        private string settlementPolicyMethodField;

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assetCategory
        {
            get
            {
                return this.assetCategoryField;
            }
            set
            {
                this.assetCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint conid
        {
            get
            {
                return this.conidField;
            }
            set
            {
                this.conidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string securityIDType
        {
            get
            {
                return this.securityIDTypeField;
            }
            set
            {
                this.securityIDTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cusip
        {
            get
            {
                return this.cusipField;
            }
            set
            {
                this.cusipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isin
        {
            get
            {
                return this.isinField;
            }
            set
            {
                this.isinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string listingExchange
        {
            get
            {
                return this.listingExchangeField;
            }
            set
            {
                this.listingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingConid
        {
            get
            {
                return this.underlyingConidField;
            }
            set
            {
                this.underlyingConidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSymbol
        {
            get
            {
                return this.underlyingSymbolField;
            }
            set
            {
                this.underlyingSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingSecurityID
        {
            get
            {
                return this.underlyingSecurityIDField;
            }
            set
            {
                this.underlyingSecurityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingListingExchange
        {
            get
            {
                return this.underlyingListingExchangeField;
            }
            set
            {
                this.underlyingListingExchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string strike
        {
            get
            {
                return this.strikeField;
            }
            set
            {
                this.strikeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string putCall
        {
            get
            {
                return this.putCallField;
            }
            set
            {
                this.putCallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string principalAdjustFactor
        {
            get
            {
                return this.principalAdjustFactorField;
            }
            set
            {
                this.principalAdjustFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryType
        {
            get
            {
                return this.deliveryTypeField;
            }
            set
            {
                this.deliveryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string commodityType
        {
            get
            {
                return this.commodityTypeField;
            }
            set
            {
                this.commodityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maturity
        {
            get
            {
                return this.maturityField;
            }
            set
            {
                this.maturityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string issueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string underlyingCategory
        {
            get
            {
                return this.underlyingCategoryField;
            }
            set
            {
                this.underlyingCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string subCategory
        {
            get
            {
                return this.subCategoryField;
            }
            set
            {
                this.subCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string settlementPolicyMethod
        {
            get
            {
                return this.settlementPolicyMethodField;
            }
            set
            {
                this.settlementPolicyMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }



}
*/