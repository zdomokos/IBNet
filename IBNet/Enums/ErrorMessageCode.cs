using System;
using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Contains all of the standard Interactive Brokers error messages.
/// </summary>
[Serializable]
public class ErrorMessageCode : Enumeration<ErrorMessageCode, int>
{
    public static ErrorMessageCode Undefined                                = new(0, nameof(Undefined), "");
    public static ErrorMessageCode AlreadyConnected                         = new(501, nameof(AlreadyConnected), "Already connected.");
    public static ErrorMessageCode ConnectFail                              = new(502, nameof(ConnectFail), "Couldn't connect to TWS.  Confirm that \"Enable ActiveX and Socket Clients\" is enabled on the TWS \"Configure->API\" menu.");
    public static ErrorMessageCode UpdateTws                                = new(503, nameof(UpdateTws), "The TWS is out of date and must be upgraded.");
    public static ErrorMessageCode NotConnected                             = new(504, nameof(NotConnected), "Not connected");
    public static ErrorMessageCode UnknownId                                = new(505, nameof(UnknownId), "Fatal Error: Unknown message id.");
    public static ErrorMessageCode FailSendRequestMarket                    = new(510, nameof(FailSendRequestMarket), "Request Market Data Sending Error");
    public static ErrorMessageCode FailSendCancelMarket                     = new(511, nameof(FailSendCancelMarket), "Cancel Market Data Sending Error");
    public static ErrorMessageCode FailSendOrder                            = new(512, nameof(FailSendOrder), "Order Sending Error");
    public static ErrorMessageCode FailSendAccountUpdate                    = new(513, nameof(FailSendAccountUpdate), "Account Update Request Sending Error");
    public static ErrorMessageCode FailSendExecution                        = new(514, nameof(FailSendExecution), "Request For Executions Sending Error");
    public static ErrorMessageCode FailSendCancelOrder                      = new(515, nameof(FailSendCancelOrder), "Cancel Order Sending Error");
    public static ErrorMessageCode FailSendOpenOrder                        = new(516, nameof(FailSendOpenOrder), "Request Open Order Sending Error");
    public static ErrorMessageCode UnknownContract                          = new(517, nameof(UnknownContract), "Unknown contract. Verify the contract details supplied.");
    public static ErrorMessageCode FailSendRequestContract                  = new(518, nameof(FailSendRequestContract), "Request Contract Data Sending Error");
    public static ErrorMessageCode FailSendRequestMarketDepth               = new(519, nameof(FailSendRequestMarketDepth), "Request Market Depth Sending Error");
    public static ErrorMessageCode FailSendCancelMarketDepth                = new(520, nameof(FailSendCancelMarketDepth), "Cancel Market Depth Sending Error");
    public static ErrorMessageCode FailSendServerLogLevel                   = new(521, nameof(FailSendServerLogLevel), "Set Server Log Level Sending Error");
    public static ErrorMessageCode FailSendFARequest                        = new(522, nameof(FailSendFARequest), "FA Information Request Sending Error");
    public static ErrorMessageCode FailSendFAReplace                        = new(523, nameof(FailSendFAReplace), "FA Information Replace Sending Error");
    public static ErrorMessageCode FailSendRequestScanner                   = new(524, nameof(FailSendRequestScanner), "Request Scanner Subscription Sending Error");
    public static ErrorMessageCode FailSendCancelScanner                    = new(525, nameof(FailSendCancelScanner), "Cancel Scanner Subscription Sending Error");
    public static ErrorMessageCode FailSendRequestScannerParameters         = new(526, nameof(FailSendRequestScannerParameters), "Request Scanner Parameter Sending Error");
    public static ErrorMessageCode FailSendRequestHistoricalData            = new(527, nameof(FailSendRequestHistoricalData), "Request Historical Data Sending Error");
    public static ErrorMessageCode FailSendCancelHistoricalData             = new(528, nameof(FailSendCancelHistoricalData), "Cancel Historical Data Sending Error");
    public static ErrorMessageCode FailSendRequestRealTimeBars              = new(529, nameof(FailSendRequestRealTimeBars), "Request Real-time Bar Data Sending Error");
    public static ErrorMessageCode FailSendCancelRealTimeBars               = new(530, nameof(FailSendCancelRealTimeBars), "Cancel Real-time Bar Data Sending Error");
    public static ErrorMessageCode FailSendRequestCurrentTime               = new(531, nameof(FailSendRequestCurrentTime), "Request Current Time Sending Error");
    public static ErrorMessageCode FailSendRequestFundData                  = new(532, nameof(FailSendRequestFundData), "Request Fundamental Data Sending Error");
    public static ErrorMessageCode FailSendCancelFundData                   = new(533, nameof(FailSendCancelFundData), "Cancel Fundamental Data Sending Error");
    public static ErrorMessageCode FailSendReqCalcImpliedVolatility         = new(534, nameof(FailSendReqCalcImpliedVolatility), "Request Calculate Implied Volatility Sending Error");
    public static ErrorMessageCode FailSendRequestCalcOptionPrice           = new(535, nameof(FailSendRequestCalcOptionPrice), "Request Calculate Option Price Sending Error");
    public static ErrorMessageCode FailSendCancelCalculateImpliedVolatility = new(536, nameof(FailSendCancelCalculateImpliedVolatility), "Cancel Calculate Implied Volatility Sending Error");
    public static ErrorMessageCode FailSendCancelCalculateOptionPrice       = new(537, nameof(FailSendCancelCalculateOptionPrice), "Cancel Calculate Option Price Sending Error");
    public static ErrorMessageCode FailSendRequestGlobalCancel              = new(538, nameof(FailSendRequestGlobalCancel), "Request Global Cancel Sending Error");
    public static ErrorMessageCode FailSendRequestMarketDataType            = new(539, nameof(FailSendRequestMarketDataType), "Request Market Data Type Sending Error");
    public static ErrorMessageCode NoValidId                                = new(-1, nameof(NoValidId), "No Valid Id");
    public static ErrorMessageCode MarketDataFarmConnectionIsBroken         = new(2103, nameof(MarketDataFarmConnectionIsBroken), "Market data farm connection is broken");
    public static ErrorMessageCode MarketDataFarmConnectionIsOK             = new(2104, nameof(MarketDataFarmConnectionIsOK), "Market data farm connection is OK");
    public static ErrorMessageCode HmdsDataFarmConnectionIsBroken           = new(2105, nameof(HmdsDataFarmConnectionIsBroken), "HMDS data farm connection is broken");
    public static ErrorMessageCode HmdsDataFarmConnectionIsOK               = new(2106, nameof(HmdsDataFarmConnectionIsOK), "HMDS data farm connection is OK");


    public ErrorMessageCode(int value, string name, string message) : base(value, name)
    {
            Message = message;
        }

    public string Message { get; }
}