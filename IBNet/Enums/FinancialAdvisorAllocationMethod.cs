using System;
using Headspring;

namespace IBNet.Enums
{
    /// <summary>
    /// Financial Advisor Allocation Method
    /// </summary>
    [Serializable]
    public class FinancialAdvisorAllocationMethod : Enumeration<FinancialAdvisorAllocationMethod, string>
    {
        public static FinancialAdvisorAllocationMethod PercentChange = new FinancialAdvisorAllocationMethod("PctChange", nameof(PercentChange));
        public static FinancialAdvisorAllocationMethod AvailableEquity = new FinancialAdvisorAllocationMethod("AvailableEquity", nameof(AvailableEquity));
        public static FinancialAdvisorAllocationMethod NetLiquidity = new FinancialAdvisorAllocationMethod("NetLiq", nameof(NetLiquidity));
        public static FinancialAdvisorAllocationMethod EqualQuantity = new FinancialAdvisorAllocationMethod("EqualQuantity", nameof(EqualQuantity));
        public static FinancialAdvisorAllocationMethod None = new FinancialAdvisorAllocationMethod("", nameof(None));

        public FinancialAdvisorAllocationMethod(string value, string name) : base(value, name)
        { }
    }
}
