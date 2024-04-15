using System;
using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Financial Advisor Allocation Method
/// </summary>
[Serializable]
public class FinancialAdvisorAllocationMethod : Enumeration<FinancialAdvisorAllocationMethod, string>
{
    public static FinancialAdvisorAllocationMethod PercentChange   = new("PctChange", nameof(PercentChange));
    public static FinancialAdvisorAllocationMethod AvailableEquity = new("AvailableEquity", nameof(AvailableEquity));
    public static FinancialAdvisorAllocationMethod NetLiquidity    = new("NetLiq", nameof(NetLiquidity));
    public static FinancialAdvisorAllocationMethod EqualQuantity   = new("EqualQuantity", nameof(EqualQuantity));
    public static FinancialAdvisorAllocationMethod None            = new("", nameof(None));

    public FinancialAdvisorAllocationMethod(string value, string name) : base(value, name)
    { }
}