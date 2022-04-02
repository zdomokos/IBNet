using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System;
    using IbFlexReader.Contracts.Attributes;
    using IbFlexReader.Contracts.Enums;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class TradeConfirm : Trade
    {
        [Format(Constants.DateFormat)]
        public DateTime? SettleDate { get; set; }

        public Currencies? CommissionCurrency { get; set; }

        //public string ExchOrderId { get; set; }
        public Notes?  Code                           { get; set; }
        public double? BrokerExecutionCommission      { get; set; }
        public double? BrokerClearingCommission       { get; set; }
        public double? ThirdPartyExecutionCommission  { get; set; }
        public double? ThirdPartyClearingCommission   { get; set; }
        public double? ThirdPartyRegulatoryCommission { get; set; }
        public double? OtherCommission                { get; set; }
        public string  AllocatedTo                    { get; set; }
    }
}
