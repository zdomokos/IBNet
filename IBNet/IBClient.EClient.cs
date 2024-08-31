using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;
using IBApi;
using IBNet.Enums;

namespace IBNet;

/// <summary>
/// Interactive Brokers Client Socket
/// Handles all communications to the TWS.
/// https://interactivebrokers.github.io/tws-api/historical_bars.html
/// </summary>
public partial class IBClient
{
    #region Connectivity

    /// <summary>
    /// Returns the status of the connection to TWS.
    /// </summary>
    public bool Connected => ClientSocket.IsConnected();

    /// <summary>
    /// Returns the version of the TWS instance the API application is connected to
    /// </summary>
    public int ServerVersion => ClientSocket.ServerVersion;

    /// <summary>
    /// Returns the client version of the TWS API
    /// </summary>
    public static int ClientVersion => Constants.ClientVersion;

    /// <summary>
    /// Returns the time the API application made a connection to TWS
    /// </summary>
    public string TwsConnectionTime => ClientSocket.ServerTime;

    /// <summary>
    /// This function must be called before any other. There is no feedback for a successful connection, but a subsequent attempt to connect will return the message "Already connected."
    /// </summary>
    /// <param name="host">host name or IP address of the machine where TWS is running. Leave blank to connect to the local host.</param>
    /// <param name="port">must match the port specified in TWS on the Configure>API>Socket Port field.</param>
    /// <param name="clientId">A number used to identify this client connection. All orders placed/modified from this client will be associated with this client identifier.
    /// Each client MUST connect with a unique clientId.</param>
    public bool Connect(string host, int port, int clientId)
    {
        if (!ClientSocket.IsConnected())
        {
            if (host == null || host.Equals(""))
                host = "127.0.0.1";
            try
            {
                ClientId = clientId;
                ClientSocket.eConnect(host, port, ClientId);

                var reader = new EReader(ClientSocket, _signal);
                reader.Start();

                _messageDispatchThread = new Thread(() =>
                                                    {
                                                        while (ClientSocket.IsConnected())
                                                        {
                                                            _signal.waitForSignal();
                                                            reader.processMsgs();
                                                        }
                                                    })
                                         { IsBackground = true };
                _messageDispatchThread.Start();
            }
            catch (Exception ex)
            {
                ((EWrapper)this).error(ex);
            }
        }
        else
        {
            ClientSocket.eDisconnect();
        }

        return ClientSocket.IsConnected();
    }

    /// <summary>
    /// Call this method to terminate the connections with TWS. Calling this method does not cancel orders that have already been sent.
    /// </summary>
    public void Disconnect()
    {
        lock (this)
        {
            GeneralTracer.WriteLineIf(ibTrace.TraceInfo, "IBClient Disconnect");
            ClientSocket.eDisconnect();
        }
    }

    /// <summary>
    /// Returns the current system time on the server side.
    /// </summary>
    public void RequestCurrentTime()
    {
        lock (this)
            ClientSocket.reqCurrentTime();
    }

    /// <summary>
    /// Returns one next valid Id...
    /// </summary>
    /// <param name="numberOfIds">Has No Effect</param>
    public void RequestIds(int numberOfIds)
    {
        lock (this)
            ClientSocket.reqIds(numberOfIds);
    }

    /// <summary>
    /// The default level is ERROR. Refer to the API logging page for more details.
    /// </summary>
    /// <param name="serverLogLevel">
    /// logLevel - specifies the level of log entry detail used by the server (TWS) when processing API requests. Valid values include: 
    /// 1 = SYSTEM
    /// 2 = ERROR
    /// 3 = WARNING
    /// 4 = INFORMATION
    /// 5 = DETAIL
    /// </param>
    public void SetServerLogLevel(ServerLogLevel serverLogLevel)
    {
        lock (this)
            ClientSocket.setServerLogLevel((int)serverLogLevel);
    }

    #endregion

    #region Financial Instruments

    /// <summary>
    /// Call this function to download all details for a particular underlying. the contract details will be received via the contractDetails() function on the EWrapper.
    /// </summary>
    /// <param name="requestId">Request Id for Contract Details</param>
    /// <param name="contract">summary description of the contract being looked up.</param>
    public void RequestContractDetails(int requestId, Contract contract)
    {
        if (contract == null)
            throw new ArgumentNullException("contract");
        lock (this)
            ClientSocket.reqContractDetails(requestId, contract);
    }

    #endregion

    #region Orders and Executions

    /// <summary>
    /// Call this method to place an order. The order status will be returned by the orderStatus event.
    /// </summary>
    /// <param name="orderId">the order Id. You must specify a unique value. When the order status returns, it will be identified by this tag. This tag is also used when canceling the order.</param>
    /// <param name="contract">this structure contains a description of the contract which is being traded.</param>
    /// <param name="order">this structure contains the details of the order.
    /// Each client MUST connect with a unique clientId.</param>
    public void PlaceOrder(int orderId, Contract contract, Order order)
    {
        if (contract == null)
            throw new ArgumentNullException("contract");
        if (order == null)
            throw new ArgumentNullException("order");
        lock (this)
            ClientSocket.placeOrder(orderId, contract, order);
    }

    /// <summary>
    /// Call this method to cancel an order.
    /// </summary>
    /// <param name="orderId">Call this method to cancel an order.</param>
    public void CancelOrder(int orderId)
    {
        lock (this)
            ClientSocket.cancelOrder(orderId, new OrderCancel());
    }

    /// <summary>
    /// Call this method to request the open orders that were placed from this client. Each open order will be fed back through the openOrder() and orderStatus() functions on the EWrapper.
    /// 
    /// The client with a clientId of "0" will also receive the TWS-owned open orders. These orders will be associated with the client and a new orderId will be generated. This association will persist over multiple API and TWS sessions.
    /// </summary>
    public void RequestOpenOrders()
    {
        lock (this)
            ClientSocket.reqOpenOrders();
    }

    /// <summary>
    /// Call this method to request that newly created TWS orders be implicitly associated with the client. When a new TWS order is created, the order will be associated with the client and fed back through the openOrder() and orderStatus() methods on the EWrapper.
    /// 
    /// TWS orders can only be bound to clients with a clientId of "0".
    /// </summary>
    /// <param name="autoBind">If set to TRUE, newly created TWS orders will be implicitly associated with the client. If set to FALSE, no association will be made.</param>
    public void RequestAutoOpenOrders(bool autoBind)
    {
        lock (this)
            ClientSocket.reqAutoOpenOrders(autoBind);
    }

    /// <summary>
    /// Call this method to request the open orders that were placed from all clients and also from TWS. Each open order will be fed back through the openOrder() and orderStatus() functions on the EWrapper.
    /// 
    /// No association is made between the returned orders and the requesting client.
    /// </summary>
    public void RequestAllOpenOrders()
    {
        lock (this)
            ClientSocket.reqAllOpenOrders();
    }

    /// <summary>
    /// When this method is called, the execution reports that meet the filter criteria are downloaded to the client via the execDetails() method.
    /// </summary>
    /// <param name="requestId">Id of the request</param>
    /// <param name="filter">the filter criteria used to determine which execution reports are returned.</param>
    public void RequestExecutions(int requestId, ExecutionFilter filter)
    {
        if (filter == null)
        {
            filter = new ExecutionFilter(0, "",
                                         DateTime.MinValue.ToString("yyyyMMdd-HH:mm:ss", CultureInfo.InvariantCulture),
                                         "", "", "", "");
        }

        lock (this)
        {
            ClientSocket.reqExecutions(requestId, filter);
        }
    }

    public virtual void RequestGlobalCancel()
    {
        ClientSocket.reqGlobalCancel();
    }

    #endregion

    #region Streaming Market Data

    /// <summary>
    /// Call this method to request market data. The market data will be returned by the tickPrice, tickSize, tickOptionComputation(), tickGeneric(), tickString() and tickEFP() methods.
    /// </summary>
    /// <param name="requestId">the ticker id. Must be a unique value. When the market data returns, it will be identified by this tag. This is also used when canceling the market data.</param>
    /// <param name="contract">this structure contains a description of the contract for which market data is being requested.</param>
    /// <param name="genericTickList">comma delimited list of generic tick types.  Tick types can be found here: (new Generic Tick Types page) </param>
    /// <param name="snapshot">Allows client to request snapshot market data.</param>
    /// <param name="marketDataOff">Market Data Off - used in conjunction with RTVolume Generic tick type causes only volume data to be sent.</param>
    public void RequestMarketData(int requestId, Contract contract, Collection<GenericTickType> genericTickList,
                                  bool snapshot, bool regulatorySnaphsot, List<TagValue> mktDataOptions = null)
    {
        var genList = new StringBuilder();
        if (genericTickList != null)
        {
            foreach (GenericTickType t in genericTickList)
                genList.AppendFormat("{0},", t.DisplayName);
        }

        lock (this)
            ClientSocket.reqMktData(requestId, contract, genList.ToString().Trim(','), snapshot, regulatorySnaphsot,
                                    mktDataOptions);
    }

    public virtual void RequestMarketDataType(int marketDataType)
    {
        ClientSocket.reqMarketDataType(marketDataType);
    }

    /// <summary>
    /// After calling this method, market data for the specified Id will stop flowing.
    /// </summary>
    /// <param name="requestId">the Id that was specified in the call to reqMktData().</param>
    public void CancelMarketData(int requestId)
    {
        lock (this)
            ClientSocket.cancelMktData(requestId);
    }

    public void RequestRealTimeBars(int requestId, Contract contract, int barSize, RealTimeBarType whatToShow,
                                    bool useRth, List<TagValue> realTimeBarsOptions = null)
    {
        lock (this)
            ClientSocket.reqRealTimeBars(requestId, contract, barSize, whatToShow.Value, useRth, realTimeBarsOptions);
    }

    public void CancelRealTimeBars(int requestId)
    {
        lock (this)
            ClientSocket.cancelRealTimeBars(requestId);
    }

    /// <summary>
    /// Call this method to request market depth for a specific contract. The market depth will be returned by the updateMktDepth() and updateMktDepthL2() methods.
    /// </summary>
    /// <param name="requestId">the ticker Id. Must be a unique value. When the market depth data returns, it will be identified by this tag. This is also used when canceling the market depth.</param>
    /// <param name="contract">this structure contains a description of the contract for which market depth data is being requested.</param>
    /// <param name="numberOfRows">specifies the number of market depth rows to return.</param>
    public void RequestMarketDepth(int requestId, Contract contract, int numberOfRows, bool isSmartDepth,
                                   List<TagValue> mktDepthOptions = null)
    {
        if (contract == null)
            throw new ArgumentNullException("contract");
        lock (this)
            ClientSocket.reqMarketDepth(requestId, contract, numberOfRows, isSmartDepth, mktDepthOptions);
    }

    /// <summary>
    /// After calling this method, market depth data for the specified Id will stop flowing.
    /// </summary>
    /// <param name="requestId">the Id that was specified in the call to reqMktDepth().</param>
    public void CancelMarketDepth(int requestId, bool isSmartDepth)
    {
        lock (this)
            ClientSocket.cancelMktDepth(requestId, isSmartDepth);
    }

    #endregion

    #region Historical Market Data

    /// <summary>
    /// Call the reqHistoricalData() method to start receiving historical data results through the historicalData() EWrapper method. 
    /// </summary>
    /// <param name="requestId">the Id for the request. Must be a unique value. When the data is received, it will be identified by this Id. This is also used when canceling the historical data request.</param>
    /// <param name="contract">this structure contains a description of the contract for which market data is being requested.</param>
    /// <param name="endDateTime">Date is sent after a .ToUniversalTime, so make sure the kind property is set correctly, and assumes GMT timezone. Use the format yyyymmdd hh:mm:ss tmz, where the time zone is allowed (optionally) after a space at the end.</param>
    /// <param name="duration">This is the time span the request will cover, and is specified using the format:
    /// <integer /> <unit />, i.e., 1 D, where valid units are:
    /// S (seconds)
    /// D (days)
    /// W (weeks)
    /// M (months)
    /// Y (years)
    /// If no unit is specified, seconds are used. "years" is currently limited to one.
    /// </param>
    /// <param name="barSizeSetting">
    /// specifies the size of the bars that will be returned (within IB/TWS limits). Valid values include:
    /// <param name="useRth">
    /// </param>
    public void RequestHistoricalData(int requestId, Contract contract, DateTime endDateTime, TimeSpan duration,
                                      BarSize barSizeSetting, HistoricalDataType whatToShow, bool useRth)
    {
        DateTime beginDateTime = endDateTime.Subtract(duration);
        TimeSpan period        = endDateTime.Subtract(beginDateTime);
        string   dur;

        double secs = period.TotalSeconds;
        long   unit;

        if (secs < 1)
            throw new ArgumentOutOfRangeException("Period cannot be less than 1 second.");
        if (secs < 86400)
        {
            unit = (long)Math.Ceiling(secs);
            dur  = $"{unit} S";
        }
        else
        {
            double days = secs / 86400;
            unit = (long)Math.Ceiling(days);
            if (unit <= 34)
            {
                dur = $"{unit} D";
            }
            else
            {
                double weeks = days / 7;
                unit = (long)Math.Ceiling(weeks);
                if (unit > 52)
                    throw new ArgumentOutOfRangeException("Period cannot be bigger than 52 weeks.");
                dur = $"{unit} W";
            }
        }


        RequestHistoricalData2(requestId, contract, endDateTime, dur, barSizeSetting, whatToShow, useRth ? 1 : 0,
                               BarTimeFormat.UnixSeconds.Value, false, null);
    }

    public void RequestHistoricalData2(int requestId, Contract contract, DateTime endDateTime, string duration,
                                       BarSize barSizeSetting, HistoricalDataType whatToShow, int useRth,
                                       int formatDate, bool keepUpToDate, List<TagValue> chartOptions)
    {
        string endDT =
            $"{endDateTime.ToUniversalTime().ToString("yyyyMMdd HH:mm:ss", CultureInfo.InvariantCulture)} UTC";
        string barSize = barSizeSetting.Value;
        string wts     = whatToShow.Value;
        lock (this)
            ClientSocket.reqHistoricalData(requestId, contract, endDT, duration, barSize, wts, useRth, formatDate,
                                           keepUpToDate, chartOptions);
    }

    /// <summary>
    /// Call the CancelHistoricalData method to stop receiving historical data results.
    /// </summary>
    /// <param name="requestId">the Id that was specified in the call to <see cref="RequestHistoricalData(int,Contract,DateTime,TimeSpan,BarSize,HistoricalDataType,int)"/>.</param>
    public void CancelHistoricalData(int requestId)
    {
        lock (this)
            ClientSocket.cancelHistoricalData(requestId);
    }

    #endregion

    #region Account & Portfolio Data

    /// <summary>
    /// Call this function to start getting account values, portfolio, and last update time information.
    /// </summary>
    /// <param name="subscribe">If set to TRUE, the client will start receiving account and portfolio updates. If set to FALSE, the client will stop receiving this information.</param>
    /// <param name="acctCode">the account code for which to receive account and portfolio updates.</param>
    public void RequestAccountUpdates(bool subscribe, string acctCode)
    {
        lock (this)
            ClientSocket.reqAccountUpdates(subscribe, acctCode);
    }

    /// <summary>
    /// Requests a specific account's summary.
    /// This method will subscribe to the account summary as presented in the TWS' Account Summary tab. The data is returned at EWrapper::accountSummary
    /// </summary>
    /// <param name="reqId">the unique request idntifier.</param>
    /// <param name="group">set to "All" to return account summary data for all accounts, or set to a specific Advisor Account Group name that has already been created in TWS Global Configuration.</param>
    /// <param name="summaryItems">flags of AccountSummary items.</param>
    /// <seealso cref="CancelAccountSummary"/>
    public virtual void RequestAccountSummary(int reqId, string group, AccountSummary summaryItems)
    {
        var sb     = new StringBuilder();
        var values = Enum.GetValues(typeof(AccountSummary)).Cast<AccountSummary>();
        foreach (AccountSummary si in values)
        {
            if (summaryItems.HasFlag(si))
                sb.Append($"{si},");
        }

        if (sb.Length > 0)
        {
            string tags = sb.ToString().Trim(',');
            ClientSocket.reqAccountSummary(reqId, group, tags);
        }
    }

    /// <summary>
    /// Cancels the account's summary request. After requesting an account's summary, invoke this function to cancel it.
    /// </summary>
    /// <param name="reqId">the identifier of the previously performed account request</param>
    /// <seealso cref="RequestAccountSummary"/>
    public virtual void CancelAccountSummary(int reqId)
    {
        ClientSocket.cancelAccountSummary(reqId);
    }

    /// <summary>
    /// Requests all positions from all accounts
    /// </summary>
    /// <seealso cref="CancelPositions"/>
    public virtual void RequestPositions()
    {
        ClientSocket.reqPositions();
    }

    /// <summary>
    /// Cancels all account's positions request
    /// </summary>
    /// <seealso cref="RequestPositions"/>
    public virtual void CancelPositions()
    {
        ClientSocket.cancelPositions();
    }

    #endregion

    #region Options

    /// <summary>
    /// Call the exerciseOptions() method to exercise options. 
    /// "SMART" is not an allowed exchange in exerciseOptions() calls, and that TWS does a moneyness request for the position in question whenever any API initiated exercise or lapse is attempted.
    /// </summary>
    /// <param name="requestId">the Id for the exercise request.</param>
    /// <param name="contract">this structure contains a description of the contract to be exercised.  If no multiplier is specified, a default of 100 is assumed.</param>
    /// <param name="exerciseAction">this can have two values:
    /// 1 = specifies exercise
    /// 2 = specifies lapse
    /// </param>
    /// <param name="exerciseQuantity">the number of contracts to be exercised</param>
    /// <param name="account">specifies whether your setting will override the system's natural action. For example, if your action is "exercise" and the option is not in-the-money, by natural action the option would not exercise. If you have override set to "yes" the natural action would be overridden and the out-of-the money option would be exercised. Values are: 
    /// 0 = no
    /// 1 = yes
    /// </param>
    /// <param name="overrideRenamed">
    /// specifies whether your setting will override the system's natural action. For example, if your action is "exercise" and the option is not in-the-money, by natural action the option would not exercise. If you have override set to "yes" the natural action would be overridden and the out-of-the money option would be exercised. Values are: 
    /// 0 = no
    /// 1 = yes
    /// </param>
    public void ExerciseOptions(int requestId, Contract contract, int exerciseAction, int exerciseQuantity,
                                string account, int overrideRenamed)
    {
        if (contract == null)
            throw new ArgumentNullException("contract");
        lock (this)
            ClientSocket.exerciseOptions(requestId, contract, exerciseAction, exerciseQuantity, account,
                                         overrideRenamed, "", "", false);
    }

    public virtual void RequestCalculateOptionPrice(int reqId, Contract contract, double volatility, double underPrice)
    {
        ClientSocket.calculateOptionPrice(reqId, contract, volatility, underPrice, null);
    }

    public virtual void CancelCalculateOptionPrice(int reqId)
    {
        ClientSocket.cancelCalculateOptionPrice(reqId);
    }

    /// <summary>
    /// Calculates the Implied Volatility based on the user-supplied option and underlying prices.
    /// The calculated implied volatility is returned by tickOptionComputation( ) in a new tick type, CUST_OPTION_COMPUTATION, which is described below.
    /// </summary>
    /// <param name="requestId">Request Id</param>
    /// <param name="contract">Contract</param>
    /// <param name="optionPrice">Price of the option</param>
    /// <param name="underPrice">Price of teh underlying of the option</param>
    public virtual void RequestCalculateImpliedVolatility(int requestId, Contract contract, double optionPrice,
                                                          double underPrice)
    {
        lock (this)
            ClientSocket.calculateImpliedVolatility(requestId, contract, optionPrice, underPrice, null);
    }

    public virtual void CancelCalculateImpliedVolatility(int reqId)
    {
        ClientSocket.cancelCalculateImpliedVolatility(reqId);
    }

    #endregion

    #region Financial Advisors

    /// <summary>
    /// Call this method to request the list of managed accounts. The list will be returned by the managedAccounts() function on the EWrapper.
    /// 
    /// This request can only be made when connected to a Financial Advisor (FA) account.
    /// </summary>
    public void RequestManagedAccts()
    {
        lock (this)
            ClientSocket.reqManagedAccts();
    }

    /// <summary>
    /// Call this method to request FA configuration information from TWS. The data returns in an XML string via the receiveFA() method.
    /// </summary>
    /// <param name="faDataType">
    /// faDataType - specifies the type of Financial Advisor configuration data being requested. Valid values include:
    /// 1 = GROUPS
    /// 2 = PROFILE
    /// 3 =ACCOUNT ALIASES
    /// </param>
    public void RequestFA(FADataType faDataType)
    {
        lock (this)
            ClientSocket.requestFA(faDataType.Value);
    }

    /// <summary>
    /// Call this method to request FA configuration information from TWS. The data returns in an XML string via a "receiveFA" ActiveX event.  
    /// </summary>
    /// <param name="requestId">Request Id</param>
    /// <param name="faDataType">
    /// specifies the type of Financial Advisor configuration data being requested. Valid values include:
    /// 1 = GROUPS
    /// 2 = PROFILE
    /// 3 = ACCOUNT ALIASES</param>
    /// <param name="xml">the XML string containing the new FA configuration information.</param>
    public void ReplaceFA(int requestId, FADataType faDataType, string xml)
    {
        lock (this)
            ClientSocket.replaceFA(requestId, faDataType.Value, xml);
    }

    #endregion

    #region Fundamental Data

    /// <summary>
    /// Request Fundamental Data
    /// </summary>
    /// <param name="requestId">Request Id</param>
    /// <param name="contract">Contract to request fundamental data for</param>
    /// <param name="reportType">Report Type</param>
    public virtual void RequestFundamentalData(int requestId, Contract contract, string reportType)
    {
        lock (this)
            ClientSocket.reqFundamentalData(requestId, contract, reportType, null);
    }

    /// <summary>
    /// Call this method to stop receiving Reuters global fundamental data.
    /// </summary>
    /// <param name="requestId">The ID of the data request.</param>
    public virtual void CancelFundamentalData(int requestId)
    {
        lock (this)
            ClientSocket.cancelFundamentalData(requestId);
    }

    #endregion

    #region Market Scanners

    /// <summary>
    /// Call the reqScannerParameters() method to receive an XML document that describes the valid parameters that a scanner subscription can have.
    /// </summary>
    public void RequestScannerParameters()
    {
        lock (this)
            ClientSocket.reqScannerParameters();
    }

    /// <summary>
    /// Call the reqScannerSubscription() method to start receiving market scanner results through the scannerData() EWrapper method. 
    /// </summary>
    /// <param name="requestId">the Id for the subscription. Must be a unique value. When the subscription  data is received, it will be identified by this Id. This is also used when canceling the scanner.</param>
    /// <param name="subscription">summary of the scanner subscription parameters including filters.</param>
    public void RequestScannerSubscription(int requestId, ScannerSubscription subscription,
                                           string scannerSubscriptionOptions, string scannerSubscriptionFilterOptions)
    {
        lock (this)
            ClientSocket.reqScannerSubscription(requestId, subscription, scannerSubscriptionOptions,
                                                scannerSubscriptionFilterOptions);
    }

    /// <summary>
    /// Call the cancelScannerSubscription() method to stop receiving market scanner results. 
    /// </summary>
    /// <param name="requestId">the Id that was specified in the call to reqScannerSubscription().</param>
    public void CancelScannerSubscription(int requestId)
    {
        lock (this)
            ClientSocket.cancelScannerSubscription(requestId);
    }

    #endregion

    #region News

    /// <summary>
    /// Call this method to start receiving news bulletins. Each bulletin will be returned by the updateNewsBulletin() method.
    /// </summary>
    /// <param name="allMessages">if set to TRUE, returns all the existing bulletins for the current day and any new ones. IF set to FALSE, will only return new bulletins.</param>
    public void RequestNewsBulletins(bool allMessages)
    {
        lock (this)
            ClientSocket.reqNewsBulletins(allMessages);
    }

    /// <summary>
    /// Call this method to stop receiving news bulletins.
    /// </summary>
    public void CancelNewsBulletins()
    {
        lock (this)
            ClientSocket.cancelNewsBulletin();
    }

    #endregion
}