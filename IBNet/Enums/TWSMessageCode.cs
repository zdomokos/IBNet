/*
using System;
using Ztg.Common.DataStructures.Enums;

namespace Ztg.Loraq.Broker.IB
{
    /// <summary>
    /// Tws error code table
    /// https://interactivebrokers.github.io/tws-api/message_codes.html
    /// </summary>
    [Serializable]
    public class TWSMessageCode : Enumeration<TWSMessageCode>
    {
        public static TWSMessageCode ErrorMsg0 = new TWSMessageCode(0, nameof(ErrorMsg0), Cat.System, "Error.", "");
    
        // System Message Codes
        public static TWSMessageCode ErrorMsg1100 = new TWSMessageCode(1100, nameof(ErrorMsg1100), Cat.System, "Connectivity between IB and the TWS has been lost.", "Your TWS/IB Gateway has been disconnected from IB servers. This can occur because of an internet connectivity issue, a nightly reset of the IB servers, or a competing session.");
        public static TWSMessageCode ErrorMsg1101 = new TWSMessageCode(1101, nameof(ErrorMsg1101), Cat.System, "Connectivity between IB and TWS has been restored- data lost.*", "The TWS/IB Gateway has successfully reconnected to IB's servers. Your market data requests have been lost and need to be re-submitted.");
        public static TWSMessageCode ErrorMsg1102 = new TWSMessageCode(1102, nameof(ErrorMsg1102), Cat.System, "Connectivity between IB and TWS has been restored- data maintained.", "The TWS/IB Gateway has successfully reconnected to IB's servers. Your market data requests have been recovered and there is no need for you to re-submit them.");
        public static TWSMessageCode ErrorMsg1300 = new TWSMessageCode(1300, nameof(ErrorMsg1300), Cat.System, "TWS socket port has been reset and this connection is being dropped. Please reconnect on the new port - <port_num>", "The port number in the TWS/IBG settings has been changed during an active API connection.");
    
        // Warning Message Codes
        public static TWSMessageCode ErrorMsg2100 = new TWSMessageCode(2100, nameof(ErrorMsg2100), Cat.Warning, "New account data requested from TWS. API client has been unsubscribed from account data.", "The TWS only allows one IBApi.EClient.reqAccountUpdates request at a time. If the client application attempts to subscribe to a second account without canceling the previous subscription, the new request will override the old one and the TWS will send this message notifying so.");
        public static TWSMessageCode ErrorMsg2101 = new TWSMessageCode(2101, nameof(ErrorMsg2101), Cat.Warning, "Unable to subscribe to account as the following clients are subscribed to a different account.", "If a client application invokes IBApi.EClient.reqAccountUpdates when there is an active subscription started by a different client, the TWS will reject the new subscription request with this message.");
        public static TWSMessageCode ErrorMsg2102 = new TWSMessageCode(2102, nameof(ErrorMsg2102), Cat.Warning, "Unable to modify this order as it is still being processed.", "If you attempt to modify an order before it gets processed by the system, the modification will be rejected. Wait until the order has been fully processed before modifying it. See Placing Orders for further details.");
        public static TWSMessageCode ErrorMsg2103 = new TWSMessageCode(2103, nameof(ErrorMsg2103), Cat.Warning, "A market data farm is disconnected.", "Indicates a connectivity problem to an IB server. Outside of the nightly IB server reset, this typically indicates an underlying ISP connectivity issue.");
        public static TWSMessageCode ErrorMsg2104 = new TWSMessageCode(2104, nameof(ErrorMsg2104), Cat.Warning, "Market data farm connection is OK", "A notification that connection to the market data server is ok. This is a notification and not a true error condition, and is expected on first establishing connection.");
        public static TWSMessageCode ErrorMsg2105 = new TWSMessageCode(2105, nameof(ErrorMsg2105), Cat.Warning, "A historical data farm is disconnected.", "Indicates a connectivity problem to an IB server. Outside of the nightly IB server reset, this typically indicates an underlying ISP connectivity issue.");
        public static TWSMessageCode ErrorMsg2106 = new TWSMessageCode(2106, nameof(ErrorMsg2106), Cat.Warning, "A historical data farm is connected.", "A notification that connection to the market data server is ok. This is a notification and not a true error condition, and is expected on first establishing connection.");
        public static TWSMessageCode ErrorMsg2107 = new TWSMessageCode(2107, nameof(ErrorMsg2107), Cat.Warning, "A historical data farm connection has become inactive but should be available upon demand.", "Whenever a connection to the historical data farm is not being used because there is not an active historical data request, the connection will go inactive in IB Gateway. This does not indicate any connectivity issue or problem with IB Gateway. As soon as a historical data request is made the status will change back to active.");
        public static TWSMessageCode ErrorMsg2108 = new TWSMessageCode(2108, nameof(ErrorMsg2108), Cat.Warning, "A market data farm connection has become inactive but should be available upon demand.", "Whenever a connection to our data farms is not needed, it will become dormant. There is nothing abnormal nor wrong with your client application nor with the TWS. You can safely ignore this message.");
        public static TWSMessageCode ErrorMsg2109 = new TWSMessageCode(2109, nameof(ErrorMsg2109), Cat.Warning, "Order Event Warning: Attribute \"Outside Regular Trading Hours\" is ignored based on the order type and destination. PlaceOrder is now processed.", "Indicates the outsideRth flag was set for an order for which there is not a regular vs outside regular trading hour distinction");
        public static TWSMessageCode ErrorMsg2110 = new TWSMessageCode(2110, nameof(ErrorMsg2110), Cat.Warning, "Connectivity between TWS and server is broken. It will be restored automatically.", "Indicates a connectivity problem between TWS or IBG and the IB server. This will usually only occur during the IB nightly server reset; cases at other times indicate a problem in the local ISP connectivity.");
        public static TWSMessageCode ErrorMsg2137 = new TWSMessageCode(2137, nameof(ErrorMsg2137), Cat.Warning, "Cross Side Warning", "This warning message occurs in TWS version 955 and higher. It occurs when an order will change the position in an account from long to short or from short to long. To bypass the warning, a new feature has been added to IB Gateway 956 (or higher) and TWS 957 (or higher) so that once can go to Global Configuration > Messages and disable the \"Cross Side Warning\".");
    
        // Client Error Codes
        public static TWSMessageCode ErrorMsg501 = new TWSMessageCode(501, nameof(ErrorMsg501), Cat.Client, "Already Connected.", "Your client application is already connected to the TWS.");
        public static TWSMessageCode ErrorMsg502 = new TWSMessageCode(502, nameof(ErrorMsg502), Cat.Client, "Couldn't connect to TWS. Confirm that \"Enable ActiveX and Socket Clients\" is enabled and connection port is the same as \"Socket Port\" on the TWS \"Edit->Global Configuration...->API->Settings\" menu.", "When you receive this error message it is either because you have not enabled API connectivity in the TWS and/or you are trying to connect on the wrong port. Refer to the TWS' API Settings as explained in the error message. See also Connectivity");
        public static TWSMessageCode ErrorMsg503 = new TWSMessageCode(503, nameof(ErrorMsg503), Cat.Client, "The TWS is out of date and must be upgraded.", "Indicates TWS or IBG is too old for use with the current API version. Can also be triggered if the TWS version does not support a specific API function.");
        public static TWSMessageCode ErrorMsg504 = new TWSMessageCode(504, nameof(ErrorMsg504), Cat.Client, "Not connected.", "You are trying to perform a request without properly connecting and/or after connection to the TWS has been broken probably due to an unhandled exception within your client application.");
        
        // TWS error codes
        public static TWSMessageCode ErrorMsg100   = new TWSMessageCode(100, nameof(ErrorMsg100), Cat.Tws, "Max rate of messages per second has been exceeded.", "The client application has exceeded the rate of 50 messages/second. The TWS will likely disconnect the client application after this message.");
        public static TWSMessageCode ErrorMsg101   = new TWSMessageCode(101, nameof(ErrorMsg101), Cat.Tws, "Max number of tickers has been reached.", "The current number of active market data subscriptions in TWS and the API altogether has been exceeded. This number is calculated based on a formula which is based on the equity, commissions, and quote booster packs in an account. Active lines can be checked in Tws using the Ctrl-Alt-= combination");
        public static TWSMessageCode ErrorMsg102   = new TWSMessageCode(102, nameof(ErrorMsg102), Cat.Tws, "Duplicate ticker ID.", "A market data request used a ticker ID which is already in use by an active request.");
        public static TWSMessageCode ErrorMsg103   = new TWSMessageCode(103, nameof(ErrorMsg103), Cat.Tws, "Duplicate order ID.", "An order was placed with an order ID that is less than or equal to the order ID of a previous order from this client");
        public static TWSMessageCode ErrorMsg104   = new TWSMessageCode(104, nameof(ErrorMsg104), Cat.Tws, "Can't modify a filled order.", "An attempt was made to modify an order which has already been filled by the system.");
        public static TWSMessageCode ErrorMsg105   = new TWSMessageCode(105, nameof(ErrorMsg105), Cat.Tws, "Order being modified does not match original order.", "An order was placed with an order ID of a currently open order but basic parameters differed (aside from quantity or price fields)");
        public static TWSMessageCode ErrorMsg106   = new TWSMessageCode(106, nameof(ErrorMsg106), Cat.Tws, "Can't transmit order ID:", "");
        public static TWSMessageCode ErrorMsg107   = new TWSMessageCode(107, nameof(ErrorMsg107), Cat.Tws, "Cannot transmit incomplete order.", "Order is missing a required field.");
        public static TWSMessageCode ErrorMsg109   = new TWSMessageCode(109, nameof(ErrorMsg109), Cat.Tws, "Price is out of the range defined by the Percentage setting at order defaults frame. The order will not be transmitted.", "Price entered is outside the range of prices set in TWS or IB Gateway Order Precautionary Settings");
        public static TWSMessageCode ErrorMsg110   = new TWSMessageCode(110, nameof(ErrorMsg110), Cat.Tws, "The price does not conform to the minimum price variation for this contract.", "An entered price field has more digits of precision than is allowed for this particular contract. Minimum increment information can be found on the IB Contracts and Securities Search page.");
        public static TWSMessageCode ErrorMsg111   = new TWSMessageCode(111, nameof(ErrorMsg111), Cat.Tws, "The TIF (Tif type) and the order type are incompatible.", "The time in force specified cannot be used with this order type. Please refer to order tickets in TWS for allowable combinations.");
        public static TWSMessageCode ErrorMsg113   = new TWSMessageCode(113, nameof(ErrorMsg113), Cat.Tws, "The Tif option should be set to DAY for MOC and LOC orders.", "Market-on-close or Limit-on-close orders should be sent with time in force set to 'DAY'");
        public static TWSMessageCode ErrorMsg114   = new TWSMessageCode(114, nameof(ErrorMsg114), Cat.Tws, "Relative orders are valid for stocks only.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg115   = new TWSMessageCode(115, nameof(ErrorMsg115), Cat.Tws, "Relative orders for US stocks can only be submitted to SMART, SMART_ECN, INSTINET, or PRIMEX.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg116   = new TWSMessageCode(116, nameof(ErrorMsg116), Cat.Tws, "The order cannot be transmitted to a dead exchange.", "Exchange field is invalid.");
        public static TWSMessageCode ErrorMsg117   = new TWSMessageCode(117, nameof(ErrorMsg117), Cat.Tws, "The block order size must be at least 50.", "");
        public static TWSMessageCode ErrorMsg118   = new TWSMessageCode(118, nameof(ErrorMsg118), Cat.Tws, "VWAP orders must be routed through the VWAP exchange.", "");
        public static TWSMessageCode ErrorMsg119   = new TWSMessageCode(119, nameof(ErrorMsg119), Cat.Tws, "Only VWAP orders may be placed on the VWAP exchange.", "When an order is routed to the VWAP exchange, the type of the order must be defined as 'VWAP'.");
        public static TWSMessageCode ErrorMsg120   = new TWSMessageCode(120, nameof(ErrorMsg120), Cat.Tws, "It is too late to place a VWAP order for today.", "The cutoff has passed for the current day to place VWAP orders.");
        public static TWSMessageCode ErrorMsg121   = new TWSMessageCode(121, nameof(ErrorMsg121), Cat.Tws, "Invalid BD flag for the order. Check \"Destination\" and \"BD\" flag.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg122   = new TWSMessageCode(122, nameof(ErrorMsg122), Cat.Tws, "No request tag has been found for order:", "");
        public static TWSMessageCode ErrorMsg123   = new TWSMessageCode(123, nameof(ErrorMsg123), Cat.Tws, "No record is available for conid:", "The specified contract ID cannot be found. This error is deprecated.");
        public static TWSMessageCode ErrorMsg124   = new TWSMessageCode(124, nameof(ErrorMsg124), Cat.Tws, "No market rule is available for conid:", "");
        public static TWSMessageCode ErrorMsg125   = new TWSMessageCode(125, nameof(ErrorMsg125), Cat.Tws, "Buy price must be the same as the best asking price.", "");
        public static TWSMessageCode ErrorMsg126   = new TWSMessageCode(126, nameof(ErrorMsg126), Cat.Tws, "Sell price must be the same as the best bidding price.", "");
        public static TWSMessageCode ErrorMsg129   = new TWSMessageCode(129, nameof(ErrorMsg129), Cat.Tws, "VWAP orders must be submitted at least three minutes before the start time.", "The start time specified in the VWAP order is less than 3 minutes after when it is placed.");
        public static TWSMessageCode ErrorMsg131   = new TWSMessageCode(131, nameof(ErrorMsg131), Cat.Tws, "The sweep-to-fill flag and display size are only valid for US stocks routed through SMART, and will be ignored.", "");
        public static TWSMessageCode ErrorMsg132   = new TWSMessageCode(132, nameof(ErrorMsg132), Cat.Tws, "This order cannot be transmitted without a clearing account.", "");
        public static TWSMessageCode ErrorMsg133   = new TWSMessageCode(133, nameof(ErrorMsg133), Cat.Tws, "Submit new order failed.", "");
        public static TWSMessageCode ErrorMsg134   = new TWSMessageCode(134, nameof(ErrorMsg134), Cat.Tws, "Modify order failed.", "");
        public static TWSMessageCode ErrorMsg135   = new TWSMessageCode(135, nameof(ErrorMsg135), Cat.Tws, "Can't find order with ID =", "An attempt was made to cancel an order not currently in the system.");
        public static TWSMessageCode ErrorMsg136   = new TWSMessageCode(136, nameof(ErrorMsg136), Cat.Tws, "This order cannot be cancelled.", "An attempt was made to cancel an order than cannot be cancelled, for instance because");
        public static TWSMessageCode ErrorMsg137   = new TWSMessageCode(137, nameof(ErrorMsg137), Cat.Tws, "VWAP orders can only be cancelled up to three minutes before the start time.", "");
        public static TWSMessageCode ErrorMsg138   = new TWSMessageCode(138, nameof(ErrorMsg138), Cat.Tws, "Could not parse ticker request:", "");
        public static TWSMessageCode ErrorMsg139   = new TWSMessageCode(139, nameof(ErrorMsg139), Cat.Tws, "Parsing error:", "Error in command syntax generated parsing error.");
        public static TWSMessageCode ErrorMsg140   = new TWSMessageCode(140, nameof(ErrorMsg140), Cat.Tws, "The size value should be an integer:", "The size field in the Order class has an invalid type.");
        public static TWSMessageCode ErrorMsg141   = new TWSMessageCode(141, nameof(ErrorMsg141), Cat.Tws, "The price value should be a double:", "A price field in the Order type has an invalid type.");
        public static TWSMessageCode ErrorMsg142   = new TWSMessageCode(142, nameof(ErrorMsg142), Cat.Tws, "Institutional customer account does not have account info", "");
        public static TWSMessageCode ErrorMsg143   = new TWSMessageCode(143, nameof(ErrorMsg143), Cat.Tws, "Requested ID is not an integer number.", "The IDs used in API requests must be integer values.");
        public static TWSMessageCode ErrorMsg144   = new TWSMessageCode(144, nameof(ErrorMsg144), Cat.Tws, "Order size does not match total share allocation. To adjust the share allocation, right-click on the order and select â€œModify > Share Allocation.â€�", "");
        public static TWSMessageCode ErrorMsg145   = new TWSMessageCode(145, nameof(ErrorMsg145), Cat.Tws, "Error in validating entry fields -", "An error occurred with the syntax of a request field.");
        public static TWSMessageCode ErrorMsg146   = new TWSMessageCode(146, nameof(ErrorMsg146), Cat.Tws, "Invalid trigger method.", "The trigger method specified for a method such as stop or trail stop was not one of the allowable methods.");
        public static TWSMessageCode ErrorMsg147   = new TWSMessageCode(147, nameof(ErrorMsg147), Cat.Tws, "The conditional contract info is incomplete.", "");
        public static TWSMessageCode ErrorMsg148   = new TWSMessageCode(148, nameof(ErrorMsg148), Cat.Tws, "A conditional order can only be submitted when the order type is set to limit or market.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg151   = new TWSMessageCode(151, nameof(ErrorMsg151), Cat.Tws, "This order cannot be transmitted without a user name.", "In DDE the user name is a required field in the place order command.");
        public static TWSMessageCode ErrorMsg152   = new TWSMessageCode(152, nameof(ErrorMsg152), Cat.Tws, "The \"hidden\" order attribute may not be specified for this order.", "The order in question cannot be placed as a hidden order. See- https://www.interactivebrokers.com/en/index.php?f=596");
        public static TWSMessageCode ErrorMsg153   = new TWSMessageCode(153, nameof(ErrorMsg153), Cat.Tws, "EFPs can only be limit orders.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg154   = new TWSMessageCode(154, nameof(ErrorMsg154), Cat.Tws, "Orders cannot be transmitted for a halted security.", "A security was halted for trading when an order was placed.");
        public static TWSMessageCode ErrorMsg155   = new TWSMessageCode(155, nameof(ErrorMsg155), Cat.Tws, "A sizeOp order must have a user name and account.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg156   = new TWSMessageCode(156, nameof(ErrorMsg156), Cat.Tws, "A SizeOp order must go to IBSX", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg157   = new TWSMessageCode(157, nameof(ErrorMsg157), Cat.Tws, "An order can be EITHER Iceberg or Discretionary. Please remove either the Discretionary amount or the Display size.", "In the Order class extended attributes the fields 'Iceberg' and 'Discretionary' cannot");
        public static TWSMessageCode ErrorMsg158   = new TWSMessageCode(158, nameof(ErrorMsg158), Cat.Tws, "You must specify an offset amount or a percent offset value.", "TRAIL and TRAIL STOP orders must have an absolute offset amount or offset percentage specified.");
        public static TWSMessageCode ErrorMsg159   = new TWSMessageCode(159, nameof(ErrorMsg159), Cat.Tws, "The percent offset value must be between 0% and 100%.", "A percent offset value was specified outside the allowable range of 0% and 100%.");
        public static TWSMessageCode ErrorMsg160   = new TWSMessageCode(160, nameof(ErrorMsg160), Cat.Tws, "The size value cannot be zero.", "The size of an order must be a positive quantity.");
        public static TWSMessageCode ErrorMsg161   = new TWSMessageCode(161, nameof(ErrorMsg161), Cat.Tws, "Cancel attempted when order is not in a cancellable state. Order permId =", "An attempt was made to cancel an order not active at the time.");
        public static TWSMessageCode ErrorMsg162   = new TWSMessageCode(162, nameof(ErrorMsg162), Cat.Tws, "Historical market data Service error message.", "");
        public static TWSMessageCode ErrorMsg163   = new TWSMessageCode(163, nameof(ErrorMsg163), Cat.Tws, "The price specified would violate the percentage constraint specified in the default order settings.", "The order price entered is outside the allowable range specified in the Order Precautionary Settings of TWS or IB Gateway");
        public static TWSMessageCode ErrorMsg164   = new TWSMessageCode(164, nameof(ErrorMsg164), Cat.Tws, "There is no market data to check price percent violations.", "No market data is available for the specified contract to determine whether the specified price is outside the price percent precautionary order setting.");
        public static TWSMessageCode ErrorMsg165   = new TWSMessageCode(165, nameof(ErrorMsg165), Cat.Tws, "Historical market Data Service query message.", "There was an issue with a historical data request, such is no such data in IB's database. Note this message is not specific to the API.");
        public static TWSMessageCode ErrorMsg166   = new TWSMessageCode(166, nameof(ErrorMsg166), Cat.Tws, "HMDS Expired Contract Violation.", "Historical data is not available for the specified expired contract.");
        public static TWSMessageCode ErrorMsg167   = new TWSMessageCode(167, nameof(ErrorMsg167), Cat.Tws, "VWAP order time must be in the future.", "The start time of a VWAP order has already passed.");
        public static TWSMessageCode ErrorMsg168   = new TWSMessageCode(168, nameof(ErrorMsg168), Cat.Tws, "Discretionary amount does not conform to the minimum price variation for this contract.", "The discretionary field is specified with a number of degrees of precision higher than what is allowed for a specified contract.");
        public static TWSMessageCode ErrorMsg200   = new TWSMessageCode(200, nameof(ErrorMsg200), Cat.Tws, "No security definition has been found for the request. The contract description specified for <Symbol> is ambiguous", "The specified contract does not match any in IB's database, usually because of an incorrect or missing parameter.Ambiguity may occur when the contract definition provided is not unique. For some stocks that has the same Symbol, Currency and Exchange, you need to specify the IBApi.Contract.PrimaryExch attribute to avoid ambiguity. Please refer to a sample stock contract here.For futures that has multiple multipliers for the same expiration, You need to specify the IBApi.Contract.Multiplier attribute to avoid ambiguity. Please refer to a sample futures contract here.");
        public static TWSMessageCode ErrorMsg201   = new TWSMessageCode(201, nameof(ErrorMsg201), Cat.Tws, "Order rejected - Reason:", "An attempted order was rejected by the IB servers. See Order Placement Considerations for additional information/considerations for these errors.");
        public static TWSMessageCode ErrorMsg202   = new TWSMessageCode(202, nameof(ErrorMsg202), Cat.Tws, "Order cancelled - Reason:", "An active order on the IB server was cancelled. See Order Placement Considerations for additional information/considerations for these errors.");
        public static TWSMessageCode ErrorMsg203   = new TWSMessageCode(203, nameof(ErrorMsg203), Cat.Tws, "The security <security> is not available or allowed for this account.", "The specified security has a trading restriction with a specific account.");
        public static TWSMessageCode ErrorMsg300   = new TWSMessageCode(300, nameof(ErrorMsg300), Cat.Tws, "Can't find EId with ticker Id:", "An attempt was made to cancel market data for a ticker ID that was not associated with a current subscription. With the DDE API this occurs by clearing the spreadsheet cell.");
        public static TWSMessageCode ErrorMsg301   = new TWSMessageCode(301, nameof(ErrorMsg301), Cat.Tws, "Invalid ticker action:", "");
        public static TWSMessageCode ErrorMsg302   = new TWSMessageCode(302, nameof(ErrorMsg302), Cat.Tws, "Error parsing stop ticker string:", "");
        public static TWSMessageCode ErrorMsg303   = new TWSMessageCode(303, nameof(ErrorMsg303), Cat.Tws, "Invalid action:", "An action field was specified that is not available for the account. For most accounts this is only BUY or SELL. Some institutional accounts also have the options SSHORT or SLONG available.");
        public static TWSMessageCode ErrorMsg304   = new TWSMessageCode(304, nameof(ErrorMsg304), Cat.Tws, "Invalid account value action:", "");
        public static TWSMessageCode ErrorMsg305   = new TWSMessageCode(305, nameof(ErrorMsg305), Cat.Tws, "Request parsing error, the request has been ignored.", "The syntax of a DDE request is invalid.");
        public static TWSMessageCode ErrorMsg306   = new TWSMessageCode(306, nameof(ErrorMsg306), Cat.Tws, "Error processing DDE request:", "An issue with a DDE request prevented it from processing.");
        public static TWSMessageCode ErrorMsg307   = new TWSMessageCode(307, nameof(ErrorMsg307), Cat.Tws, "Invalid request topic:", "The 'topic' field in a DDE request is invalid.");
        public static TWSMessageCode ErrorMsg308   = new TWSMessageCode(308, nameof(ErrorMsg308), Cat.Tws, "Unable to create the 'API' page in TWS as the maximum number of pages already exists.", "An order placed from the API will automatically open a new page in classic TWS, however there are already the maximum number of pages open.");
        public static TWSMessageCode ErrorMsg309   = new TWSMessageCode(309, nameof(ErrorMsg309), Cat.Tws, "Max number (3) of market depth requests has been reached. Note: TWS currently limits users to a maximum of 3 distinct market depth requests. This same restriction applies to API clients, however API clients may make multiple market depth requests for the same security.", "");
        public static TWSMessageCode ErrorMsg310   = new TWSMessageCode(310, nameof(ErrorMsg310), Cat.Tws, "Can't find the subscribed market depth with tickerId:", "An attempt was made to cancel market depth for a ticker not currently active.");
        public static TWSMessageCode ErrorMsg311   = new TWSMessageCode(311, nameof(ErrorMsg311), Cat.Tws, "The origin is invalid.", "The origin field specified in the Order class is invalid.");
        public static TWSMessageCode ErrorMsg312   = new TWSMessageCode(312, nameof(ErrorMsg312), Cat.Tws, "The combo details are invalid.", "Combination contract specified has invalid parameters.");
        public static TWSMessageCode ErrorMsg313   = new TWSMessageCode(313, nameof(ErrorMsg313), Cat.Tws, "The combo details for leg '<leg number>' are invalid.", "A combo leg was not defined correctly.");
        public static TWSMessageCode ErrorMsg314   = new TWSMessageCode(314, nameof(ErrorMsg314), Cat.Tws, "Security type 'BAG' requires combo leg details.", "When specifying security type as 'BAG' make sure to also add combo legs with details.");
        public static TWSMessageCode ErrorMsg315   = new TWSMessageCode(315, nameof(ErrorMsg315), Cat.Tws, "Stock combo legs are restricted to SMART order routing.", "Make sure to specify 'SMART' as an exchange when using stock combo contracts.");
        public static TWSMessageCode ErrorMsg316   = new TWSMessageCode(316, nameof(ErrorMsg316), Cat.Tws, "Market depth data has been HALTED. Please re-subscribe.", "You need to re-subscribe to start receiving market depth data again.");
        public static TWSMessageCode ErrorMsg317   = new TWSMessageCode(317, nameof(ErrorMsg317), Cat.Tws, "Market depth data has been RESET. Please empty deep book contents before applying any new entries.", "");
        public static TWSMessageCode ErrorMsg319   = new TWSMessageCode(319, nameof(ErrorMsg319), Cat.Tws, "Invalid log level <log level>", "Make sure that you are setting a log level to a value in range of 1 to 5.");
        public static TWSMessageCode ErrorMsg320   = new TWSMessageCode(320, nameof(ErrorMsg320), Cat.Tws, "Server error when reading an API client request.", "");
        public static TWSMessageCode ErrorMsg321   = new TWSMessageCode(321, nameof(ErrorMsg321), Cat.Tws, "Server error when validating an API client request.", "");
        public static TWSMessageCode ErrorMsg322   = new TWSMessageCode(322, nameof(ErrorMsg322), Cat.Tws, "Server error when processing an API client request.", "");
        public static TWSMessageCode ErrorMsg323   = new TWSMessageCode(323, nameof(ErrorMsg323), Cat.Tws, "Server error: cause - s", "");
        public static TWSMessageCode ErrorMsg324   = new TWSMessageCode(324, nameof(ErrorMsg324), Cat.Tws, "Server error when reading a DDE client request (missing information).", "Make sure that you have specified all the needed information for your request.");
        public static TWSMessageCode ErrorMsg325   = new TWSMessageCode(325, nameof(ErrorMsg325), Cat.Tws, "Discretionary orders are not supported for this combination of exchange and order type.", "Make sure that you are specifying a valid combination of exchange and order type for the discretionary order.");
        public static TWSMessageCode ErrorMsg326   = new TWSMessageCode(326, nameof(ErrorMsg326), Cat.Tws, "Unable to connect as the client id is already in use. Retry with a unique client id.", "Another client application is already connected with the specified client id.");
        public static TWSMessageCode ErrorMsg327   = new TWSMessageCode(327, nameof(ErrorMsg327), Cat.Tws, "Only API connections with clientId set to 0 can set the auto bind TWS orders property.", "");
        public static TWSMessageCode ErrorMsg328   = new TWSMessageCode(328, nameof(ErrorMsg328), Cat.Tws, "Trailing stop orders can be attached to limit or stop-limit orders only.", "Indicates attempt to attach trail stop to order which was not a limit or stop-limit.");
        public static TWSMessageCode ErrorMsg329   = new TWSMessageCode(329, nameof(ErrorMsg329), Cat.Tws, "Order modify failed. Cannot change to the new order type.", "You are not allowed to modify initial order type to the specific order type you are using.");
        public static TWSMessageCode ErrorMsg330   = new TWSMessageCode(330, nameof(ErrorMsg330), Cat.Tws, "Only FA or STL customers can request managed accounts list.", "Make sure that your account type is either FA or STL.");
        public static TWSMessageCode ErrorMsg331   = new TWSMessageCode(331, nameof(ErrorMsg331), Cat.Tws, "Internal error. FA or STL does not have any managed accounts.", "You do not have any managed accounts.");
        public static TWSMessageCode ErrorMsg332   = new TWSMessageCode(332, nameof(ErrorMsg332), Cat.Tws, "The account codes for the order profile are invalid.", "You need to check that the account codes you specified for your request are valid.");
        public static TWSMessageCode ErrorMsg333   = new TWSMessageCode(333, nameof(ErrorMsg333), Cat.Tws, "Invalid share allocation syntax.", "");
        public static TWSMessageCode ErrorMsg334   = new TWSMessageCode(334, nameof(ErrorMsg334), Cat.Tws, "Invalid Good Till Date order", "Check you order settings.");
        public static TWSMessageCode ErrorMsg335   = new TWSMessageCode(335, nameof(ErrorMsg335), Cat.Tws, "Invalid delta: The delta must be between 0 and 100.", "");
        public static TWSMessageCode ErrorMsg336   = new TWSMessageCode(336, nameof(ErrorMsg336), Cat.Tws, "The time or time zone is invalid. The correct format is hh:mm:ss xxx where xxx is an optionally specified time-zone. E.g.: 15:59:00 EST Note that there is a space between the time and the time zone. If no time zone is specified, local time is assumed.", "");
        public static TWSMessageCode ErrorMsg337   = new TWSMessageCode(337, nameof(ErrorMsg337), Cat.Tws, "The date, time, or time-zone entered is invalid. The correct format is yyyymmdd hh:mm:ss xxx where yyyymmdd and xxx are optional. E.g.: 20031126 15:59:00 ESTNote that there is a space between the date and time, and between the time and time-zone.", "");
        public static TWSMessageCode ErrorMsg338   = new TWSMessageCode(338, nameof(ErrorMsg338), Cat.Tws, "Good After Time orders are currently disabled on this exchange.", "");
        public static TWSMessageCode ErrorMsg339   = new TWSMessageCode(339, nameof(ErrorMsg339), Cat.Tws, "Futures spread are no longer supported. Please use combos instead.", "");
        public static TWSMessageCode ErrorMsg340   = new TWSMessageCode(340, nameof(ErrorMsg340), Cat.Tws, "Invalid improvement amount for box auction strategy.", "");
        public static TWSMessageCode ErrorMsg341   = new TWSMessageCode(341, nameof(ErrorMsg341), Cat.Tws, "Invalid delta. Valid values are from 1 to 100. You can set the delta from the \"Pegged to Stock\" section of the Order Ticket Panel, or by selecting Page/Layout from the main menu and adding the Delta column.", "");
        public static TWSMessageCode ErrorMsg342   = new TWSMessageCode(342, nameof(ErrorMsg342), Cat.Tws, "Pegged order is not supported on this exchange.", "You can review all order types and supported exchanges on the Order Types and Algos page.");
        public static TWSMessageCode ErrorMsg343   = new TWSMessageCode(343, nameof(ErrorMsg343), Cat.Tws, "The date, time, or time-zone entered is invalid. The correct format is yyyymmdd hh:mm:ss xxx", "");
        public static TWSMessageCode ErrorMsg344   = new TWSMessageCode(344, nameof(ErrorMsg344), Cat.Tws, "The account logged into is not a financial advisor account.", "You are trying to perform an action that is only available for the financial advisor account.");
        public static TWSMessageCode ErrorMsg345   = new TWSMessageCode(345, nameof(ErrorMsg345), Cat.Tws, "Generic combo is not supported for FA advisor account.", "");
        public static TWSMessageCode ErrorMsg346   = new TWSMessageCode(346, nameof(ErrorMsg346), Cat.Tws, "Not an institutional account or an away clearing account.", "");
        public static TWSMessageCode ErrorMsg347   = new TWSMessageCode(347, nameof(ErrorMsg347), Cat.Tws, "Short sale slot value must be 1 (broker holds shares) or 2 (delivered from elsewhere).", "Make sure that your slot value is either 1 or 2.");
        public static TWSMessageCode ErrorMsg348   = new TWSMessageCode(348, nameof(ErrorMsg348), Cat.Tws, "Order not a short sale – type must be SSHORT to specify short sale slot.", "Make sure that the action you specified is 'SSHORT'.");
        public static TWSMessageCode ErrorMsg349   = new TWSMessageCode(349, nameof(ErrorMsg349), Cat.Tws, "Generic combo does not support \"Good After\" attribute.", "");
        public static TWSMessageCode ErrorMsg350   = new TWSMessageCode(350, nameof(ErrorMsg350), Cat.Tws, "Minimum quantity is not supported for best combo order.", "");
        public static TWSMessageCode ErrorMsg351   = new TWSMessageCode(351, nameof(ErrorMsg351), Cat.Tws, "The \"Regular Trading Hours only\" flag is not valid for this order.", "");
        public static TWSMessageCode ErrorMsg352   = new TWSMessageCode(352, nameof(ErrorMsg352), Cat.Tws, "Short sale slot value of 2 (delivered from elsewhere) requires location.", "You need to specify designatedLocation for your order.");
        public static TWSMessageCode ErrorMsg353   = new TWSMessageCode(353, nameof(ErrorMsg353), Cat.Tws, "Short sale slot value of 1 requires no location be specified.", "You do not need to specify designatedLocation for your order.");
        public static TWSMessageCode ErrorMsg354   = new TWSMessageCode(354, nameof(ErrorMsg354), Cat.Tws, "Not subscribed to requested market data.", "You do not have live market data available in your account for the specified instruments. For further details please refer to Streaming Market Data.");
        public static TWSMessageCode ErrorMsg355   = new TWSMessageCode(355, nameof(ErrorMsg355), Cat.Tws, "Order size does not conform to market rule.", "Check order size parameters for the specified contract from the TWS Contract Details.");
        public static TWSMessageCode ErrorMsg356   = new TWSMessageCode(356, nameof(ErrorMsg356), Cat.Tws, "Smart-combo order does not support OCA group.", "Remove OCA group from your order.");
        public static TWSMessageCode ErrorMsg357   = new TWSMessageCode(357, nameof(ErrorMsg357), Cat.Tws, "Your client version is out of date.", "");
        public static TWSMessageCode ErrorMsg358   = new TWSMessageCode(358, nameof(ErrorMsg358), Cat.Tws, "Smart combo child order not supported.", "");
        public static TWSMessageCode ErrorMsg359   = new TWSMessageCode(359, nameof(ErrorMsg359), Cat.Tws, "Combo order only supports reduce on fill without block(OCA).", "");
        public static TWSMessageCode ErrorMsg360   = new TWSMessageCode(360, nameof(ErrorMsg360), Cat.Tws, "No whatif check support for smart combo order.", "Pre-trade commissions and margin information is not available for this type of order.");
        public static TWSMessageCode ErrorMsg361   = new TWSMessageCode(361, nameof(ErrorMsg361), Cat.Tws, "Invalid trigger price.", "");
        public static TWSMessageCode ErrorMsg362   = new TWSMessageCode(362, nameof(ErrorMsg362), Cat.Tws, "Invalid adjusted stop price.", "");
        public static TWSMessageCode ErrorMsg363   = new TWSMessageCode(363, nameof(ErrorMsg363), Cat.Tws, "Invalid adjusted stop limit price.", "");
        public static TWSMessageCode ErrorMsg364   = new TWSMessageCode(364, nameof(ErrorMsg364), Cat.Tws, "Invalid adjusted trailing amount.", "");
        public static TWSMessageCode ErrorMsg365   = new TWSMessageCode(365, nameof(ErrorMsg365), Cat.Tws, "No scanner subscription found for ticker id:", "Scanner market data subscription request with this ticker id has either been cancelled or is not found.");
        public static TWSMessageCode ErrorMsg366   = new TWSMessageCode(366, nameof(ErrorMsg366), Cat.Tws, "No historical data query found for ticker id:", "Historical market data request with this ticker id has either been cancelled or is not found.");
        public static TWSMessageCode ErrorMsg367   = new TWSMessageCode(367, nameof(ErrorMsg367), Cat.Tws, "Volatility type if set must be 1 or 2 for VOL orders. Do not set it for other order types.", "");
        public static TWSMessageCode ErrorMsg368   = new TWSMessageCode(368, nameof(ErrorMsg368), Cat.Tws, "Reference Price Type must be 1 or 2 for dynamic volatility management. Do not set it for non-VOL orders.", "");
        public static TWSMessageCode ErrorMsg369   = new TWSMessageCode(369, nameof(ErrorMsg369), Cat.Tws, "Volatility orders are only valid for US options.", "Make sure that you are placing an order for US OPT contract.");
        public static TWSMessageCode ErrorMsg370   = new TWSMessageCode(370, nameof(ErrorMsg370), Cat.Tws, "Dynamic Volatility orders must be SMART routed, or trade on a Price Improvement Exchange.", "");
        public static TWSMessageCode ErrorMsg371   = new TWSMessageCode(371, nameof(ErrorMsg371), Cat.Tws, "VOL order requires positive floating point value for volatility. Do not set it for other order types.", "");
        public static TWSMessageCode ErrorMsg372   = new TWSMessageCode(372, nameof(ErrorMsg372), Cat.Tws, "Cannot set dynamic VOL attribute on non-VOL order.", "Make sure that your order type is 'VOL'.");
        public static TWSMessageCode ErrorMsg373   = new TWSMessageCode(373, nameof(ErrorMsg373), Cat.Tws, "Can only set stock range attribute on VOL or RELATIVE TO STOCK order.", "");
        public static TWSMessageCode ErrorMsg374   = new TWSMessageCode(374, nameof(ErrorMsg374), Cat.Tws, "If both are set, the lower stock range attribute must be less than the upper stock range attribute.", "");
        public static TWSMessageCode ErrorMsg375   = new TWSMessageCode(375, nameof(ErrorMsg375), Cat.Tws, "Stock range attributes cannot be negative.", "");
        public static TWSMessageCode ErrorMsg376   = new TWSMessageCode(376, nameof(ErrorMsg376), Cat.Tws, "The order is not eligible for continuous update. The option must trade on a cheap-to-reroute exchange.", "");
        public static TWSMessageCode ErrorMsg377   = new TWSMessageCode(377, nameof(ErrorMsg377), Cat.Tws, "Must specify valid delta hedge order aux. price.", "");
        public static TWSMessageCode ErrorMsg378   = new TWSMessageCode(378, nameof(ErrorMsg378), Cat.Tws, "Delta hedge order type requires delta hedge aux. price to be specified.", "Make sure your order has delta attribute.");
        public static TWSMessageCode ErrorMsg379   = new TWSMessageCode(379, nameof(ErrorMsg379), Cat.Tws, "Delta hedge order type requires that no delta hedge aux. price be specified.", "Make sure you do not specify aux. delta hedge price.");
        public static TWSMessageCode ErrorMsg380   = new TWSMessageCode(380, nameof(ErrorMsg380), Cat.Tws, "This order type is not allowed for delta hedge orders.", "Limit, Market or Relative orders are supported.");
        public static TWSMessageCode ErrorMsg381   = new TWSMessageCode(381, nameof(ErrorMsg381), Cat.Tws, "Your DDE.dll needs to be upgraded.", "");
        public static TWSMessageCode ErrorMsg382   = new TWSMessageCode(382, nameof(ErrorMsg382), Cat.Tws, "The price specified violates the number of ticks constraint specified in the default order settings.", "");
        public static TWSMessageCode ErrorMsg383   = new TWSMessageCode(383, nameof(ErrorMsg383), Cat.Tws, "The size specified violates the size constraint specified in the default order settings.", "");
        public static TWSMessageCode ErrorMsg384   = new TWSMessageCode(384, nameof(ErrorMsg384), Cat.Tws, "Invalid DDE array request.", "");
        public static TWSMessageCode ErrorMsg385   = new TWSMessageCode(385, nameof(ErrorMsg385), Cat.Tws, "Duplicate ticker ID for API scanner subscription.", "Make sure you are using a unique ticker ID for your new scanner subscription.");
        public static TWSMessageCode ErrorMsg386   = new TWSMessageCode(386, nameof(ErrorMsg386), Cat.Tws, "Duplicate ticker ID for API historical data query.", "Make sure you are using a unique ticker ID for your new historical market data query.");
        public static TWSMessageCode ErrorMsg387   = new TWSMessageCode(387, nameof(ErrorMsg387), Cat.Tws, "Unsupported order type for this exchange and security type.", "You can review all order types and supported exchanges on the Order Types and Algos page.");
        public static TWSMessageCode ErrorMsg388   = new TWSMessageCode(388, nameof(ErrorMsg388), Cat.Tws, "Order size is smaller than the minimum requirement.", "Check order size parameters for the specified contract from the TWS Contract Details.");
        public static TWSMessageCode ErrorMsg389   = new TWSMessageCode(389, nameof(ErrorMsg389), Cat.Tws, "Supplied routed order ID is not unique.", "");
        public static TWSMessageCode ErrorMsg390   = new TWSMessageCode(390, nameof(ErrorMsg390), Cat.Tws, "Supplied routed order ID is invalid.", "");
        public static TWSMessageCode ErrorMsg391   = new TWSMessageCode(391, nameof(ErrorMsg391), Cat.Tws, "The time or time-zone entered is invalid. The correct format is hh:mm:ss xxx", "");
        public static TWSMessageCode ErrorMsg392   = new TWSMessageCode(392, nameof(ErrorMsg392), Cat.Tws, "Invalid order: contract expired.", "You can not place an order for the expired contract.");
        public static TWSMessageCode ErrorMsg393   = new TWSMessageCode(393, nameof(ErrorMsg393), Cat.Tws, "Short sale slot may be specified for delta hedge orders only.", "");
        public static TWSMessageCode ErrorMsg394   = new TWSMessageCode(394, nameof(ErrorMsg394), Cat.Tws, "Invalid Process Time: must be integer number of milliseconds between 100 and 2000. Found:", "");
        public static TWSMessageCode ErrorMsg395   = new TWSMessageCode(395, nameof(ErrorMsg395), Cat.Tws, "Due to system problems, orders with OCA groups are currently not being accepted.", "Check TWS bulletins for more information.");
        public static TWSMessageCode ErrorMsg396   = new TWSMessageCode(396, nameof(ErrorMsg396), Cat.Tws, "Due to system problems, application is currently accepting only Market and Limit orders for this contract.", "Check TWS bulletins for more information.");
        public static TWSMessageCode ErrorMsg397   = new TWSMessageCode(397, nameof(ErrorMsg397), Cat.Tws, "Due to system problems, application is currently accepting only Market and Limit orders for this contract.", "");
        public static TWSMessageCode ErrorMsg398   = new TWSMessageCode(398, nameof(ErrorMsg398), Cat.Tws, "< > cannot be used as a condition trigger.", "Please make sure that you specify a valid condition");
        public static TWSMessageCode ErrorMsg399   = new TWSMessageCode(399, nameof(ErrorMsg399), Cat.Tws, "Order message error", "");
        public static TWSMessageCode ErrorMsg400   = new TWSMessageCode(400, nameof(ErrorMsg400), Cat.Tws, "Algo order error.", "");
        public static TWSMessageCode ErrorMsg401   = new TWSMessageCode(401, nameof(ErrorMsg401), Cat.Tws, "Length restriction.", "");
        public static TWSMessageCode ErrorMsg402   = new TWSMessageCode(402, nameof(ErrorMsg402), Cat.Tws, "Conditions are not allowed for this contract.", "Condition order type does not support for this contract");
        public static TWSMessageCode ErrorMsg403   = new TWSMessageCode(403, nameof(ErrorMsg403), Cat.Tws, "Invalid stop price.", "The Stop Price you specified for the order is invalid for the contract");
        public static TWSMessageCode ErrorMsg404   = new TWSMessageCode(404, nameof(ErrorMsg404), Cat.Tws, "Shares for this order are not immediately available for short sale. The order will be held while we attempt to locate the shares.", "You order is held by the TWS because you are trying to sell a contract but you do not have any long position and the market does not have short sale available. You order will be transmitted once there is short sale available on the market");
        public static TWSMessageCode ErrorMsg405   = new TWSMessageCode(405, nameof(ErrorMsg405), Cat.Tws, "The child order quantity should be equivalent to the parent order size.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg406   = new TWSMessageCode(406, nameof(ErrorMsg406), Cat.Tws, "The currency < > is not allowed.", "Please specify a valid currency");
        public static TWSMessageCode ErrorMsg407   = new TWSMessageCode(407, nameof(ErrorMsg407), Cat.Tws, "The symbol should contain valid non-unicode characters only.", "Please check your contract Symbol");
        public static TWSMessageCode ErrorMsg408   = new TWSMessageCode(408, nameof(ErrorMsg408), Cat.Tws, "Invalid scale order increment.", "");
        public static TWSMessageCode ErrorMsg409   = new TWSMessageCode(409, nameof(ErrorMsg409), Cat.Tws, "Invalid scale order. You must specify order component size.", "ScaleInitLevelSize specified is invalid");
        public static TWSMessageCode ErrorMsg410   = new TWSMessageCode(410, nameof(ErrorMsg410), Cat.Tws, "Invalid subsequent component size for scale order.", "ScaleSubsLevelSize specified is invalid");
        public static TWSMessageCode ErrorMsg411   = new TWSMessageCode(411, nameof(ErrorMsg411), Cat.Tws, "The \"Outside Regular Trading Hours\" flag is not valid for this order.", "Trading outside of regular trading hours is not available for this security");
        public static TWSMessageCode ErrorMsg412   = new TWSMessageCode(412, nameof(ErrorMsg412), Cat.Tws, "The contract is not available for trading.", "");
        public static TWSMessageCode ErrorMsg413   = new TWSMessageCode(413, nameof(ErrorMsg413), Cat.Tws, "What-if order should have the transmit flag set to true.", "You need to set IBApi.Order.Transmit to TRUE");
        public static TWSMessageCode ErrorMsg414   = new TWSMessageCode(414, nameof(ErrorMsg414), Cat.Tws, "Snapshot market data subscription is not applicable to generic ticks.", "You must leave Generic Tick List to be empty when requesting snapshot market data");
        public static TWSMessageCode ErrorMsg415   = new TWSMessageCode(415, nameof(ErrorMsg415), Cat.Tws, "Wait until previous RFQ finishes and try again.", "");
        public static TWSMessageCode ErrorMsg416   = new TWSMessageCode(416, nameof(ErrorMsg416), Cat.Tws, "RFQ is not applicable for the contract. Order ID:", "");
        public static TWSMessageCode ErrorMsg417   = new TWSMessageCode(417, nameof(ErrorMsg417), Cat.Tws, "Invalid initial component size for scale order.", "ScaleInitLevelSize specified is invalid");
        public static TWSMessageCode ErrorMsg418   = new TWSMessageCode(418, nameof(ErrorMsg418), Cat.Tws, "Invalid scale order profit offset.", "ScaleProfitOffset specified is invalid");
        public static TWSMessageCode ErrorMsg419   = new TWSMessageCode(419, nameof(ErrorMsg419), Cat.Tws, "Missing initial component size for scale order.", "You need to specify the ScaleInitLevelSize");
        public static TWSMessageCode ErrorMsg420   = new TWSMessageCode(420, nameof(ErrorMsg420), Cat.Tws, "Invalid real-time query.", "Information about pacing violations");
        public static TWSMessageCode ErrorMsg421   = new TWSMessageCode(421, nameof(ErrorMsg421), Cat.Tws, "Invalid route.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg422   = new TWSMessageCode(422, nameof(ErrorMsg422), Cat.Tws, "The account and clearing attributes on this order may not be changed.", "");
        public static TWSMessageCode ErrorMsg423   = new TWSMessageCode(423, nameof(ErrorMsg423), Cat.Tws, "Cross order RFQ has been expired. THI committed size is no longer available. Please open order dialog and verify liquidity allocation.", "");
        public static TWSMessageCode ErrorMsg424   = new TWSMessageCode(424, nameof(ErrorMsg424), Cat.Tws, "FA Order requires allocation to be specified.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg425   = new TWSMessageCode(425, nameof(ErrorMsg425), Cat.Tws, "FA Order requires per-account manual allocations because there is no common clearing instruction. Please use order dialog Adviser tab to enter the allocation.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg426   = new TWSMessageCode(426, nameof(ErrorMsg426), Cat.Tws, "None of the accounts have enough shares.", "You are not able to enter short position with Cash Account");
        public static TWSMessageCode ErrorMsg427   = new TWSMessageCode(427, nameof(ErrorMsg427), Cat.Tws, "Mutual Fund order requires monetary value to be specified.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg428   = new TWSMessageCode(428, nameof(ErrorMsg428), Cat.Tws, "Mutual Fund Sell order requires shares to be specified.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg429   = new TWSMessageCode(429, nameof(ErrorMsg429), Cat.Tws, "Delta neutral orders are only supported for combos (BAG security type).", "");
        public static TWSMessageCode ErrorMsg430   = new TWSMessageCode(430, nameof(ErrorMsg430), Cat.Tws, "We are sorry, but fundamentals data for the security specified is not available.", "");
        public static TWSMessageCode ErrorMsg431   = new TWSMessageCode(431, nameof(ErrorMsg431), Cat.Tws, "What to show field is missing or incorrect.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg432   = new TWSMessageCode(432, nameof(ErrorMsg432), Cat.Tws, "Commission must not be negative.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg433   = new TWSMessageCode(433, nameof(ErrorMsg433), Cat.Tws, "Invalid \"Restore size after taking profit\" for multiple account allocation scale order.", "");
        public static TWSMessageCode ErrorMsg434   = new TWSMessageCode(434, nameof(ErrorMsg434), Cat.Tws, "The order size cannot be zero.", "");
        public static TWSMessageCode ErrorMsg435   = new TWSMessageCode(435, nameof(ErrorMsg435), Cat.Tws, "You must specify an account.", "The function you invoked only works on a single account");
        public static TWSMessageCode ErrorMsg436   = new TWSMessageCode(436, nameof(ErrorMsg436), Cat.Tws, "You must specify an allocation (either a single account, group, or profile).", "When you try to place an order with a Financial Advisor account, you must specify the order to be routed to either a single account, a group, or a profile.");
        public static TWSMessageCode ErrorMsg437   = new TWSMessageCode(437, nameof(ErrorMsg437), Cat.Tws, "Order can have only one flag Outside RTH or Allow PreOpen.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg438   = new TWSMessageCode(438, nameof(ErrorMsg438), Cat.Tws, "The application is now locked.", "This error is deprecated.");
        public static TWSMessageCode ErrorMsg439   = new TWSMessageCode(439, nameof(ErrorMsg439), Cat.Tws, "Order processing failed. Algorithm definition not found.", "Please double check your specification for IBApi.Order.AlgoStrategy and IBApi.Order.AlgoParams");
        public static TWSMessageCode ErrorMsg440   = new TWSMessageCode(440, nameof(ErrorMsg440), Cat.Tws, "Order modify failed. Algorithm cannot be modified.", "");
        public static TWSMessageCode ErrorMsg441   = new TWSMessageCode(441, nameof(ErrorMsg441), Cat.Tws, "Algo attributes validation failed:", "Please double check your specification for IBApi.Order.AlgoStrategy and IBApi.Order.AlgoParams");
        public static TWSMessageCode ErrorMsg442   = new TWSMessageCode(442, nameof(ErrorMsg442), Cat.Tws, "Specified algorithm is not allowed for this order.", "");
        public static TWSMessageCode ErrorMsg443   = new TWSMessageCode(443, nameof(ErrorMsg443), Cat.Tws, "Order processing failed. Unknown algo attribute.", "Specification for IBApi.Order.AlgoParams is incorrect");
        public static TWSMessageCode ErrorMsg444   = new TWSMessageCode(444, nameof(ErrorMsg444), Cat.Tws, "Volatility Combo order is not yet acknowledged. Cannot submit changes at this time.", "The order is not in a state that is able to be modified");
        public static TWSMessageCode ErrorMsg445   = new TWSMessageCode(445, nameof(ErrorMsg445), Cat.Tws, "The RFQ for this order is no longer valid.", "");
        public static TWSMessageCode ErrorMsg446   = new TWSMessageCode(446, nameof(ErrorMsg446), Cat.Tws, "Missing scale order profit offset.", "ScaleProfitOffset is not properly specified");
        public static TWSMessageCode ErrorMsg447   = new TWSMessageCode(447, nameof(ErrorMsg447), Cat.Tws, "Missing scale price adjustment amount or interval.", "ScalePriceAdjustValue or ScalePriceAdjustInterval is not specified properly");
        public static TWSMessageCode ErrorMsg448   = new TWSMessageCode(448, nameof(ErrorMsg448), Cat.Tws, "Invalid scale price adjustment interval.", "ScalePriceAdjustInterval specified is invalid");
        public static TWSMessageCode ErrorMsg449   = new TWSMessageCode(449, nameof(ErrorMsg449), Cat.Tws, "Unexpected scale price adjustment amount or interval.", "ScalePriceAdjustValue or ScalePriceAdjustInterval specified is invalid");
        public static TWSMessageCode ErrorMsg507   = new TWSMessageCode(507, nameof(ErrorMsg507), Cat.Tws, "Bad Message Length (Java-only)", "Indicates EOF exception was caught while reading from the socket. This can occur if there is an attempt to connect to TWS with a client ID that is already in use, or if TWS is locked, closes, or breaks the connection. It should be handled by the client application and used to indicate that the socket connection is not valid.");
        public static TWSMessageCode ErrorMsg10000 = new TWSMessageCode(10000, nameof(ErrorMsg10000), Cat.Tws, "Cross currency combo error.", "");
        public static TWSMessageCode ErrorMsg10001 = new TWSMessageCode(10001, nameof(ErrorMsg10001), Cat.Tws, "Cross currency vol error.", "");
        public static TWSMessageCode ErrorMsg10002 = new TWSMessageCode(10002, nameof(ErrorMsg10002), Cat.Tws, "Invalid non-guaranteed legs.", "");
        public static TWSMessageCode ErrorMsg10003 = new TWSMessageCode(10003, nameof(ErrorMsg10003), Cat.Tws, "IBSX not allowed.", "");
        public static TWSMessageCode ErrorMsg10005 = new TWSMessageCode(10005, nameof(ErrorMsg10005), Cat.Tws, "Read-only models.", "");
        public static TWSMessageCode ErrorMsg10006 = new TWSMessageCode(10006, nameof(ErrorMsg10006), Cat.Tws, "Missing parent order.", "The parent order ID specified cannot be found. In some cases this can occur with bracket orders if the child order is placed immediately after the parent order; a brief pause of 50 ms or less will be necessary before the child order is transmitted to TWS/IBG.");
        public static TWSMessageCode ErrorMsg10007 = new TWSMessageCode(10007, nameof(ErrorMsg10007), Cat.Tws, "Invalid hedge type.", "");
        public static TWSMessageCode ErrorMsg10008 = new TWSMessageCode(10008, nameof(ErrorMsg10008), Cat.Tws, "Invalid beta value.", "");
        public static TWSMessageCode ErrorMsg10009 = new TWSMessageCode(10009, nameof(ErrorMsg10009), Cat.Tws, "Invalid hedge ratio.", "");
        public static TWSMessageCode ErrorMsg10010 = new TWSMessageCode(10010, nameof(ErrorMsg10010), Cat.Tws, "Invalid delta hedge order.", "");
        public static TWSMessageCode ErrorMsg10011 = new TWSMessageCode(10011, nameof(ErrorMsg10011), Cat.Tws, "Currency is not supported for Smart combo.", "");
        public static TWSMessageCode ErrorMsg10012 = new TWSMessageCode(10012, nameof(ErrorMsg10012), Cat.Tws, "Invalid allocation percentage", "FaPercentage specified is not valid");
        public static TWSMessageCode ErrorMsg10013 = new TWSMessageCode(10013, nameof(ErrorMsg10013), Cat.Tws, "Smart routing API error (Smart routing opt-out required).", "");
        public static TWSMessageCode ErrorMsg10014 = new TWSMessageCode(10014, nameof(ErrorMsg10014), Cat.Tws, "PctChange limits.", "This error is deprecated");
        public static TWSMessageCode ErrorMsg10015 = new TWSMessageCode(10015, nameof(ErrorMsg10015), Cat.Tws, "Trading is not allowed in the API.", "");
        public static TWSMessageCode ErrorMsg10016 = new TWSMessageCode(10016, nameof(ErrorMsg10016), Cat.Tws, "Contract is not visible.", "This error is deprecated");
        public static TWSMessageCode ErrorMsg10017 = new TWSMessageCode(10017, nameof(ErrorMsg10017), Cat.Tws, "Contracts are not visible.", "This error is deprecated");
        public static TWSMessageCode ErrorMsg10018 = new TWSMessageCode(10018, nameof(ErrorMsg10018), Cat.Tws, "Orders use EV warning.", "");
        public static TWSMessageCode ErrorMsg10019 = new TWSMessageCode(10019, nameof(ErrorMsg10019), Cat.Tws, "Trades use EV warning.", "");
        public static TWSMessageCode ErrorMsg10020 = new TWSMessageCode(10020, nameof(ErrorMsg10020), Cat.Tws, "Display size should be smaller than order size./td>", "The display size should be smaller than the total quantity");
        public static TWSMessageCode ErrorMsg10021 = new TWSMessageCode(10021, nameof(ErrorMsg10021), Cat.Tws, "Invalid leg2 to Mkt Offset API.", "This error is deprecated");
        public static TWSMessageCode ErrorMsg10022 = new TWSMessageCode(10022, nameof(ErrorMsg10022), Cat.Tws, "Invalid Leg Prio API.", "This error is deprecated");
        public static TWSMessageCode ErrorMsg10023 = new TWSMessageCode(10023, nameof(ErrorMsg10023), Cat.Tws, "Invalid combo display size API.", "This error is deprecated");
        public static TWSMessageCode ErrorMsg10024 = new TWSMessageCode(10024, nameof(ErrorMsg10024), Cat.Tws, "Invalid don't start next legin API.", "This error is deprecated");
        public static TWSMessageCode ErrorMsg10025 = new TWSMessageCode(10025, nameof(ErrorMsg10025), Cat.Tws, "Invalid leg2 to Mkt time1 API.", "This error is deprecated");
        public static TWSMessageCode ErrorMsg10026 = new TWSMessageCode(10026, nameof(ErrorMsg10026), Cat.Tws, "Invalid leg2 to Mkt time2 API.", "This error is deprecated");
        public static TWSMessageCode ErrorMsg10027 = new TWSMessageCode(10027, nameof(ErrorMsg10027), Cat.Tws, "Invalid combo routing tag API.", "This error is deprecated");
        public static TWSMessageCode ErrorMsg10090 = new TWSMessageCode(10090, nameof(ErrorMsg10090), Cat.Tws, "Part of requested market data is not subscribed.", "Indicates that some tick types requested require additional market data subscriptions not held in the account. This commonly occurs for instance if a user has options subscriptions but not the underlying stock so the system cannot calculate the real time greek values (other default ticks will be returned). Or alternatively, if generic tick types are specified in a market data request without the associated subscriptions.");
        public static TWSMessageCode ErrorMsg10148 = new TWSMessageCode(10148, nameof(ErrorMsg10148), Cat.Tws, "OrderId <OrderId> that needs to be cancelled can not be cancelled, state:", "An attempt was made to cancel an order that had already been filled by the system.");
        public static TWSMessageCode ErrorMsg10186 = new TWSMessageCode(10186, nameof(ErrorMsg10186), Cat.Tws, "Requested market data is not subscribed. Delayed market data is not enabled", "See Market Data Types on how to enable delayed data.");
        public static TWSMessageCode ErrorMsg10225 = new TWSMessageCode(10225, nameof(ErrorMsg10225), Cat.Tws, "Bust event occurred, current subscription is deactivated. Please resubscribe real-time bars immediately", "");
        public static TWSMessageCode ErrorMsg10230 = new TWSMessageCode(10230, nameof(ErrorMsg10230), Cat.Tws, "You have unsaved FA changes. Please retry 'request FA' operation later, when 'replace FA' operation is complete", "There are pending Financial Advisor configuration changes. See Financial Advisors");
        public static TWSMessageCode ErrorMsg10231 = new TWSMessageCode(10231, nameof(ErrorMsg10231), Cat.Tws, "The following Groups and/or Profiles contain invalid accounts: <list of groups/profiles>", "If the account(s) inside Groups or Profiles is/are incorrect in xml-formatted configuration string of replaceFA request, then the error shows list of such Groups and/or Profiles.");
        public static TWSMessageCode ErrorMsg10233 = new TWSMessageCode(10233, nameof(ErrorMsg10233), Cat.Tws, "Defaults were inherited from CASH preset during the creation of this order.", "");
        public static TWSMessageCode ErrorMsg10234 = new TWSMessageCode(10234, nameof(ErrorMsg10234), Cat.Tws, "The Decision Maker field is required and not set for this order (non-desktop).", "");
        public static TWSMessageCode ErrorMsg10235 = new TWSMessageCode(10235, nameof(ErrorMsg10235), Cat.Tws, "The Decision Maker field is required and not set for this order (ibbot).", "");
        public static TWSMessageCode ErrorMsg10236 = new TWSMessageCode(10236, nameof(ErrorMsg10236), Cat.Tws, "Child has to be AON if parent order is AON", "");
        public static TWSMessageCode ErrorMsg10237 = new TWSMessageCode(10237, nameof(ErrorMsg10237), Cat.Tws, "All or None ticket can route entire unfilled size only", "");
        public static TWSMessageCode ErrorMsg10238 = new TWSMessageCode(10238, nameof(ErrorMsg10238), Cat.Tws, "Some error occured during communication with Advisor Setup web-app", "");
        public static TWSMessageCode ErrorMsg10239 = new TWSMessageCode(10239, nameof(ErrorMsg10239), Cat.Tws, "This order will affect one or more accounts that are flagged because they do not fit the required risk score criteria prescribed by the group/profile/model allocation.", "");
        public static TWSMessageCode ErrorMsg10240 = new TWSMessageCode(10240, nameof(ErrorMsg10240), Cat.Tws, "You must enter a valid Price Cap.", "");
        public static TWSMessageCode ErrorMsg10241 = new TWSMessageCode(10241, nameof(ErrorMsg10241), Cat.Tws, "Order Quantity is expressed in monetary terms. Modification is not supported via API. Please use desktop version to revise this order.", "");
        public static TWSMessageCode ErrorMsg10242 = new TWSMessageCode(10242, nameof(ErrorMsg10242), Cat.Tws, "Fractional-sized order cannot be modified via API. Please use desktop version to revise this order.", "");
        public static TWSMessageCode ErrorMsg10243 = new TWSMessageCode(10243, nameof(ErrorMsg10243), Cat.Tws, "Fractional-sized order cannot be placed via API. Please use desktop version to place this order.", "");
        public static TWSMessageCode ErrorMsg10244 = new TWSMessageCode(10244, nameof(ErrorMsg10244), Cat.Tws, "Cash Quantity cannot be used for this order", "");
        public static TWSMessageCode ErrorMsg10245 = new TWSMessageCode(10245, nameof(ErrorMsg10245), Cat.Tws, "This financial instrument does not support fractional shares trading", "");
        public static TWSMessageCode ErrorMsg10246 = new TWSMessageCode(10246, nameof(ErrorMsg10246), Cat.Tws, "This order doesn't support fractional shares trading", "");
        public static TWSMessageCode ErrorMsg10247 = new TWSMessageCode(10247, nameof(ErrorMsg10247), Cat.Tws, "Only IB SmartRouting supports fractional shares", "");
        public static TWSMessageCode ErrorMsg10248 = new TWSMessageCode(10248, nameof(ErrorMsg10248), Cat.Tws, "<Account> doesn't have permission to trade fractional shares", "");
        public static TWSMessageCode ErrorMsg10249 = new TWSMessageCode(10249, nameof(ErrorMsg10249), Cat.Tws, "<Order type>=\"\"> order doesn't support fractional shares", "");
        public static TWSMessageCode ErrorMsg10250 = new TWSMessageCode(10250, nameof(ErrorMsg10250), Cat.Tws, "The size does not conform to the minimum variation of for this contract", "");
        public static TWSMessageCode ErrorMsg10251 = new TWSMessageCode(10251, nameof(ErrorMsg10251), Cat.Tws, "Fractional shares are not supported for allocation orders", "");
        public static TWSMessageCode ErrorMsg10252 = new TWSMessageCode(10252, nameof(ErrorMsg10252), Cat.Tws, "This non-close-position order doesn't support fractional shares trading", "");
        public static TWSMessageCode ErrorMsg10253 = new TWSMessageCode(10253, nameof(ErrorMsg10253), Cat.Tws, "Clear Away orders are not supported for multi-leg combo with attached hedge.", "");
        public static TWSMessageCode ErrorMsg10254 = new TWSMessageCode(10254, nameof(ErrorMsg10254), Cat.Tws, "Invalid Order: bond expired", "");
    
        public enum Cat
        {
            System,
            Warning,
            Client,
            Tws,
        }
    
        public TWSMessageCode(int value, string name, Cat t, string message, string notes) : base(value, name)
        {
            Category = t;
            Message  = message;
            Notes    = notes;
        }
    
        public Cat Category { get; }
        public string   Message  { get; }
        public string   Notes    { get; }
        
        public static implicit operator int(TWSMessageCode err)  => err.Value;
        public static explicit operator TWSMessageCode(int code) => FromValue(code);
    }
}
*/
