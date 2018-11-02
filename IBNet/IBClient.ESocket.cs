using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using IBApi;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// ESocket implementation
    /// </summary>
    public partial class IBClient
    {
        private readonly EClientSocket _socket;


        #region IBClientSocket

        #region Properties

        /// <summary>
        /// Returns the status of the connection to TWS.
        /// </summary>
        public bool Connected => _socket.IsConnected();

	    /// <summary>
        /// Returns the version of the TWS instance the API application is connected to
        /// </summary>
        public int ServerVersion => _socket.ServerVersion;

	    /// <summary>
        /// Returns the client version of the TWS API
        /// </summary>
        public static int ClientVersion => Constants.ClientVersion;

//	    /// <summary>
//        /// Returns the time the API application made a connection to TWS
//        /// </summary>
//        public string TwsConnectionTime => _socket.TwsConnectionTime;

	    public bool ThrowExceptions { get; set; }

        #endregion

        #region TWS Commmands

        /// <summary>
        /// This function must be called before any other. There is no feedback for a successful connection, but a subsequent attempt to connect will return the message "Already connected."
        /// </summary>
        /// <param name="host">host name or IP address of the machine where TWS is running. Leave blank to connect to the local host.</param>
        /// <param name="port">must match the port specified in TWS on the Configure>API>Socket Port field.</param>
        /// <param name="clientId">A number used to identify this client connection. All orders placed/modified from this client will be associated with this client identifier.
        /// Each client MUST connect with a unique clientId.</param>
        public void Connect(string host, int port, int clientId)
        {
            lock (this)
                _socket.eConnect(host, port, clientId);
        }

        /// <summary>
        /// Call this method to terminate the connections with TWS. Calling this method does not cancel orders that have already been sent.
        /// </summary>
        public void Disconnect()
        {
            lock (this)
            {
                GeneralTracer.WriteLineIf(ibTrace.TraceInfo, "IBClient Disconnect");
                _socket.eDisconnect();
            }
        }

        /// <summary>
        /// Call the cancelScannerSubscription() method to stop receiving market scanner results.
        /// </summary>
        /// <param name="tickerId">the Id that was specified in the call to reqScannerSubscription().</param>
        public void CancelScannerSubscription(int tickerId)
        {
            lock (this)
                _socket.cancelScannerSubscription(tickerId);
        }

        /// <summary>
        /// Call the reqScannerParameters() method to receive an XML document that describes the valid parameters that a scanner subscription can have.
        /// </summary>
        public void RequestScannerParameters()
        {
            lock (this)
                _socket.reqScannerParameters();
        }

        /// <summary>
        /// Call the reqScannerSubscription() method to start receiving market scanner results through the scannerData() EWrapper method.
        /// </summary>
        /// <param name="tickerId">the Id for the subscription. Must be a unique value. When the subscription  data is received, it will be identified by this Id. This is also used when canceling the scanner.</param>
        /// <param name="subscription">summary of the scanner subscription parameters including filters.</param>
        public void RequestScannerSubscription(int tickerId, ScannerSubscription subscription)
        {
            lock (this)
                _socket.reqScannerSubscription(tickerId, subscription, null, null);
        }

        /// <summary>
        /// Call this method to request market data. The market data will be returned by the tickPrice, tickSize, tickOptionComputation(), tickGeneric(), tickString() and tickEFP() methods.
        /// </summary>
        /// <param name="tickerId">the ticker id. Must be a unique value. When the market data returns, it will be identified by this tag. This is also used when canceling the market data.</param>
        /// <param name="contract">this structure contains a description of the contract for which market data is being requested.</param>
        /// <param name="genericTickList">comma delimited list of generic tick types.  Tick types can be found here: (new Generic Tick Types page) </param>
        /// <param name="snapshot">Allows client to request snapshot market data.</param>
        /// <param name="marketDataOff">Market Data Off - used in conjunction with RTVolume Generic tick type causes only volume data to be sent.</param>
        public void RequestMarketData(int tickerId, Contract contract, Collection<GenericTickType> genericTickList, bool snapshot, bool marketDataOff)
        {
            var genList = new StringBuilder();
            if (genericTickList != null)
            {
                foreach (GenericTickType t in genericTickList)
                    genList.AppendFormat("{0},", ((int)t).ToString(CultureInfo.InvariantCulture));
            }
            lock (this)
                _socket.reqMktData(tickerId, contract, genList.ToString().Trim(','), snapshot, false, null);
        }

        /// <summary>
        /// Call the CancelHistoricalData method to stop receiving historical data results.
        /// </summary>
        /// <param name="tickerId">the Id that was specified in the call to <see cref="RequestHistoricalData(int,Contract,DateTime,TimeSpan,BarSize,HistoricalDataType,int)"/>.</param>
        public void CancelHistoricalData(int tickerId)
        {
            lock (this)
                _socket.cancelHistoricalData(tickerId);
        }

        /// <summary>
        /// Call the CancelRealTimeBars() method to stop receiving real time bar results.
        /// </summary>
        /// <param name="tickerId">The Id that was specified in the call to <see cref="RequestRealTimeBars"/>.</param>
        public void CancelRealTimeBars(int tickerId)
        {
            lock (this)
                _socket.cancelRealTimeBars(tickerId);
        }

        /// <summary>
        /// Call the reqHistoricalData() method to start receiving historical data results through the historicalData() EWrapper method.
        /// </summary>
        /// <param name="tickerId">the Id for the request. Must be a unique value. When the data is received, it will be identified by this Id. This is also used when canceling the historical data request.</param>
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
        /// <list type="table">
        /// <listheader>
        ///     <term>Bar Size</term>
        ///     <description>Parametric Value</description>
        /// </listheader>
        /// <item>
        ///     <term>1 sec</term>
        ///     <description>1</description>
        /// </item>
        /// <item>
        ///     <term>5 secs</term>
        ///     <description>2</description>
        /// </item>
        /// <item>
        ///     <term>15 secs</term>
        ///     <description>3</description>
        /// </item>
        /// <item>
        ///     <term>30 secs</term>
        ///     <description>4</description>
        /// </item>
        /// <item>
        ///     <term>1 min</term>
        ///     <description>5</description>
        /// </item>
        /// <item>
        ///     <term>2 mins</term>
        ///     <description>6</description>
        /// </item>
        /// <item>
        ///     <term>5 mins</term>
        ///     <description>7</description>
        /// </item>
        /// <item>
        ///     <term>15 mins</term>
        ///     <description>8</description>
        /// </item>
        /// <item>
        ///     <term>30 mins</term>
        ///     <description>9</description>
        /// </item>
        /// <item>
        ///     <term>1 hour</term>
        ///     <description>10</description>
        /// </item>
        /// <item>
        ///     <term>1 day</term>
        ///     <description>11</description>
        /// </item>
        /// <item>
        ///     <term>1 week</term>
        ///     <description></description>
        /// </item>
        /// <item>
        ///     <term>1 month</term>
        ///     <description></description>
        /// </item>
        /// <item>
        ///     <term>3 months</term>
        ///     <description></description>
        /// </item>
        /// <item>
        ///     <term>1 year</term>
        ///     <description></description>
        /// </item>
        /// </list>
        /// </param>
        /// <param name="whatToShow">determines the nature of data being extracted. Valid values include:
        /// TRADES
        /// MIDPOINT
        /// BID
        /// ASK
        /// BID/ASK
        /// </param>
        /// <param name="useRth">
        /// determines whether to return all data available during the requested time span, or only data that falls within regular trading hours. Valid values include:
        /// 0 - all data is returned even where the market in question was outside of its regular trading hours.
        /// 1 - only data within the regular trading hours is returned, even if the requested time span falls partially or completely outside of the RTH.
        /// </param>
        public void RequestHistoricalData(int tickerId, Contract contract, DateTime endDateTime, TimeSpan duration,
                                      BarSize barSizeSetting, HistoricalDataType whatToShow, int useRth)
        {
            DateTime beginDateTime = endDateTime.Subtract(duration);
            TimeSpan period = endDateTime.Subtract(beginDateTime);
            string dur;

            double secs = period.TotalSeconds;
            long unit;

            if (secs < 1)
                throw new ArgumentOutOfRangeException("Period cannot be less than 1 second.");
            if (secs < 86400)
            {
                unit = (long) Math.Ceiling(secs);
                dur = string.Concat(unit, " S");
            }
            else
            {
                double days = secs / 86400;
                unit = (long)Math.Ceiling(days);
                if (unit <= 34)
                {
                    dur = string.Concat(unit, " D");
                }
                else
                {
                    double weeks = days / 7;
                    unit = (long)Math.Ceiling(weeks);
                    if (unit > 52)
                        throw new ArgumentOutOfRangeException("Period cannot be bigger than 52 weeks.");
                    dur = string.Concat(unit, " W");
                }
            }

            RequestHistoricalData(tickerId, contract, endDateTime, dur, barSizeSetting, whatToShow, useRth);
        }


        /// <summary>
        /// Call the reqHistoricalData() method to start receiving historical data results through the historicalData() EWrapper method.
        /// </summary>
        /// <param name="tickerId">the Id for the request. Must be a unique value. When the data is received, it will be identified by this Id. This is also used when canceling the historical data request.</param>
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
        /// <list type="table">
        /// <listheader>
        ///     <term>Bar Size</term>
        ///     <description>Parametric Value</description>
        /// </listheader>
        /// <item>
        ///     <term>1 sec</term>
        ///     <description>1</description>
        /// </item>
        /// <item>
        ///     <term>5 secs</term>
        ///     <description>2</description>
        /// </item>
        /// <item>
        ///     <term>15 secs</term>
        ///     <description>3</description>
        /// </item>
        /// <item>
        ///     <term>30 secs</term>
        ///     <description>4</description>
        /// </item>
        /// <item>
        ///     <term>1 min</term>
        ///     <description>5</description>
        /// </item>
        /// <item>
        ///     <term>2 mins</term>
        ///     <description>6</description>
        /// </item>
        /// <item>
        ///     <term>5 mins</term>
        ///     <description>7</description>
        /// </item>
        /// <item>
        ///     <term>15 mins</term>
        ///     <description>8</description>
        /// </item>
        /// <item>
        ///     <term>30 mins</term>
        ///     <description>9</description>
        /// </item>
        /// <item>
        ///     <term>1 hour</term>
        ///     <description>10</description>
        /// </item>
        /// <item>
        ///     <term>1 day</term>
        ///     <description>11</description>
        /// </item>
        /// <item>
        ///     <term>1 week</term>
        ///     <description></description>
        /// </item>
        /// <item>
        ///     <term>1 month</term>
        ///     <description></description>
        /// </item>
        /// <item>
        ///     <term>3 months</term>
        ///     <description></description>
        /// </item>
        /// <item>
        ///     <term>1 year</term>
        ///     <description></description>
        /// </item>
        /// </list>
        /// </param>
        /// <param name="whatToShow">determines the nature of data being extracted. Valid values include:
        /// TRADES
        /// MIDPOINT
        /// BID
        /// ASK
        /// BID/ASK
        /// </param>
        /// <param name="useRth">
        /// determines whether to return all data available during the requested time span, or only data that falls within regular trading hours. Valid values include:
        /// 0 - all data is returned even where the market in question was outside of its regular trading hours.
        /// 1 - only data within the regular trading hours is returned, even if the requested time span falls partially or completely outside of the RTH.
        /// </param>
        public void RequestHistoricalData(int tickerId, Contract contract, DateTime endDateTime, string duration,
                                      BarSize barSizeSetting, HistoricalDataType whatToShow, int useRth)
        {
            string endDT = endDateTime.ToUniversalTime().ToString("yyyyMMdd HH:mm:ss", CultureInfo.InvariantCulture) + " UTC";
            string barSize = EnumDescConverter.GetEnumDescription(barSizeSetting);
            string wts = EnumDescConverter.GetEnumDescription(whatToShow);
            lock (this)
                _socket.reqHistoricalData(tickerId, contract, endDT, duration, barSize, wts, useRth, 2, false, null);
        }

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
                _socket.reqContractDetails(requestId, contract);
        }

        /// <summary>
        /// Call the reqRealTimeBars() method to start receiving real time bar results through the realtimeBar() EWrapper method.
        /// </summary>
        /// <param name="tickerId">The Id for the request. Must be a unique value. When the data is received, it will be identified
        /// by this Id. This is also used when canceling the historical data request.</param>
        /// <param name="contract">This structure contains a description of the contract for which historical data is being requested.</param>
        /// <param name="barSize">Currently only 5 second bars are supported, if any other value is used, an exception will be thrown.</param>
        /// <param name="whatToShow">Determines the nature of the data extracted. Valid values include:
        /// TRADES
        /// BID
        /// ASK
        /// MIDPOINT
        /// </param>
        /// <param name="useRth">useRth – Regular Trading Hours only. Valid values include:
        /// 0 = all data available during the time span requested is returned, including time intervals when the market in question was outside of regular trading hours.
        /// 1 = only data within the regular trading hours for the product requested is returned, even if the time time span falls partially or completely outside.
        /// </param>
        public void RequestRealTimeBars(int tickerId, Contract contract, int barSize, RealTimeBarType whatToShow, bool useRth)
        {
            string wts = EnumDescConverter.GetEnumDescription(whatToShow);
            lock (this)
                _socket.reqRealTimeBars(tickerId, contract, barSize, wts, useRth, null);
        }


        /// <summary>
        /// Call this method to request market depth for a specific contract. The market depth will be returned by the updateMktDepth() and updateMktDepthL2() methods.
        /// </summary>
        /// <param name="tickerId">the ticker Id. Must be a unique value. When the market depth data returns, it will be identified by this tag. This is also used when canceling the market depth.</param>
        /// <param name="contract">this structure contains a description of the contract for which market depth data is being requested.</param>
        /// <param name="numberOfRows">specifies the number of market depth rows to return.</param>
        public void RequestMarketDepth(int tickerId, Contract contract, int numberOfRows)
        {
            if (contract == null)
                throw new ArgumentNullException("contract");
            lock (this)
                _socket.reqMarketDepth(tickerId, contract, numberOfRows, true, null);
        }

        /// <summary>
        /// After calling this method, market data for the specified Id will stop flowing.
        /// </summary>
        /// <param name="tickerId">the Id that was specified in the call to reqMktData().</param>
        public void CancelMarketData(int tickerId)
        {
            lock (this)
                _socket.cancelMktData(tickerId);
        }

        /// <summary>
        /// After calling this method, market depth data for the specified Id will stop flowing.
        /// </summary>
        /// <param name="tickerId">the Id that was specified in the call to reqMktDepth().</param>
        public void CancelMarketDepth(int tickerId)
        {
            lock (this)
                _socket.cancelMktDepth(tickerId, true);
        }

        /// <summary>
        /// Call the exerciseOptions() method to exercise options.
        /// “SMART” is not an allowed exchange in exerciseOptions() calls, and that TWS does a moneyness request for the position in question whenever any API initiated exercise or lapse is attempted.
        /// </summary>
        /// <param name="tickerId">the Id for the exercise request.</param>
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
        public void ExerciseOptions(int tickerId, Contract contract, int exerciseAction, int exerciseQuantity,
                                    string account, int overrideRenamed)
        {
            if (contract == null)
                throw new ArgumentNullException("contract");
            lock (this)
                _socket.exerciseOptions(tickerId, contract, exerciseAction, exerciseQuantity, account, overrideRenamed);
        }

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
                _socket.placeOrder(orderId, contract, order);
        }

        /// <summary>
        /// Call this function to start getting account values, portfolio, and last update time information.
        /// </summary>
        /// <param name="subscribe">If set to TRUE, the client will start receiving account and portfolio updates. If set to FALSE, the client will stop receiving this information.</param>
        /// <param name="acctCode">the account code for which to receive account and portfolio updates.</param>
        public void RequestAccountUpdates(bool subscribe, string acctCode)
        {
            lock (this)
                _socket.reqAccountUpdates(subscribe, acctCode);
        }

        /// <summary>
        /// When this method is called, the execution reports that meet the filter criteria are downloaded to the client via the execDetails() method.
        /// </summary>
        /// <param name="requestId">Id of the request</param>
        /// <param name="filter">the filter criteria used to determine which execution reports are returned.</param>
        public void RequestExecutions(int requestId, KrsExecutionFilter filter)
        {
            if (filter == null)
                filter = new KrsExecutionFilter(0, "", DateTime.MinValue, "", SecurityType.Undefined, "", ActionSide.Undefined);
            lock (this)
            {
                filter.Convert();
                _socket.reqExecutions(requestId, filter);
            }
        }

        /// <summary>
        /// Call this method to cancel an order.
        /// </summary>
        /// <param name="orderId">Call this method to cancel an order.</param>
        public void CancelOrder(int orderId)
        {
            lock (this)
                _socket.cancelOrder(orderId);
        }

        /// <summary>
        /// Call this method to request the open orders that were placed from this client. Each open order will be fed back through the openOrder() and orderStatus() functions on the EWrapper.
        ///
        /// The client with a clientId of "0" will also receive the TWS-owned open orders. These orders will be associated with the client and a new orderId will be generated. This association will persist over multiple API and TWS sessions.
        /// </summary>
        public void RequestOpenOrders()
        {
            lock (this)
                _socket.reqOpenOrders();
        }

        /// <summary>
        /// Returns one next valid Id...
        /// </summary>
        /// <param name="numberOfIds">Has No Effect</param>
        public void RequestIds(int numberOfIds)
        {
            lock (this)
                _socket.reqIds(numberOfIds);
        }

        /// <summary>
        /// Call this method to start receiving news bulletins. Each bulletin will be returned by the updateNewsBulletin() method.
        /// </summary>
        /// <param name="allMessages">if set to TRUE, returns all the existing bulletins for the current day and any new ones. IF set to FALSE, will only return new bulletins.</param>
        public void RequestNewsBulletins(bool allMessages)
        {
            lock (this)
                _socket.reqNewsBulletins(allMessages);
        }

        /// <summary>
        /// Call this method to stop receiving news bulletins.
        /// </summary>
        public void CancelNewsBulletins()
        {
            lock (this)
                _socket.cancelNewsBulletin();
        }

        /// <summary>
        /// Call this method to request that newly created TWS orders be implicitly associated with the client. When a new TWS order is created, the order will be associated with the client and fed back through the openOrder() and orderStatus() methods on the EWrapper.
        ///
        /// TWS orders can only be bound to clients with a clientId of “0”.
        /// </summary>
        /// <param name="autoBind">If set to TRUE, newly created TWS orders will be implicitly associated with the client. If set to FALSE, no association will be made.</param>
        public void RequestAutoOpenOrders(bool autoBind)
        {
            lock (this)
                _socket.reqAutoOpenOrders(autoBind);
        }

        /// <summary>
        /// Call this method to request the open orders that were placed from all clients and also from TWS. Each open order will be fed back through the openOrder() and orderStatus() functions on the EWrapper.
        ///
        /// No association is made between the returned orders and the requesting client.
        /// </summary>
        public void RequestAllOpenOrders()
        {
            lock (this)
                _socket.reqAllOpenOrders();
        }

        /// <summary>
        /// Call this method to request the list of managed accounts. The list will be returned by the managedAccounts() function on the EWrapper.
        ///
        /// This request can only be made when connected to a Financial Advisor (FA) account.
        /// </summary>
        public void RequestManagedAccts()
        {
            lock (this)
                _socket.reqManagedAccts();
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
                _socket.requestFA((int)faDataType);
        }

        /// <summary>
        /// Call this method to request FA configuration information from TWS. The data returns in an XML string via a "receiveFA" ActiveX event.
        /// </summary>
        /// <param name="faDataType">
        /// specifies the type of Financial Advisor configuration data being requested. Valid values include:
        /// 1 = GROUPS
        /// 2 = PROFILE
        /// 3 = ACCOUNT ALIASES</param>
        /// <param name="xml">the XML string containing the new FA configuration information.</param>
        public void ReplaceFA(FADataType faDataType, string xml)
        {
            lock (this)
                _socket.replaceFA((int)faDataType, xml);
        }

        /// <summary>
        /// Returns the current system time on the server side.
        /// </summary>
        public void RequestCurrentTime()
        {
            lock (this)
                _socket.reqCurrentTime();
        }

        /// <summary>
        /// Request Fundamental Data
        /// </summary>
        /// <param name="requestId">Request Id</param>
        /// <param name="contract">Contract to request fundamental data for</param>
        /// <param name="reportType">Report Type</param>
        public virtual void RequestFundamentalData(int requestId, Contract contract, string reportType)
        {
            lock (this)
                _socket.reqFundamentalData(requestId, contract, reportType, null);
        }

        /// <summary>
        /// Call this method to stop receiving Reuters global fundamental data.
        /// </summary>
        /// <param name="requestId">The ID of the data request.</param>
        public virtual void CancelFundamentalData(int requestId)
        {
            lock (this)
                _socket.cancelFundamentalData(requestId);
        }

        public virtual void CancelCalculateImpliedVolatility(int reqId)
        {
            _socket.cancelCalculateImpliedVolatility(reqId);
        }

        /// <summary>
        /// Calculates the Implied Volatility based on the user-supplied option and underlying prices.
        /// The calculated implied volatility is returned by tickOptionComputation( ) in a new tick type, CUST_OPTION_COMPUTATION, which is described below.
        /// </summary>
        /// <param name="requestId">Request Id</param>
        /// <param name="contract">Contract</param>
        /// <param name="optionPrice">Price of the option</param>
        /// <param name="underPrice">Price of teh underlying of the option</param>
        public virtual void RequestCalculateImpliedVolatility(int requestId, Contract contract, double optionPrice, double underPrice)
        {
            lock (this)
                _socket.calculateImpliedVolatility(requestId, contract, optionPrice, underPrice, null);
        }

        public virtual void RequestCalculateOptionPrice(int reqId, Contract contract, double volatility, double underPrice)
        {
            _socket.calculateOptionPrice(reqId, contract, volatility, underPrice, null);
        }

        public virtual void CancelCalculateOptionPrice(int reqId)
        {
            _socket.cancelCalculateOptionPrice(reqId);
        }

        public virtual void RequestGlobalCancel()
        {
            _socket.reqGlobalCancel();
        }

        public virtual void RequestMarketDataType(int marketDataType)
        {
            _socket.reqMarketDataType(marketDataType);
        }

        #region FA
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
            var sb = new StringBuilder();
            var values = Enum.GetValues(typeof(AccountSummary)).Cast<AccountSummary>();
            foreach (AccountSummary si in values)
            {
                if (summaryItems.HasFlag(si))
                    sb.Append(si + ",");
            }
            if (sb.Length > 0)
            {
                string tags = sb.ToString().Trim(',');
                _socket.reqAccountSummary(reqId, group, tags);
            }
        }
        /// <summary>
        /// Cancels the account's summary request. After requesting an account's summary, invoke this function to cancel it.
        /// </summary>
        /// <param name="reqId">the identifier of the previously performed account request</param>
        /// <seealso cref="RequestAccountSummary"/>
        public virtual void CancelAccountSummary(int reqId)
        {
            _socket.cancelAccountSummary(reqId);
        }

        /// <summary>
        /// Requests all positions from all accounts
        /// </summary>
        /// <seealso cref="CancelPositions"/>
        public virtual void RequestPositions()
        {
            _socket.reqPositions();
        }
        /// <summary>
        /// Cancels all account's positions request
        /// </summary>
        /// <seealso cref="RequestPositions"/>
        public virtual void CancelPositions()
        {
            _socket.cancelPositions();
        }
        #endregion

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
        public void SetServerLogLevel(LogLevel serverLogLevel)
        {
            lock (this)
                _socket.setServerLogLevel((int)serverLogLevel);
        }

        #endregion
        #endregion


    }
}