/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System.Data;

namespace IBNet.Utils;

public class IBType
{
    public IBType(string name, object value)
    {
        Name  = name;
        Value = value;
    }

    public string Name { get; }

    public object Value { get; }

    public override string ToString()
    {
        return Name;
    }
}

public class TriggerMethod
{
    public static object[] GetAll()
    {
        return new object[] { Default, DoubleBidAsk, Last, DoubleLast, BidAsk, LastBidOrAsk, Midpoint };
    }

    public static IBType Default      = new("Default", 0);
    public static IBType DoubleBidAsk = new("DoubleBidAsk", 1);
    public static IBType Last         = new("Last", 2);
    public static IBType DoubleLast   = new("DoubleLast", 3);
    public static IBType BidAsk       = new("BidAsk", 4);
    public static IBType LastBidOrAsk = new("LastBidOrAsk", 5);
    public static IBType Midpoint     = new("Midpoint", 6);
}

public class Rule80A
{
    public static object[] GetAll()
    {
        return new object[]
               {
                   None, Individual, Agency, AgentOtherMember, IndividualPTIA, AgencyPTIA, AgentOtherMemberPTIA,
                   IndividualPT, AgencyPT, AgentOtherMemberPT
               };
    }

    public static IBType None                 = new("None", "");
    public static IBType Individual           = new("Individual", "I");
    public static IBType Agency               = new("Agency", "A");
    public static IBType AgentOtherMember     = new("AgentOtherMember", "W");
    public static IBType IndividualPTIA       = new("IndividualPTIA", "J");
    public static IBType AgencyPTIA           = new("AgencyPTIA", "U");
    public static IBType AgentOtherMemberPTIA = new("AgentOtherMemberPTIA", "M");
    public static IBType IndividualPT         = new("IndividualPT", "K");
    public static IBType AgencyPT             = new("AgencyPT", "Y");
    public static IBType AgentOtherMemberPT   = new("AgentOtherMemberPT", "N");
}

public class OCAType
{
    public static object[] GetAll()
    {
        return new object[] { None, CancelWithBlocking, ReduceWithBlocking, ReduceWithoutBlocking };
    }

    public static IBType None                  = new("None", 0);
    public static IBType CancelWithBlocking    = new("CancelWithBlocking", 1);
    public static IBType ReduceWithBlocking    = new("ReduceWithBlocking", 2);
    public static IBType ReduceWithoutBlocking = new("ReduceWithoutBlocking", 3);
}

public class HedgeType
{
    public static object[] GetAll()
    {
        return new object[] { None, Delta, Beta, Fx, Pair };
    }

    public static IBType None  = new("None", "");
    public static IBType Delta = new("Delta", "D");
    public static IBType Beta  = new("Beta", "B");
    public static IBType Fx    = new("Fx", "F");
    public static IBType Pair  = new("Pair", "P");
}

public class VolatilityType
{
    public static object[] GetAll()
    {
        return new object[] { None, Daily, Annual };
    }

    public static IBType None   = new("None", 0);
    public static IBType Daily  = new("Daily", 1);
    public static IBType Annual = new("Annual", 1);
}

public class ReferencePriceType
{
    public static object[] GetAll()
    {
        return new object[] { None, Midpoint, BidOrAsk };
    }

    public static IBType None     = new("None", 0);
    public static IBType Midpoint = new("Midpoint", 1);
    public static IBType BidOrAsk = new("BidOrAsk", 2);
}

public class FaMethod
{
    public static object[] GetAll()
    {
        return new object[] { None, EqualQuantity, AvailableEquity, NetLiq, PctChange };
    }

    public static IBType None            = new("None", "");
    public static IBType EqualQuantity   = new("EqualQuantity", "EqualQuantity");
    public static IBType AvailableEquity = new("AvailableEquity", "AvailableEquity");
    public static IBType NetLiq          = new("NetLiq", "NetLiq");
    public static IBType PctChange       = new("PctChange", "PctChange");
}

public class ContractRight
{
    public static object[] GetAll()
    {
        return new object[] { None, Put, Call };
    }

    public static IBType None = new("None", "");
    public static IBType Put  = new("Put", "P");
    public static IBType Call = new("Call", "C");
}

public class FundamentalsReport
{
    public static object[] GetAll()
    {
        return new object[] { ReportSnapshot, FinancialSummary, FinStatements, RESC };
    }

    public static IBType ReportSnapshot   = new("Company overview", "ReportSnapshot");
    public static IBType FinancialSummary = new("Financial summary", "ReportsFinSummary");
    public static IBType FinStatements    = new("Financial statements", "ReportsFinStatements");
    public static IBType RESC             = new("Analyst estimates", "RESC");
}

public class FinancialAdvisorDataType
{
    public static object[] GetAll()
    {
        return new object[] { Groups, Profiles, Aliases };
    }

    public static IBType Groups   = new("Groups", 1);
    public static IBType Profiles = new("Profiles", 2);
    public static IBType Aliases  = new("Alias", 3);
}

public class AllocationGroupMethod
{
    //The DataTable will then properly populate the grid's ComboBox cell
    public static DataTable GetAsData()
    {
        DataTable faDefaultMethods = new DataTable();
        faDefaultMethods.Columns.Add(new DataColumn("Name", typeof(string)));
        faDefaultMethods.Columns.Add(new DataColumn("Value", typeof(string)));
        faDefaultMethods.Rows.Add("Equal quantity", "EqualQuantity");
        faDefaultMethods.Rows.Add("Available equity", "AvailableEquity");
        faDefaultMethods.Rows.Add("Net liquidity", "NetLiq");
        faDefaultMethods.Rows.Add("Percent change", "PctChange");
        return faDefaultMethods;
    }

    public static IBType EqualQuantity   = new("Equal quantity", "EqualQuantity");
    public static IBType AvailableEquity = new("Available equity", "AvailableEquity");
    public static IBType NetLiquidity    = new("Net liquidity", "NetLiq");
    public static IBType PercentChange   = new("Percent change", "PctChange");
}

public class AllocationProfileType
{
    public static DataTable GetAsData()
    {
        DataTable allocationProfileTypes = new DataTable();
        allocationProfileTypes.Columns.Add(new DataColumn("Name", typeof(string)));
        allocationProfileTypes.Columns.Add(new DataColumn("Value", typeof(int)));
        allocationProfileTypes.Rows.Add("Percentages", 1);
        allocationProfileTypes.Rows.Add("Financial Ratios", 2);
        allocationProfileTypes.Rows.Add("Shares", 3);
        return allocationProfileTypes;
    }
}

public class MarketDataType
{
    public static object[] GetAll()
    {
        return new object[] { Real_Time, Frozen, Delayed, Delayed_Frozen };
    }

    public static IBType get(int marketDataType)
    {
        IBType ret = Real_Time;
        foreach (object ibType in GetAll())
        {
            if ((int)((IBType)ibType).Value == marketDataType)
            {
                ret = (IBType)ibType;
            }
        }

        return ret;
    }

    public static IBType Real_Time      = new("Real-Time", 1);
    public static IBType Frozen         = new("Frozen", 2);
    public static IBType Delayed        = new("Delayed", 3);
    public static IBType Delayed_Frozen = new("Delayed-Frozen", 4);
}