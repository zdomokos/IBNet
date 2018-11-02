using System;
using System.ComponentModel;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Order  Action Side. Specifies whether securities should be bought or sold.
    /// </summary>
    [Serializable]
    [Flags]
    public enum AccountSummary : long
    {
        AccountType                     = 1 << 0,
        NetLiquidation                  = 1 << 1,
        [Description("Total cash including futures pnl")]
        TotalCashValue                  = 1 << 2,
        [Description("For cash accounts = 1 << 0, this is the same as TotalCashValue")]
        SettledCash                     = 1 << 3,
        [Description("Net accrued interest")]
        AccruedCash                     = 1 << 4,
        [Description("The maximum amount of marginable US stocks the account can buy")]
        BuyingPower                     = 1 << 5,
        [Description("Cash + stocks + bonds + mutual funds")]
        EquityWithLoanValue             = 1 << 6,
        PreviousEquityWithLoanValue     = 1 << 7,
        [Description("The sum of the absolute value of all stock and equity option positions")]
        GrossPositionValue              = 1 << 8,
        RegTEquity                      = 1 << 9,
        RegTMargin                      = 1 <<10,
        [Description("Special Memorandum Account")]
        SMA                             = 1 << 11,
        InitMarginReq                   = 1 << 12,
        MaintMarginReq                  = 1 << 13,
        AvailableFunds                  = 1 << 14,
        ExcessLiquidity                 = 1 << 15,
        [Description("Excess liquidity as a percentage of net liquidation value")]
        Cushion                         = 1 << 16,
        FullInitMarginReq               = 1 << 17,
        FullMaintMarginReq              = 1 << 18,
        FullAvailableFunds              = 1 << 19,
        FullExcessLiquidity             = 1 << 20,
        [Description("Time when look-ahead values take effect")]
        LookAheadNextChange             = 1 << 21,
        LookAheadInitMarginReq          = 1 << 22,
        LookAheadMaintMarginReq         = 1 << 23,
        LookAheadAvailableFunds         = 1 << 24,
        LookAheadExcessLiquidity        = 1 << 25,
        [Description("A measure of how close the account is to liquidation")]
        HighestSeverity                 = 1 << 26,
        [Description("The Number of Open/Close trades a user could put on before Pattern Day Trading is detected. A value of -1 means that the user can put on unlimited day trades.")]
        DayTradesRemaining              = 1 << 27,
        [Description("GrossPositionValue / NetLiquidation")]
        Leverage                        = 1 << 28,
    }
}