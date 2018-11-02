using System;
using System.Collections.Generic;
using System.Globalization;
using IBApi;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// EWraper implementation
    /// </summary>
    public partial class IBClient
    {

        #region EWrapper


        /// <summary>
        /// This event is fired when there is an error with the communication or when TWS wants to send a message to the client.
        /// </summary>
        public event EventHandler<ErrorEventArgs> Error;
        /// <summary>
        /// Called internally when the receive thread receives an error event.
        /// </summary>
        /// <param name="e">Error Event Arguments</param>
        protected virtual void OnError(ErrorEventArgs e) { Error?.Invoke(this, e); }
        public void error(int id, int errorCode, string errorMsg)
        {
            lock (this)
            {
                GeneralTracer.WriteLineIf(ibTrace.TraceError, "IBEvent: Error: tickerId: {0}, errorCode: {1}, errorMsg: {2}", id, errorCode, errorMsg);
                var e = new ErrorEventArgs(id, (ErrorMessage)errorCode, errorMsg);
                OnError(e);
            }
        }

        /// <summary>
        /// This method is triggered for any exceptions caught.
        /// </summary>
        public event EventHandler<ReportExceptionEventArgs> ReportException;
        /// <summary>
        /// Called internally when a exception is being thrown
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnReportException(ReportExceptionEventArgs e) { ReportException?.Invoke(this, e); }
        public void error(Exception ex)
        {
            var e = new ReportExceptionEventArgs(ex);
            OnReportException(e);
        }

        public void error(string str)
        {
            error(0, 0, str);
        }


        /// <summary>
        /// This method receives the current system time on the server side.
        /// </summary>
        public event EventHandler<CurrentTimeEventArgs> CurrentTime;
        /// <summary>
        /// Called internally when the receive thread receives a current time event.
        /// </summary>
        /// <param name="e">Current Time Event Arguments</param>
        protected virtual void OnCurrentTime(CurrentTimeEventArgs e) { CurrentTime?.Invoke(this, e); }
        public void currentTime(long time)
        {
            var cTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(time);
            var e = new CurrentTimeEventArgs(cTime);
            CurrentTime?.Invoke(this, e);
            OnCurrentTime(e);
        }

        /// <summary>
        /// This event is called when the market data changes. Prices are updated immediately with no delay.
        /// </summary>
        public event EventHandler<TickPriceEventArgs> TickPrice;
        /// <summary>
        /// Called internally when the receive thread receives a tick price event.
        /// </summary>
        /// <param name="e">Tick Price event arguments</param>
        protected virtual void OnTickPrice(TickPriceEventArgs e) { TickPrice?.Invoke(this, e); }
        public void tickPrice(int tickerId, int field, double price, TickAttrib attribs)
        {
            var tickType = (TickType)field;
            var e = new TickPriceEventArgs(tickerId, tickType, price, attribs);
            OnTickPrice(e);
        }

        /// <summary>
        /// This event is called when the market data changes. Sizes are updated immediately with no delay.
        /// </summary>
        public event EventHandler<TickSizeEventArgs> TickSize;
        /// <summary>
        /// Called internally when the receive thread receives a tick size event.
        /// </summary>
        /// <param name="e">Tick Size Event Arguments</param>
        protected virtual void OnTickSize(TickSizeEventArgs e) { TickSize?.Invoke(this, e); }
        public void tickSize(int tickerId, int field, int size)
        {
            //GeneralTracer.WriteLineIf(ibTickTrace.TraceInfo, "IBEvent: TickSize: tickerId: {0}, tickType: {1}, size: {2}", tickerId, tickType, size);
            var tickType = (TickType)field;
            var e = new TickSizeEventArgs(tickerId, tickType, size);
            OnTickSize(e);
        }

        /// <summary>
        /// This method is called when the market data changes. Values are updated immediately with no delay.
        /// </summary>
        public event EventHandler<TickStringEventArgs> TickString;
        /// <summary>
        /// Called internally when the receive thread receives a Tick String  event.
        /// </summary>
        /// <param name="e">Tick String Event Arguments</param>
        protected virtual void OnTickString(TickStringEventArgs e) { TickString?.Invoke(this, e); }
        public void tickString(int tickerId, int field, string value)
        {
            var tickType = (TickType)field;
            var e = new TickStringEventArgs(tickerId, tickType, value);
            OnTickString(e);
        }

        /// <summary>
        /// This method is called when the market data changes. Values are updated immediately with no delay.
        /// </summary>
        public event EventHandler<TickGenericEventArgs> TickGeneric;
        /// <summary>
        /// Called internally when the receive thread receives a generic tick event.
        /// </summary>
        /// <param name="e">Tick Generic Event Arguments</param>
        protected virtual void OnTickGeneric(TickGenericEventArgs e) { TickGeneric?.Invoke(this, e); }
        public void tickGeneric(int tickerId, int field, double value)
        {
            var tickType = (TickType)field;
            var e = new TickGenericEventArgs(tickerId, tickType, value);
            OnTickGeneric(e);
        }

        /// <summary>
        /// This method is called when the market data changes. Values are updated immediately with no delay.
        /// </summary>
        public event EventHandler<TickEfpEventArgs> TickEfp;
        /// <summary>
        /// Called internally when the receive thread receives a tick EFP event.
        /// </summary>
        /// <param name="e">Tick Efp Arguments</param>
        protected virtual void OnTickEfp(TickEfpEventArgs e) { TickEfp?.Invoke(this, e); }
        public void tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture,
            int holdDays, string futureExpiry, double dividendImpact, double dividendsToExpiry)
        {
            var tickTyp = (TickType)tickType;
            var e = new TickEfpEventArgs(tickerId, tickTyp, basisPoints, formattedBasisPoints, impliedFuture, holdDays, futureExpiry, dividendImpact, dividendsToExpiry);
            OnTickEfp(e);
        }

        /// <summary>
        /// Called once all execution data for a given request are received.
        /// </summary>
        public event EventHandler<DeltaNuetralValidationEventArgs> DeltaNuetralValidation;
        /// <summary>
        /// Called internally when the receive thread receives a Contract Details End Event.
        /// </summary>
        /// <param name="e">Contract Details End Event Arguments</param>
        protected virtual void OnDeltaNuetralValidation(DeltaNuetralValidationEventArgs e) { DeltaNuetralValidation?.Invoke(this, e); }
        public void deltaNeutralValidation(int reqId, DeltaNeutralContract deltaNeutralContract)
        {
            var e = new DeltaNuetralValidationEventArgs(reqId, deltaNeutralContract);
            OnDeltaNuetralValidation(e);
        }

        /// <summary>
        /// This method is called when the market in an option or its underlier moves.
        /// TWS’s option model volatilities, prices, and deltas, along with the present
        /// value of dividends expected on that option’s underlier are received.
        /// </summary>
        public event EventHandler<TickOptionComputationEventArgs> TickOptionComputation;
        /// <summary>
        /// Called internally when the receive thread receives a tick option computation event.
        /// </summary>
        /// <param name="e">Tick Option Computation Arguments</param>
        protected virtual void OnTickOptionComputation(TickOptionComputationEventArgs e) { TickOptionComputation?.Invoke(this, e); }
        public void tickOptionComputation(int tickerId, int field, double impliedVolatility, double delta, double optPrice,
            double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            var tickType = (TickType)field;
            var e = new TickOptionComputationEventArgs(tickerId, tickType, impliedVolatility, delta, optPrice, pvDividend, gamma, vega, theta, undPrice);
            OnTickOptionComputation(e);
        }

        /// <summary>
        /// Called once the tick snap shot is complete.
        /// </summary>
        public event EventHandler<TickSnapshotEndEventArgs> TickSnapshotEnd;
        /// <summary>
        /// Called internally when the receive thread receives a Tick Snapshot End Event.
        /// </summary>
        /// <param name="e">Contract Details End Event Arguments</param>
        protected virtual void OnTickSnapshotEnd(TickSnapshotEndEventArgs e) { TickSnapshotEnd?.Invoke(this, e); }
        public void tickSnapshotEnd(int tickerId)
        {
            var e = new TickSnapshotEndEventArgs(tickerId);
            OnTickSnapshotEnd(e);
        }

        /// <summary>
        /// This method is called after a successful connection to TWS.
        /// </summary>
        public event EventHandler<NextValidIdEventArgs> NextValidId;
        /// <summary>
        /// Called internally when the receive thread receives a Next Valid Id event.
        /// </summary>
        /// <param name="e">Next Valid Id Event Arguments</param>
        protected virtual void OnNextValidId(NextValidIdEventArgs e) { NextValidId?.Invoke(this, e); }
        public void nextValidId(int orderId)
        {
            //GeneralTracer.WriteLineIf(ibTickTrace.TraceInfo, "IBEvent: NextValidId: orderId: {0}", orderId);
            var e = new NextValidIdEventArgs(orderId);
            OnNextValidId(e);
        }


        /// <summary>
        /// This method is called when a successful connection is made to a Financial Advisor account.
        /// It is also called when the reqManagedAccts() method is invoked.
        /// </summary>
        public event EventHandler<ManagedAccountsEventArgs> ManagedAccounts;
        /// <summary>
        /// Called internally when the receive thread receives a managed accounts event.
        /// </summary>
        /// <param name="e">Managed Accounts Event Arguments</param>
        protected virtual void OnManagedAccounts(ManagedAccountsEventArgs e) { ManagedAccounts?.Invoke(this, e); }
        public void managedAccounts(string accountsList)
        {
            var e = new ManagedAccountsEventArgs(accountsList);
            OnManagedAccounts(e);
        }

        /// <summary>
        /// This method is called when TWS closes the sockets connection, or when TWS is shut down.
        /// </summary>
        public event EventHandler<ConnectionClosedEventArgs> ConnectionClosed;
        /// <summary>
        /// Called internally when the receive thread receives a connection closed event.
        /// </summary>
        /// <param name="e">Connection Closed Event Arguments</param>
        protected virtual void OnConnectionClosed(ConnectionClosedEventArgs e) { ConnectionClosed?.Invoke(this, e); }
        public void connectionClosed()
        {
            var e = new ConnectionClosedEventArgs();
            OnConnectionClosed(e);
        }

        /// <summary>
        /// This method is called only when reqAccountUpdates() method on the EClientSocket object has been called.
        /// </summary>
        public event EventHandler<UpdateAccountValueEventArgs> UpdateAccountValue;
        /// <summary>
        /// Called internally when the receive thread receives an Update Account Value event.
        /// </summary>
        /// <param name="e">Update Account Value Event Arguments</param>
        protected virtual void OnUpdateAccountValue(UpdateAccountValueEventArgs e) { UpdateAccountValue?.Invoke(this, e); }

        void EWrapper.bondContractDetails(int reqId, ContractDetails contract)
        {
            bondContractDetails(reqId, contract);
        }

        public void updateAccountValue(string key, string value, string currency, string accountName)
        {
            var e = new UpdateAccountValueEventArgs(key, value, currency, accountName);
            OnUpdateAccountValue(e);
        }

        /// <summary>
        /// This method is called only when reqAccountUpdates() method on the EClientSocket object has been called.
        /// </summary>
        public event EventHandler<UpdatePortfolioEventArgs> UpdatePortfolio;
        /// <summary>
        /// Called Internally when the receive thread receives an Update Portfolio event.
        /// </summary>
        /// <param name="e">Update Portfolio Event Arguments</param>
        protected virtual void OnUpdatePortfolio(UpdatePortfolioEventArgs e) { UpdatePortfolio?.Invoke(this, e); }
        public void updatePortfolio(Contract contract, double position, double marketPrice, double marketValue, double averageCost,
            double unrealizedPNL, double realizedPNL, string accountName)
        {
            var e = new UpdatePortfolioEventArgs(contract, (int)position, marketPrice, marketValue, averageCost, unrealizedPNL, realizedPNL, accountName);
            OnUpdatePortfolio(e);
        }

        /// <summary>
        /// This method is called only when reqAccountUpdates() method on the EClientSocket object has been called.
        /// </summary>
        public event EventHandler<UpdateAccountTimeEventArgs> UpdateAccountTime;
        /// <summary>
        /// Called internally when the receive thread receives an Update Account Time event.
        /// </summary>
        /// <param name="e">Update Account Time Event Arguments</param>
        protected virtual void OnUpdateAccountTime(UpdateAccountTimeEventArgs e) { UpdateAccountTime?.Invoke(this, e); }
        public void updateAccountTime(string timestamp)
        {
            var e = new UpdateAccountTimeEventArgs(timestamp);
            OnUpdateAccountTime(e);
        }

        /// <summary>
        /// Called once all Account Details for a given request are received.
        /// </summary>
        public event EventHandler<AccountDownloadEndEventArgs> AccountDownloadEnd;
        /// <summary>
        /// Called internally when the receive thread receives a Account Download End Event.
        /// </summary>
        /// <param name="e">Contract Details End Event Arguments</param>
        protected virtual void OnAccountDownloadEnd(AccountDownloadEndEventArgs e) { AccountDownloadEnd?.Invoke(this, e); }
        public void accountDownloadEnd(string account)
        {
            var e = new AccountDownloadEndEventArgs(account);
            OnAccountDownloadEnd(e);
        }

        /// <summary>
        /// This methodis called whenever the status of an order changes. It is also fired after reconnecting
        /// to TWS if the client has any open orders.
        /// </summary>
        public event EventHandler<OrderStatusEventArgs> OrderStatus;
        /// <summary>
        /// Called internally when the receive thread receives an order status event.
        /// </summary>
        /// <param name="e">Order Status Event Arguments</param>
        protected virtual void OnOrderStatus(OrderStatusEventArgs e) { OrderStatus?.Invoke(this, e); }
        public void orderStatus(int orderId, string status, double filled, double remaining, double avgFillPrice, int permId,
            int parentId, double lastFillPrice, int clientId, string whyHeld, double mktCapPrice)
        {
            var orderStatus = string.IsNullOrEmpty(status)
                ? Krs.Ats.IBNet.OrderStatus.None
                : (OrderStatus)EnumDescConverter.GetEnumValue(typeof(OrderStatus), status);
            var e = new OrderStatusEventArgs(orderId, orderStatus, (int)filled, (int)remaining, avgFillPrice, permId, parentId, lastFillPrice, clientId, whyHeld, mktCapPrice);
            OnOrderStatus(e);
        }

        /// <summary>
        /// This method is called to feed in open orders.
        /// </summary>
        public event EventHandler<OpenOrderEventArgs> OpenOrder;
        /// <summary>
        /// Called internally when the receive thread receives an open order event.
        /// </summary>
        /// <param name="e">Open Order Event Arguments</param>
        protected virtual void OnOpenOrder(OpenOrderEventArgs e) { OpenOrder?.Invoke(this, e); }
        public void openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            var e = new OpenOrderEventArgs(orderId, contract, order, orderState);
            OnOpenOrder(e);
        }

        /// <summary>
        /// Called once all the open orders for a given request are received.
        /// </summary>
        public event EventHandler<EventArgs> OpenOrderEnd;
        /// <summary>
        /// Called internally when the receive thread receives a Open Orders End Event.
        /// </summary>
        /// <param name="e">Empty Event Arguments</param>
        protected virtual void OnOpenOrderEnd(EventArgs e) { OpenOrderEnd?.Invoke(this, e); }
        public void openOrderEnd()
        {
            var e = new EventArgs();
            OnOpenOrderEnd(e);
        }

        /// <summary>
        /// This event fires in response to the <see cref="RequestContractDetails"/> method.
        /// </summary>
        public event EventHandler<ContractDetailsEventArgs> ContractDetails;
        /// <summary>
        /// Called internally when the receive thread receives a contract details event.
        /// </summary>
        /// <param name="e">Contract Details Event Arguments</param>
        protected virtual void OnContractDetails(ContractDetailsEventArgs e) { ContractDetails?.Invoke(this, e); }
        public void contractDetails(int reqId, ContractDetails contractDetails)
        {
            var e = new ContractDetailsEventArgs(reqId, contractDetails);
            OnContractDetails(e);
        }

        /// <summary>
        /// Called once all contract details for a given request are received.
        /// This, for example, helps to define the end of an option chain.
        /// </summary>
        public event EventHandler<ContractDetailsEndEventArgs> ContractDetailsEnd;
        /// <summary>
        /// Called internally when the receive thread receives a Contract Details End Event.
        /// </summary>
        /// <param name="e">Contract Details End Event Arguments</param>
        protected virtual void OnContractDetailsEnd(ContractDetailsEndEventArgs e) { ContractDetailsEnd?.Invoke(this, e); }
        public void contractDetailsEnd(int reqId)
        {
            var e = new ContractDetailsEndEventArgs(reqId);
            OnContractDetailsEnd(e);
        }

        /// <summary>
        /// This event fires in response to the <see cref="RequestContractDetails"/> method called on a bond contract.
        /// </summary>
        public event EventHandler<BondContractDetailsEventArgs> BondContractDetails;
        /// <summary>
        /// Called internally when the receive thread receives a Bond Contract Details Event.
        /// </summary>
        /// <param name="e">Bond Contract Details Event Arguments</param>
        protected virtual void OnBondContractDetails(BondContractDetailsEventArgs e) { BondContractDetails?.Invoke(this, e); }
        private void bondContractDetails(int requestId, ContractDetails contractDetails)
        {
            var e = new BondContractDetailsEventArgs(requestId, contractDetails);
            OnBondContractDetails(e);
        }

        /// <summary>
        /// This event fires in response to the <see cref="RequestExecutions"/> method or after an order is placed.
        /// </summary>
        public event EventHandler<ExecDetailsEventArgs> ExecDetails;
        /// <summary>
        /// Called internally when the receive thread receives an execution details event.
        /// </summary>
        /// <param name="e">Execution Details Event Arguments</param>
        protected virtual void OnExecDetails(ExecDetailsEventArgs e) { ExecDetails?.Invoke(this, e); }
        public void execDetails(int reqId, Contract contract, Execution execution)
        {
            var e = new ExecDetailsEventArgs(reqId, contract, execution);
            OnExecDetails(e);
        }

        /// <summary>
        /// Called once all contract details for a given request are received.
        /// This, for example, helps to define the end of an option chain.
        /// </summary>
        public event EventHandler<ExecDetailsEndEventArgs> ExecDetailsEnd;
        /// <summary>
        /// Called internally when the receive thread receives a Contract Details End Event.
        /// </summary>
        /// <param name="e">Contract Details End Event Arguments</param>
        protected virtual void OnExecDetailsEnd(ExecDetailsEndEventArgs e) { ExecDetailsEnd?.Invoke(this, e); }
        public void execDetailsEnd(int reqId)
        {
            var e = new ExecDetailsEndEventArgs(reqId);
            OnExecDetailsEnd(e);
        }

        /// <summary>
        /// Called once all contract details for a given request are received.
        /// This, for example, helps to define the end of an option chain.
        /// </summary>
        public event EventHandler<CommissionReportEventArgs> CommissionReport;
        /// <summary>
        /// Called internally when the receive thread receives a Contract Details End Event.
        /// </summary>
        /// <param name="e">Contract Details End Event Arguments</param>
        protected virtual void OnCommissionReport(CommissionReportEventArgs e) { CommissionReport?.Invoke(this, e); }
        public void commissionReport(CommissionReport commissionReport)
        {
            var e = new CommissionReportEventArgs(commissionReport);
            OnCommissionReport(e);
        }

        /// <summary>
        /// Reuters global fundamental market data
        /// </summary>
        public event EventHandler<FundamentalDetailsEventArgs> FundamentalData;
        /// <summary>
        /// Called internally when the receive thread receives a fundamental data event.
        /// </summary>
        /// <param name="e">Fundamental Data Event Arguments</param>
        protected virtual void OnFundamentalData(FundamentalDetailsEventArgs e) { FundamentalData?.Invoke(this, e); }
        public void fundamentalData(int reqId, string data)
        {
            var e = new FundamentalDetailsEventArgs(reqId, data);
            OnFundamentalData(e);
        }

        /// <summary>
        /// This method receives the requested historical data results
        /// </summary>
        public event EventHandler<HistoricalDataEventArgs> HistoricalData;
        /// <summary>
        /// Called internally when the receive thread receives a historical data event.
        /// </summary>
        /// <param name="e">Historical Data Event Arguments</param>
        protected virtual void OnHistoricalData(HistoricalDataEventArgs e) { HistoricalData?.Invoke(this, e); }
        public void historicalData(int reqId, Bar bar)
        {
            OnHistoricalData(new HistoricalDataEventArgs(reqId, bar));
        }

        public event EventHandler<HistoricalDataUpdateEventArgs> HistoricalDataUpdate;
        protected virtual void OnHistoricalDataUpdate(HistoricalDataUpdateEventArgs e) { HistoricalDataUpdate?.Invoke(this, e); }
        public void historicalDataUpdate(int reqId, Bar bar)
        {
            OnHistoricalDataUpdate(new HistoricalDataUpdateEventArgs(reqId, bar));
        }

        /// <summary>
        /// This method receives the requested historical data results
        /// </summary>
        public event EventHandler<HistoricalDataEndEventArgs> HistoricalDataEnd;
        /// <summary>
        /// Called internally when the receive thread receives a tick price event.
        /// </summary>
        /// <param name="e">Historical Data Event Arguments</param>
        protected virtual void OnHistoricalDataEnd(HistoricalDataEndEventArgs e) { HistoricalDataEnd?.Invoke(this, e); }
        public void historicalDataEnd(int reqId, string start, string end)
        {
            var e = new HistoricalDataEndEventArgs(reqId, start, end);
            OnHistoricalDataEnd(e);
        }

        /// <summary>
        /// Called on a market data type call back.
        /// </summary>
        public event EventHandler<MarketDataTypeEventArgs> MarketDataType;
        /// <summary>
        /// Called internally when the receive thread receives a Market Data Type Event.
        /// </summary>
        protected virtual void OnMarketDataType(MarketDataTypeEventArgs e) { MarketDataType?.Invoke(this, e); }
        public void marketDataType(int reqId, int marketDataType)
        {
            var dataType = (MarketDataType) marketDataType;
            var e = new MarketDataTypeEventArgs(reqId, dataType);
            OnMarketDataType(e);
        }

        /// <summary>
        /// This method is called when the market depth changes.
        /// </summary>
        public event EventHandler<UpdateMarketDepthEventArgs> UpdateMarketDepth;
        /// <summary>
        /// Called internally when the receive thread receives an update market depth event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnUpdateMarketDepth(UpdateMarketDepthEventArgs e) { UpdateMarketDepth?.Invoke(this, e); }
        public void updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            var marketDepthOp = (MarketDepthOperation) operation;
            var marketDepthSide = (MarketDepthSide) side;
            var e = new UpdateMarketDepthEventArgs(tickerId, position, marketDepthOp, marketDepthSide, price, size);
            OnUpdateMarketDepth(e);
        }

        /// <summary>
        /// This method is called when the Level II market depth changes.
        /// </summary>
        public event EventHandler<UpdateMarketDepthL2EventArgs> UpdateMarketDepthL2;
        /// <summary>
        /// Called internally when the receive thread receives an update market depth level 2 event.
        /// </summary>
        /// <param name="e">Update Market Depth L2 Event Arguments</param>
        protected virtual void OnUpdateMarketDepthL2(UpdateMarketDepthL2EventArgs e) { UpdateMarketDepthL2?.Invoke(this, e); }
        public void updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, int size,
            bool isSmartDepth)
        {
            var marketDepthOp = (MarketDepthOperation)operation;
            var marketDepthSide = (MarketDepthSide)side;
            var e = new UpdateMarketDepthL2EventArgs(tickerId, position, marketMaker, marketDepthOp, marketDepthSide, price, size, isSmartDepth);
            OnUpdateMarketDepthL2(e);
        }

        /// <summary>
        /// This method is triggered for each new bulletin if the client has subscribed (i.e. by calling the reqNewsBulletins() method.
        /// </summary>
        public event EventHandler<UpdateNewsBulletinEventArgs> UpdateNewsBulletin;

        /// <summary>
        /// Called internally when the receive thread receives an update news bulletin event.
        /// </summary>
        /// <param name="e">Update News Bulletin Event Arguments</param>
        protected virtual void OnUpdateNewsBulletin(UpdateNewsBulletinEventArgs e) { UpdateNewsBulletin?.Invoke(this, e); }
        public void updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            var newsType = (NewsType) msgType;
            var e = new UpdateNewsBulletinEventArgs(msgId, newsType, message, origExchange);
            OnUpdateNewsBulletin(e);
        }

        /// <summary>
        /// This method receives the realtime bars data results.
        /// </summary>
        public event EventHandler<RealTimeBarEventArgs> RealTimeBar;
        /// <summary>
        /// Called internally when the receive thread receives a real time bar event.
        /// </summary>
        /// <param name="e">Real Time Bar Event Arguments</param>
        protected virtual void OnRealTimeBar(RealTimeBarEventArgs e) { RealTimeBar?.Invoke(this, e); }
        public void realtimeBar(int reqId, long time, double open, double high, double low, double close, long volume, double WAP,
            int count)
        {
            var e = new RealTimeBarEventArgs(reqId, time, open, high, low, close, volume, WAP, count);
            OnRealTimeBar(e);
        }

        /// <summary>
        /// This method receives an XML document that describes the valid parameters that a scanner subscription can have
        /// </summary>
        public event EventHandler<ScannerParametersEventArgs> ScannerParameters;
        /// <summary>
        /// Called internally when the receive thread receives a scanner parameters event.
        /// </summary>
        /// <param name="e">Scanner Parameters Event Arguments</param>
        protected virtual void OnScannerParameters(ScannerParametersEventArgs e) { ScannerParameters?.Invoke(this, e); }
        public void scannerParameters(string xml)
        {
            var e = new ScannerParametersEventArgs(xml);
            OnScannerParameters(e);
        }

        /// <summary>
        /// This method receives the requested market scanner data results
        /// </summary>
        public event EventHandler<ScannerDataEventArgs> ScannerData;
        /// <summary>
        /// Called internally when the receive thread receives a tick price event.
        /// </summary>
        /// <param name="e">Scanner Data Event Arguments</param>
        protected virtual void OnScannerData(ScannerDataEventArgs e) { ScannerData?.Invoke(this, e); }
        public void scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark,
            string projection, string legsStr)
        {
            var e = new ScannerDataEventArgs(reqId, rank, contractDetails, distance, benchmark, projection, legsStr);
            OnScannerData(e);
        }

        /// <summary>
        /// This method receives the requested market scanner data results
        /// </summary>
        public event EventHandler<ScannerDataEndEventArgs> ScannerDataEnd;
        /// <summary>
        /// Called internally when the receive thread receives a tick price event.
        /// </summary>
        /// <param name="e">Scanner Data Event Arguments</param>
        protected virtual void OnScannerDataEnd(ScannerDataEndEventArgs e) { ScannerDataEnd?.Invoke(this, e); }
        public void scannerDataEnd(int reqId)
        {
            var e = new ScannerDataEndEventArgs(reqId);
            OnScannerDataEnd(e);
        }

        #region FA events
        /// <summary>
        /// This method receives previously requested FA configuration information from TWS.
        /// </summary>
        public event EventHandler<ReceiveFAEventArgs> ReceiveFA;
        /// <summary>
        /// Called internally when the receive thread receives a Receive Finanvial Advisor event.
        /// </summary>
        /// <param name="e">Receive FA Event Arguments</param>
        protected virtual void OnReceiveFA(ReceiveFAEventArgs e) { ReceiveFA?.Invoke(this, e); }
        public void receiveFA(int faDataType, string faXmlData)
        {
            var e = new ReceiveFAEventArgs((FADataType)faDataType, faXmlData);
            OnReceiveFA(e);
        }

        public event EventHandler<VerifyMessageApiEventArgs> VerifyMessageApi;
        protected virtual void OnVerifyMessageApi(VerifyMessageApiEventArgs e) { VerifyMessageApi?.Invoke(this, e); }
        public void verifyMessageAPI(string apiData)
        {
            OnVerifyMessageApi(new VerifyMessageApiEventArgs(apiData));
        }

        public event EventHandler<VerifyCompletedEventArgs> VerifyCompleted;
        protected virtual void OnVerifyCompleted(VerifyCompletedEventArgs e) { VerifyCompleted?.Invoke(this, e); }
        public void verifyCompleted(bool isSuccessful, string errorText)
        {
            OnVerifyCompleted(new VerifyCompletedEventArgs(isSuccessful, errorText));
        }

        public event EventHandler<VerifyAndAuthMessageApiEventArgs> VerifyAndAuthMessageApi;
        protected virtual void OnVerifyAndAuthMessageApi(VerifyAndAuthMessageApiEventArgs e) { VerifyAndAuthMessageApi?.Invoke(this, e); }
        public void verifyAndAuthMessageAPI(string apiData, string xyzChallenge)
        {
            OnVerifyAndAuthMessageApi(new VerifyAndAuthMessageApiEventArgs(apiData, xyzChallenge));
        }

        public event EventHandler<VerifyAndAuthCompletedEventArgs> VerifyAndAuthCompleted;
        protected virtual void OnVerifyAndAuthCompleted(VerifyAndAuthCompletedEventArgs e) { VerifyAndAuthCompleted?.Invoke(this, e); }
        public void verifyAndAuthCompleted(bool isSuccessful, string errorText)
        {
            OnVerifyAndAuthCompleted(new VerifyAndAuthCompletedEventArgs(isSuccessful, errorText));
        }

        /// <summary>
        /// This callback is a one-time response to queryDisplayGroups().
        /// </summary>
        /// <param name="reqId">The requestId specified in queryDisplayGroups().</param>
        /// <param name="groups">A list of integers representing visible group ID separated by the “|” character, and sorted by most used group first. This list will not change during TWS session (in other words, user cannot add a new group; sorting can change though). Example: "3|1|2"</param>
        public void displayGroupList(int reqId, string groups)
        {
            OnDisplayGroupList(new DisplayGroupListEventArgs(reqId, groups));
        }
        public event EventHandler<DisplayGroupListEventArgs> DisplayGroupList;
        protected virtual void OnDisplayGroupList(DisplayGroupListEventArgs e) { DisplayGroupList?.Invoke(this, e); }

        /// <summary>
        /// DisplayGroupUpdated event handler
        /// </summary>
        public event EventHandler<DisplayGroupUpdatedEventArgs> DisplayGroupUpdated;
        /// DisplayGroupUpdated event invocator
        /// </summary>
        protected virtual void OnDisplayGroupUpdated(DisplayGroupUpdatedEventArgs e)
        {
            DisplayGroupUpdated?.Invoke(this, e);
        }
        /// <summary>
        /// This is sent by TWS to the API client once after receiving the subscription request subscribeToGroupEvents(), and will be sent again if the selected contract in the subscribed display group has changed.
        /// </summary>
        /// <param name="reqId">The requestId specified in subscribeToGroupEvents().</param>
        /// <param name="contractInfo">The encoded value that uniquely represents the contract in IB.</param>
        public void displayGroupUpdated(int reqId, string contractInfo)
        {
            OnDisplayGroupUpdated(new DisplayGroupUpdatedEventArgs(reqId, contractInfo));
        }

        /// <summary>
        /// ConnectAck event handler
        /// </summary>
        public event EventHandler ConnectAck;
        /// <summary>
        /// ConnectAck event invocator
        /// </summary>
        protected virtual void OnConnectAck()
        {
            ConnectAck?.Invoke(this, EventArgs.Empty);
        }
        /// <summary>
        /// Callback signifying completion of successful connection.
        /// </summary>
        public void connectAck()
        {
            OnConnectAck();
        }

        /// <summary>
        /// PositionMulti event handler
        /// </summary>
        public event EventHandler<PositionMultiEventArgs> PositionMulti;
        /// <summary>
        /// PositionMulti event invocator
        /// </summary>
        protected virtual void OnPositionMulti(PositionMultiEventArgs e)
        {
            PositionMulti?.Invoke(this, e);
        }
        /// <summary>
        /// Provides the portfolio's open positions.
        /// </summary>
        /// <param name="requestId">The id of the request.</param>
        /// <param name="account">The account holding the position.</param>
        /// <param name="modelCode">The model code holding the position.</param>
        /// <param name="contract">The position's Contract.</param>
        /// <param name="pos">The number of positions held.</param>
        /// <param name="avgCost">The average cost of the position.</param>
        public void positionMulti(int requestId, string account, string modelCode, Contract contract, double pos, double avgCost)
        {
            OnPositionMulti(new PositionMultiEventArgs(requestId, account, modelCode, contract, pos, avgCost));
        }

        /// <summary>
        /// PositionMultiEnd event handler
        /// </summary>
        public event EventHandler<RequestEndEventArgs> PositionMultiEnd;
        /// <summary>
        /// PositionMultiEnd event invocator
        /// </summary>
        protected virtual void OnPositionMultiEnd(RequestEndEventArgs e)
        {
            PositionMultiEnd?.Invoke(this, e);
        }
        /// <summary>
        /// Indicates all the positions have been transmitted.
        /// </summary>
        /// <param name="requestId">The id of the request.</param>
        public void positionMultiEnd(int requestId)
        {
            OnPositionMultiEnd(new RequestEndEventArgs(requestId));
        }

        /// <summary>
        /// AccountUpdateMulti event handler
        /// </summary>
        public event EventHandler<AccountUpdateMultiEventArgs> AccountUpdateMulti;
        /// <summary>
        /// AccountUpdateMulti event invocator
        /// </summary>
        protected virtual void OnAccountUpdateMulti(AccountUpdateMultiEventArgs e)
        {
            AccountUpdateMulti?.Invoke(this, e);
        }
        /// <summary>
        /// Provides the account updates.
        /// </summary>
        /// <param name="requestId">The id of the request,</param>
        /// <param name="account">The account with updates.</param>
        /// <param name="modelCode">The model code with updates.</param>
        /// <param name="key">The name of parameter.</param>
        /// <param name="value">The value of parameter.</param>
        /// <param name="currency">The currency of parameter.</param>
        public void accountUpdateMulti(int requestId, string account, string modelCode, string key, string value, string currency)
        {
            OnAccountUpdateMulti(new AccountUpdateMultiEventArgs(requestId, account, modelCode, key, value, currency));
        }

        /// <summary>
        /// AccountUpdateMultiEnd event handler
        /// </summary>
        public event EventHandler<RequestEndEventArgs> AccountUpdateMultiEnd;
        /// <summary>
        /// AccountUpdateMultiEnd event invocator
        /// </summary>
        protected virtual void OnAccountUpdateMultiEnd(RequestEndEventArgs e)
        {
            AccountUpdateMultiEnd?.Invoke(this, e);
        }
        /// <summary>
        /// Indicates all the account updates have been transmitted.
        /// </summary>
        /// <param name="requestId">The id of the request.</param>
        public void accountUpdateMultiEnd(int requestId)
        {
            OnAccountUpdateMultiEnd(new RequestEndEventArgs(requestId));
        }

        /// <summary>
        /// SecurityDefinitionOptionParameter event handler
        /// </summary>
        public event EventHandler<SecurityDefinitionOptionParameterEventArgs> SecurityDefinitionOptionParameter;
        /// <summary>
        /// SecurityDefinitionOptionParameter event invocator
        /// </summary>
        protected virtual void OnSecurityDefinitionOptionParameter(SecurityDefinitionOptionParameterEventArgs e)
        {
            SecurityDefinitionOptionParameter?.Invoke(this, e);
        }
        /// <summary>
        /// Returns the option chain for an underlying on an exchange specified in reqSecDefOptParams.
        /// There will be multiple callbacks to securityDefinitionOptionParameter if multiple exchanges are specified in reqSecDefOptParams.
        /// </summary>
        /// <param name="reqId">ID of the request initiating the callback</param>
        /// <param name="exchange"></param>
        /// <param name="underlyingConId">The conID of the underlying security</param>
        /// <param name="tradingClass">The option trading class</param>
        /// <param name="multiplier">The option multiplier</param>
        /// <param name="expirations">A list of the expiries for the options of this underlying on this exchange</param>
        /// <param name="strikes">A list of the possible strikes for options of this underlying on this exchange</param>
        public void securityDefinitionOptionParameter(int reqId, string exchange, int underlyingConId, string tradingClass,
            string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            OnSecurityDefinitionOptionParameter(new SecurityDefinitionOptionParameterEventArgs(reqId, exchange, underlyingConId, tradingClass,
                multiplier, expirations, strikes));
        }

        /// <summary>
        /// SecurityDefinitionOptionParameterEnd event handler
        /// </summary>
        public event EventHandler<RequestEndEventArgs> SecurityDefinitionOptionParameterEnd;
        /// <summary>
        /// SecurityDefinitionOptionParameterEnd event invocator
        /// </summary>
        protected virtual void OnSecurityDefinitionOptionParameterEnd(RequestEndEventArgs e)
        {
            SecurityDefinitionOptionParameterEnd?.Invoke(this, e);
        }
        /// <summary>
        /// Called when all callbacks to securityDefinitionOptionParameter are complete
        /// </summary>
        /// <param name="reqId">the ID used in the call to securityDefinitionOptionParameter</param>
        public void securityDefinitionOptionParameterEnd(int reqId)
        {
            OnSecurityDefinitionOptionParameterEnd(new RequestEndEventArgs(reqId));
        }

        /// <summary>
        /// SoftDollarTiers event handler
        /// </summary>
        public event EventHandler<SoftDollarTiersEventArgs> SoftDollarTiers;
        /// <summary>
        /// SoftDollarTiers event invocator
        /// </summary>
        protected virtual void OnSoftDollarTiers(SoftDollarTiersEventArgs e)
        {
            SoftDollarTiers?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="reqId">The id of the request.</param>
        /// <param name="tiers"></param>
        public void softDollarTiers(int reqId, SoftDollarTier[] tiers)
        {
            OnSoftDollarTiers(new SoftDollarTiersEventArgs(reqId, tiers));
        }

        /// <summary>
        /// FamilyCodes event handler
        /// </summary>
        public event EventHandler<FamilyCodesEventArgs> FamilyCodes;
        /// <summary>
        /// FamilyCodes event invocator
        /// </summary>
        protected virtual void OnFamilyCodes(FamilyCodesEventArgs e)
        {
            FamilyCodes?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="familyCodes"></param>
        public void familyCodes(FamilyCode[] familyCodes)
        {
            OnFamilyCodes(new FamilyCodesEventArgs(familyCodes));
        }

        /// <summary>
        /// SymbolSamples event handler
        /// </summary>
        public event EventHandler<SymbolSamplesEventArgs> SymbolSamples;
        /// <summary>
        /// SymbolSamples event invocator
        /// </summary>
        protected virtual void OnSymbolSamples(SymbolSamplesEventArgs e)
        {
            SymbolSamples?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="reqId"></param>
        /// <param name="contractDescriptions"></param>
        public void symbolSamples(int reqId, ContractDescription[] contractDescriptions)
        {
            OnSymbolSamples(new SymbolSamplesEventArgs(reqId, contractDescriptions));
        }

        /// <summary>
        /// MktDepthExchanges event handler
        /// </summary>
        public event EventHandler<MktDepthExchangesEventArgs> MktDepthExchanges;
        /// <summary>
        /// MktDepthExchanges event invocator
        /// </summary>
        protected virtual void OnMktDepthExchanges(MktDepthExchangesEventArgs e)
        {
            MktDepthExchanges?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="depthMktDataDescriptions"></param>
        public void mktDepthExchanges(DepthMktDataDescription[] depthMktDataDescriptions)
        {
            OnMktDepthExchanges(new MktDepthExchangesEventArgs(depthMktDataDescriptions));
        }

        /// <summary>
        /// TickNews event handler
        /// </summary>
        public event EventHandler<TickNewsEventArgs> TickNews;
        /// <summary>
        /// TickNews event invocator
        /// </summary>
        protected virtual void OnTickNews(TickNewsEventArgs e)
        {
            TickNews?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="tickerId"></param>
        /// <param name="timeStamp"></param>
        /// <param name="providerCode"></param>
        /// <param name="articleId"></param>
        /// <param name="headline"></param>
        /// <param name="extraData"></param>
        public void tickNews(int tickerId, long timeStamp, string providerCode, string articleId, string headline, string extraData)
        {
            OnTickNews(new TickNewsEventArgs(tickerId, timeStamp, providerCode, articleId, headline, extraData));
        }

        /// <summary>
        /// SmartComponents event handler
        /// </summary>
        public event EventHandler<SmartComponentsEventArgs> SmartComponents;
        /// <summary>
        /// SmartComponents event invocator
        /// </summary>
        protected virtual void OnSmartComponents(SmartComponentsEventArgs e)
        {
            SmartComponents?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="reqId"></param>
        /// <param name="theMap"></param>
        public void smartComponents(int reqId, Dictionary<int, KeyValuePair<string, char>> theMap)
        {
            OnSmartComponents(new SmartComponentsEventArgs(reqId, theMap));
        }

        /// <summary>
        /// TickReqParams event handler
        /// </summary>
        public event EventHandler<TickReqParamsEventArgs> TickReqParams;
        /// <summary>
        /// TickReqParams event invocator
        /// </summary>
        protected virtual void OnTickReqParams(TickReqParamsEventArgs e)
        {
            TickReqParams?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="tickerId"></param>
        /// <param name="minTick"></param>
        /// <param name="bboExchange"></param>
        /// <param name="snapshotPermissions"></param>
        public void tickReqParams(int tickerId, double minTick, string bboExchange, int snapshotPermissions)
        {
            OnTickReqParams(new TickReqParamsEventArgs(tickerId, minTick, bboExchange, snapshotPermissions));
        }

        /// <summary>
        /// NewsProviders event handler
        /// </summary>
        public event EventHandler<NewsProvidersEventArgs> NewsProviders;
        /// <summary>
        /// NewsProviders event invocator
        /// </summary>
        protected virtual void OnNewsProviders(NewsProvidersEventArgs e)
        {
            NewsProviders?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="newsProviders"></param>
        public void newsProviders(NewsProvider[] newsProviders)
        {
            OnNewsProviders(new NewsProvidersEventArgs(newsProviders));
        }

        /// <summary>
        /// NewsArticle event handler
        /// </summary>
        public event EventHandler<NewsArticleEventArgs> NewsArticle;
        /// <summary>
        /// NewsArticle event invocator
        /// </summary>
        protected virtual void OnNewsArticle(NewsArticleEventArgs e)
        {
            NewsArticle?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="articleType"></param>
        /// <param name="articleText"></param>
        public void newsArticle(int requestId, int articleType, string articleText)
        {
            OnNewsArticle(new NewsArticleEventArgs(requestId, articleType, articleText));
        }

        /// <summary>
        /// HistoricalNews event handler
        /// </summary>
        public event EventHandler<HistoricalNewsEventArgs> HistoricalNews;
        /// <summary>
        /// HistoricalNews event invocator
        /// </summary>
        protected virtual void OnHistoricalNews(HistoricalNewsEventArgs e)
        {
            HistoricalNews?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="time"></param>
        /// <param name="providerCode"></param>
        /// <param name="articleId"></param>
        /// <param name="headline"></param>
        public void historicalNews(int requestId, string time, string providerCode, string articleId, string headline)
        {
            OnHistoricalNews(new HistoricalNewsEventArgs(requestId, time, providerCode, articleId, headline));
        }

        /// <summary>
        /// HistoricalNewsEnd event handler
        /// </summary>
        public event EventHandler<HistoricalNewsEndEventArgs> HistoricalNewsEnd;
        /// <summary>
        /// HistoricalNewsEnd event invocator
        /// </summary>
        protected virtual void OnHistoricalNewsEnd(HistoricalNewsEndEventArgs e)
        {
            HistoricalNewsEnd?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="hasMore"></param>
        public void historicalNewsEnd(int requestId, bool hasMore)
        {
            OnHistoricalNewsEnd(new HistoricalNewsEndEventArgs(requestId, hasMore));
        }

        /// <summary>
        /// HeadTimestamp event handler
        /// </summary>
        public event EventHandler<HeadTimestampEventArgs> HeadTimestamp;
        /// <summary>
        /// HeadTimestamp event invocator
        /// </summary>
        protected virtual void OnHeadTimestamp(HeadTimestampEventArgs e)
        {
            HeadTimestamp?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="reqId"></param>
        /// <param name="headTimestamp"></param>
        public void headTimestamp(int reqId, string headTimestamp)
        {
            OnHeadTimestamp(new HeadTimestampEventArgs(reqId, headTimestamp));
        }

        /// <summary>
        /// HistogramData event handler
        /// </summary>
        public event EventHandler<HistogramDataEventArgs> HistogramData;
        /// <summary>
        /// HistogramData event invocator
        /// </summary>
        protected virtual void OnHistogramData(HistogramDataEventArgs e)
        {
            HistogramData?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="reqId"></param>
        /// <param name="data"></param>
        public void histogramData(int reqId, HistogramEntry[] data)
        {
            OnHistogramData(new HistogramDataEventArgs(reqId, data));
        }

        /// <summary>
        /// RerouteMktDataReq event handler
        /// </summary>
        public event EventHandler<RerouteMktDataReqEventArgs> RerouteMktDataReq;
        /// <summary>
        /// RerouteMktDataReq event invocator
        /// </summary>
        protected virtual void OnRerouteMktDataReq(RerouteMktDataReqEventArgs e)
        {
            RerouteMktDataReq?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="reqId"></param>
        /// <param name="conId"></param>
        /// <param name="exchange"></param>
        public void rerouteMktDataReq(int reqId, int conId, string exchange)
        {
            OnRerouteMktDataReq(new RerouteMktDataReqEventArgs(reqId, conId, exchange));
        }

        /// <summary>
        /// RerouteMktDepthReq event handler
        /// </summary>
        public event EventHandler<RerouteMktDepthReqEventArgs> RerouteMktDepthReq;
        /// <summary>
        /// RerouteMktDepthReq event invocator
        /// </summary>
        protected virtual void OnRerouteMktDepthReq(RerouteMktDepthReqEventArgs e)
        {
            RerouteMktDepthReq?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="reqId"></param>
        /// <param name="conId"></param>
        /// <param name="exchange"></param>
        public void rerouteMktDepthReq(int reqId, int conId, string exchange)
        {
            OnRerouteMktDepthReq(new RerouteMktDepthReqEventArgs(reqId, conId, exchange));
        }

        /// <summary>
        /// MarketRule event handler
        /// </summary>
        public event EventHandler<MarketRuleEventArgs> MarketRule;
        /// <summary>
        /// MarketRule event invocator
        /// </summary>
        protected virtual void OnMarketRule(MarketRuleEventArgs e)
        {
            MarketRule?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="marketRuleId"></param>
        /// <param name="priceIncrements"></param>
        public void marketRule(int marketRuleId, PriceIncrement[] priceIncrements)
        {
            OnMarketRule(new MarketRuleEventArgs(marketRuleId, priceIncrements));
        }

        /// <summary>
        /// PnlSingle event handler
        /// </summary>
        public event EventHandler<PnlSingleEventArgs> PnlSingle;
        /// <summary>
        /// PnlSingle event invocator
        /// </summary>
        protected virtual void OnPnlSingle(PnlSingleEventArgs e)
        {
            PnlSingle?.Invoke(this, e);
        }
        /// <summary>
        /// Pnl event handler
        /// </summary>
        public event EventHandler<PnlEventArgs> Pnl;
        /// <summary>
        /// Pnl event invocator
        /// </summary>
        protected virtual void OnPnl(PnlEventArgs e)
        {
            Pnl?.Invoke(this, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="reqId"></param>
        /// <param name="dailyPnL"></param>
        /// <param name="unrealizedPnL"></param>
        public void pnl(int reqId, double dailyPnL, double unrealizedPnL, double realizedPnL)
        {
            OnPnl(new PnlEventArgs(reqId, dailyPnL, unrealizedPnL));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="reqId"></param>
        /// <param name="pos"></param>
        /// <param name="dailyPnL"></param>
        /// <param name="unrealizedPnL"></param>
        /// <param name="value"></param>
        public void pnlSingle(int reqId, int pos, double dailyPnL, double unrealizedPnL, double realizedPnL, double value)
        {
            OnPnlSingle(new PnlSingleEventArgs(reqId, pos, dailyPnL, unrealizedPnL, realizedPnL, value));
        }

        public void historicalTicks(int reqId, HistoricalTick[] ticks, bool done)
        {
            throw new NotImplementedException();
        }

        public void historicalTicksBidAsk(int reqId, HistoricalTickBidAsk[] ticks, bool done)
        {
            throw new NotImplementedException();
        }

        public void historicalTicksLast(int reqId, HistoricalTickLast[] ticks, bool done)
        {
            throw new NotImplementedException();
        }

        public void tickByTickAllLast(int reqId, int tickType, long time, double price, int size, TickAttribLast tickAttriblast,
            string exchange, string specialConditions)
        {
            throw new NotImplementedException();
        }

        public void tickByTickBidAsk(int reqId, long time, double bidPrice, double askPrice, int bidSize, int askSize,
            TickAttribBidAsk tickAttribBidAsk)
        {
            throw new NotImplementedException();
        }

        public void tickByTickMidPoint(int reqId, long time, double midPoint)
        {
            throw new NotImplementedException();
        }

        public void orderBound(long orderId, int apiClientId, int apiOrderId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the data from the TWS Account Window Summary tab.
        /// </summary>
        public event EventHandler<AccountSummaryEventArgs> AccountSummaryFA;
        /// <summary>
        /// Called internally when the receive thread receives a accountSummary event.
        /// </summary>
        /// <param name="e">accountSummary Event Arguments</param>
        protected virtual void OnAccountSummary(AccountSummaryEventArgs e) { AccountSummaryFA?.Invoke(this, e); }
        public void accountSummary(int reqId, string account, string tag, string value, string currency)
        {
            var e = new AccountSummaryEventArgs(reqId, account, tag, value, currency);
            OnAccountSummary(e);
        }

        /// <summary>
        /// Notifies when all the accounts' information has ben received.
        /// </summary>
        public event EventHandler<AccountSummaryEndEventArgs> AccountSummaryFAEnd;
        /// <summary>
        /// Called internally when the receive thread receives a accountSummaryEnd event.
        /// </summary>
        /// <param name="e">accountSummaryEnd Event Arguments</param>
        protected virtual void OnAccountSummaryEnd(AccountSummaryEndEventArgs e) { AccountSummaryFAEnd?.Invoke(this, e); }
        public void accountSummaryEnd(int reqId)
        {
            var e = new AccountSummaryEndEventArgs(reqId);
            OnAccountSummaryEnd(e);
        }

        /// <summary>
        /// Returns the data from the TWS Account Window Summary tab.
        /// </summary>
        public event EventHandler<PositionEventArgs> PositionFA;
        /// <summary>
        /// Called internally when the receive thread receives a position event.
        /// </summary>
        /// <param name="e">position Event Arguments</param>
        protected virtual void OnPosition(PositionEventArgs e) { PositionFA?.Invoke(this, e); }
        public void position(string account, Contract contract, double pos, double avgCost)
        {
            var e = new PositionEventArgs(account, contract, (int)pos, avgCost);
            OnPosition(e);
        }

        /// <summary>
        /// This method receives the requested historical data results
        /// </summary>
        public event EventHandler<PositionEndEventArgs> PositionFAEnd;
        /// <summary>
        /// Called internally when the receive thread receives a positionEnd event.
        /// </summary>
        /// <param name="e">positionEnd Event Arguments</param>
        protected virtual void OnPositionEnd(PositionEndEventArgs e) { PositionFAEnd?.Invoke(this, e); }
        public void positionEnd()
        {
            var e = new PositionEndEventArgs();
            OnPositionEnd(e);
        }
        #endregion
        #endregion


    }
}