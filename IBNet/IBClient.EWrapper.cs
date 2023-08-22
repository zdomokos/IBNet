/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;
using System.Collections.Generic;
using System.Linq;
using IBApi;
using System.Threading;
using System.Threading.Tasks;
using IBNet.Messages;

namespace IBNet
{
    public partial class IBClient : EWrapper
    {
        public Task<Contract> ResolveContractAsync(int conId, string refExch)
        {
            var reqId         = new Random(DateTime.Now.Millisecond).Next();
            var resolveResult = new TaskCompletionSource<Contract>();
            var resolveContract_Error = new Action<int, int, string, string, Exception>((id, code, msg, advancedOrderRejectJson, ex) =>
            {
                if (reqId != id)
                    return;

                resolveResult.SetResult(null);
            });
            var resolveContract = new Action<ContractDetailsMessage>(msg =>
            {
                if (msg.RequestId == reqId)
                    resolveResult.SetResult(msg.ContractDetails.Contract);
            });
            var contractDetailsEnd = new Action<int>(id =>
            {
                if (reqId == id && !resolveResult.Task.IsCompleted)
                    resolveResult.SetResult(null);
            });

            var tmpError              = Error;
            var tmpContractDetails    = ContractDetails;
            var tmpContractDetailsEnd = ContractDetailsEnd;

            Error              = resolveContract_Error;
            ContractDetails    = resolveContract;
            ContractDetailsEnd = contractDetailsEnd;

            resolveResult.Task.ContinueWith(t =>
            {
                Error              = tmpError;
                ContractDetails    = tmpContractDetails;
                ContractDetailsEnd = tmpContractDetailsEnd;
            });

            ClientSocket.reqContractDetails(reqId, new Contract
                                                   { ConId = conId, Exchange = refExch });

            return resolveResult.Task;
        }

        public Task<Contract[]> ResolveContractAsync(string secType, string symbol, string currency, string exchange)
        {
            var reqId        = new Random(DateTime.Now.Millisecond).Next();
            var res          = new TaskCompletionSource<Contract[]>();
            var contractList = new List<Contract>();
            var resolveContract_Error = new Action<int, int, string, string, Exception>((id, code, msg, advancedOrderRejectJson, ex) =>
            {
                if (reqId != id)
                    return;

                res.SetResult(new Contract[0]);
            });
            var contractDetails = new Action<ContractDetailsMessage>(msg =>
            {
                if (reqId != msg.RequestId)
                    return;

                contractList.Add(msg.ContractDetails.Contract);
            });
            var contractDetailsEnd = new Action<int>(id =>
            {
                if (reqId == id)
                    res.SetResult(contractList.ToArray());
            });

            var tmpError              = Error;
            var tmpContractDetails    = ContractDetails;
            var tmpContractDetailsEnd = ContractDetailsEnd;

            Error              = resolveContract_Error;
            ContractDetails    = contractDetails;
            ContractDetailsEnd = contractDetailsEnd;

            res.Task.ContinueWith(t =>
            {
                Error              = tmpError;
                ContractDetails    = tmpContractDetails;
                ContractDetailsEnd = tmpContractDetailsEnd;
            });

            ClientSocket.reqContractDetails(reqId, new Contract
                                                   { SecType = secType, Symbol = symbol, Currency = currency, Exchange = exchange });

            return res.Task;
        }

        public int ClientId { get; set; }

        SynchronizationContext sc;

        public IBClient(EReaderSignal signal)
        {
            ClientSocket = new EClientSocket(this, signal);
            sc           = SynchronizationContext.Current;
        }

        public EClientSocket ClientSocket { get; private set; }

        public int NextOrderId { get; set; }

        public event Action<int, int, string, string, Exception> Error;

        void EWrapper.error(Exception e)
        {
            var tmp = Error;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(0, 0, null, null, e), null);
                else
                    tmp(0, 0, null, null, e);
            }
        }

        void EWrapper.error(string str)
        {
            var tmp = Error;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(0, 0, str, null, null), null);
                else
                    tmp(0, 0, str, null, null);
            }
        }

        void EWrapper.error(int id, int errorCode, string errorMsg, string advancedOrderRejectJson)
        {
            var tmp = Error;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(id, errorCode, errorMsg, advancedOrderRejectJson, null), null);
                else
                    tmp(id, errorCode, errorMsg, advancedOrderRejectJson, null);
            }
        }

        public event Action ConnectionClosed;

        void EWrapper.connectionClosed()
        {
            var tmp = ConnectionClosed;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(), null);
                else
                    tmp();
            }
        }

        public event Action<long> CurrentTime;

        void EWrapper.currentTime(long time)
        {
            var tmp = CurrentTime;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(time), null);
                else
                    tmp(time);
            }
        }

        public event Action<TickPriceMessage> TickPrice;

        void EWrapper.tickPrice(int tickerId, int field, double price, TickAttrib attribs)
        {
            var tmp = TickPrice;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new TickPriceMessage(tickerId, field, price, attribs)), null);
                else
                    tmp(new TickPriceMessage(tickerId, field, price, attribs));
            }
        }

        public event Action<TickSizeMessage> TickSize;

        void EWrapper.tickSize(int tickerId, int field, decimal size)
        {
            var tmp = TickSize;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new TickSizeMessage(tickerId, field, size)), null);
                else
                    tmp(new TickSizeMessage(tickerId, field, size));
            }
        }

        public event Action<int, int, string> TickString;

        void EWrapper.tickString(int tickerId, int tickType, string value)
        {
            var tmp = TickString;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(tickerId, tickType, value), null);
                else
                    tmp(tickerId, tickType, value);
            }
        }

        public event Action<TickGenericMessage> TickGeneric;

        void EWrapper.tickGeneric(int tickerId, int field, double value)
        {
            var tmp = TickGeneric;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new TickGenericMessage(tickerId, field, value)), null);
                else
                    tmp(new TickGenericMessage(tickerId, field, value));
            }
        }

        public event Action<int, int, double, string, double, int, string, double, double> TickEFP;

        void EWrapper.tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture, int holdDays, string futureLastTradeDate, double dividendImpact, double dividendsToLastTradeDate)
        {
            var tmp = TickEFP;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(tickerId, tickType, basisPoints, formattedBasisPoints, impliedFuture, holdDays, futureLastTradeDate, dividendImpact, dividendsToLastTradeDate), null);
                else
                    tmp(tickerId, tickType, basisPoints, formattedBasisPoints, impliedFuture, holdDays, futureLastTradeDate, dividendImpact, dividendsToLastTradeDate);
            }
        }

        public event Action<int> TickSnapshotEnd;

        void EWrapper.tickSnapshotEnd(int tickerId)
        {
            var tmp = TickSnapshotEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(tickerId), null);
                else
                    tmp(tickerId);
            }
        }

        public event Action<ConnectionStatusMessage> NextValidId;

        void EWrapper.nextValidId(int orderId)
        {
            var tmp = NextValidId;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new ConnectionStatusMessage(true)), null);
                else
                    tmp(new ConnectionStatusMessage(true));
            }

            NextOrderId = orderId;
        }

        public event Action<int, DeltaNeutralContract> DeltaNeutralValidation;

        void EWrapper.deltaNeutralValidation(int reqId, DeltaNeutralContract deltaNeutralContract)
        {
            var tmp = DeltaNeutralValidation;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId, deltaNeutralContract), null);
                else
                    tmp(reqId, deltaNeutralContract);
            }
        }

        public event Action<ManagedAccountsMessage> ManagedAccounts;

        void EWrapper.managedAccounts(string accountsList)
        {
            var tmp = ManagedAccounts;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new ManagedAccountsMessage(accountsList)), null);
                else
                    tmp(new ManagedAccountsMessage(accountsList));
            }
        }

        public event Action<TickOptionMessage> TickOptionCommunication;

        void EWrapper.tickOptionComputation(int tickerId, int field, int tickAttrib, double impliedVolatility, double delta, double optPrice, double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            var tmp = TickOptionCommunication;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new TickOptionMessage(tickerId, field, tickAttrib, impliedVolatility, delta, optPrice, pvDividend, gamma, vega, theta, undPrice)), null);
                else
                    tmp(new TickOptionMessage(tickerId, field, tickAttrib, impliedVolatility, delta, optPrice, pvDividend, gamma, vega, theta, undPrice));
            }
        }

        public event Action<AccountSummaryMessage> AccountSummary;

        void EWrapper.accountSummary(int reqId, string account, string tag, string value, string currency)
        {
            var tmp = AccountSummary;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new AccountSummaryMessage(reqId, account, tag, value, currency)), null);
                else
                    tmp(new AccountSummaryMessage(reqId, account, tag, value, currency));
            }
        }

        public event Action<AccountSummaryEndMessage> AccountSummaryEnd;

        void EWrapper.accountSummaryEnd(int reqId)
        {
            var tmp = AccountSummaryEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new AccountSummaryEndMessage(reqId)), null);
                else
                    tmp(new AccountSummaryEndMessage(reqId));
            }
        }

        public event Action<AccountValueMessage> UpdateAccountValue;

        void EWrapper.updateAccountValue(string key, string value, string currency, string accountName)
        {
            var tmp = UpdateAccountValue;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new AccountValueMessage(key, value, currency, accountName)), null);
                else
                    tmp(new AccountValueMessage(key, value, currency, accountName));
            }
        }

        public event Action<UpdatePortfolioMessage> UpdatePortfolio;

        void EWrapper.updatePortfolio(Contract contract, decimal position, double marketPrice, double marketValue, double averageCost, double unrealizedPNL, double realizedPNL, string accountName)
        {
            var tmp = UpdatePortfolio;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new UpdatePortfolioMessage(contract, position, marketPrice, marketValue, averageCost, unrealizedPNL, realizedPNL, accountName)), null);
                else
                    tmp(new UpdatePortfolioMessage(contract, position, marketPrice, marketValue, averageCost, unrealizedPNL, realizedPNL, accountName));
            }
        }

        public event Action<UpdateAccountTimeMessage> UpdateAccountTime;

        void EWrapper.updateAccountTime(string timestamp)
        {
            var tmp = UpdateAccountTime;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new UpdateAccountTimeMessage(timestamp)), null);
                else
                    tmp(new UpdateAccountTimeMessage(timestamp));
            }
        }

        public event Action<AccountDownloadEndMessage> AccountDownloadEnd;

        void EWrapper.accountDownloadEnd(string account)
        {
            var tmp = AccountDownloadEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new AccountDownloadEndMessage(account)), null);
                else
                    tmp(new AccountDownloadEndMessage(account));
            }
        }

        public event Action<OrderStatusMessage> OrderStatus;

        void EWrapper.orderStatus(int orderId, string status, decimal filled, decimal remaining, double avgFillPrice, int permId, int parentId, double lastFillPrice, int clientId, string whyHeld, double mktCapPrice)
        {
            var tmp = OrderStatus;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new OrderStatusMessage(orderId, status, filled, remaining, avgFillPrice, permId, parentId, lastFillPrice, clientId, whyHeld, mktCapPrice)), null);
                else
                    tmp(new OrderStatusMessage(orderId, status, filled, remaining, avgFillPrice, permId, parentId, lastFillPrice, clientId, whyHeld, mktCapPrice));
            }
        }

        public event Action<OpenOrderMessage> OpenOrder;

        void EWrapper.openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            var tmp = OpenOrder;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new OpenOrderMessage(orderId, contract, order, orderState)), null);
                else
                    tmp(new OpenOrderMessage(orderId, contract, order, orderState));
            }
        }

        public event Action OpenOrderEnd;

        void EWrapper.openOrderEnd()
        {
            var tmp = OpenOrderEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(), null);
                else
                    tmp();
            }
        }

        public event Action<ContractDetailsMessage> ContractDetails;

        void EWrapper.contractDetails(int reqId, ContractDetails contractDetails)
        {
            var tmp = ContractDetails;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new ContractDetailsMessage(reqId, contractDetails)), null);
                else
                    tmp(new ContractDetailsMessage(reqId, contractDetails));
            }
        }

        public event Action<int> ContractDetailsEnd;

        void EWrapper.contractDetailsEnd(int reqId)
        {
            var tmp = ContractDetailsEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId), null);
                else
                    tmp(reqId);
            }
        }

        public event Action<ExecutionMessage> ExecDetails;

        void EWrapper.execDetails(int reqId, Contract contract, Execution execution)
        {
            var tmp = ExecDetails;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new ExecutionMessage(reqId, contract, execution)), null);
                else
                    tmp(new ExecutionMessage(reqId, contract, execution));
            }
        }

        public event Action<int> ExecDetailsEnd;

        void EWrapper.execDetailsEnd(int reqId)
        {
            var tmp = ExecDetailsEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId), null);
                else
                    tmp(reqId);
            }
        }

        public event Action<CommissionReport> CommissionReport;

        void EWrapper.commissionReport(CommissionReport commissionReport)
        {
            var tmp = CommissionReport;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(commissionReport), null);
                else
                    tmp(commissionReport);
            }
        }

        public event Action<FundamentalsMessage> FundamentalData;

        void EWrapper.fundamentalData(int reqId, string data)
        {
            var tmp = FundamentalData;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new FundamentalsMessage(data)), null);
                else
                    tmp(new FundamentalsMessage(data));
            }
        }

        public event Action<HistoricalDataMessage> HistoricalData;

        void EWrapper.historicalData(int reqId, Bar bar)
        {
            var tmp = HistoricalData;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new HistoricalDataMessage(reqId, bar)), null);
                else
                    tmp(new HistoricalDataMessage(reqId, bar));
            }
        }

        public event Action<HistoricalDataEndMessage> HistoricalDataEnd;

        void EWrapper.historicalDataEnd(int reqId, string startDate, string endDate)
        {
            var tmp = HistoricalDataEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new HistoricalDataEndMessage(reqId, startDate, endDate)), null);
                else
                    tmp(new HistoricalDataEndMessage(reqId, startDate, endDate));
            }
        }

        public event Action<MarketDataTypeMessage> MarketDataType;

        void EWrapper.marketDataType(int reqId, int marketDataType)
        {
            var tmp = MarketDataType;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new MarketDataTypeMessage(reqId, marketDataType)), null);
                else
                    tmp(new MarketDataTypeMessage(reqId, marketDataType));
            }
        }

        public event Action<DeepBookMessage> UpdateMktDepth;

        void EWrapper.updateMktDepth(int tickerId, int position, int operation, int side, double price, decimal size)
        {
            var tmp = UpdateMktDepth;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new DeepBookMessage(tickerId, position, operation, side, price, size, "", false)), null);
                else
                    tmp(new DeepBookMessage(tickerId, position, operation, side, price, size, "", false));
            }
        }

        public event Action<DeepBookMessage> UpdateMktDepthL2;

        void EWrapper.updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, decimal size, bool isSmartDepth)
        {
            var tmp = UpdateMktDepthL2;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new DeepBookMessage(tickerId, position, operation, side, price, size, marketMaker, isSmartDepth)), null);
                else
                    tmp(new DeepBookMessage(tickerId, position, operation, side, price, size, marketMaker, isSmartDepth));
            }
        }

        public event Action<int, int, string, string> UpdateNewsBulletin;

        void EWrapper.updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            var tmp = UpdateNewsBulletin;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(msgId, msgType, message, origExchange), null);
                else
                    tmp(msgId, msgType, message, origExchange);
            }
        }

        public event Action<PositionMessage> Position;

        void EWrapper.position(string account, Contract contract, decimal pos, double avgCost)
        {
            var tmp = Position;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new PositionMessage(account, contract, pos, avgCost)), null);
                else
                    tmp(new PositionMessage(account, contract, pos, avgCost));
            }
        }

        public event Action PositionEnd;

        void EWrapper.positionEnd()
        {
            var tmp = PositionEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(), null);
                else
                    tmp();
            }
        }

        public event Action<RealTimeBarMessage> RealtimeBar;

        void EWrapper.realtimeBar(int reqId, long time, double open, double high, double low, double close, decimal volume, decimal WAP, int count)
        {
            var tmp = RealtimeBar;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new RealTimeBarMessage(reqId, time, open, high, low, close, volume, WAP, count)), null);
                else
                    tmp(new RealTimeBarMessage(reqId, time, open, high, low, close, volume, WAP, count));
            }
        }

        public event Action<string> ScannerParameters;

        void EWrapper.scannerParameters(string xml)
        {
            var tmp = ScannerParameters;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(xml), null);
                else
                    tmp(xml);
            }
        }

        public event Action<ScannerMessage> ScannerData;

        void EWrapper.scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
            var tmp = ScannerData;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new ScannerMessage(reqId, rank, contractDetails, distance, benchmark, projection, legsStr)), null);
                else
                    tmp(new ScannerMessage(reqId, rank, contractDetails, distance, benchmark, projection, legsStr));
            }
        }

        public event Action<int> ScannerDataEnd;

        void EWrapper.scannerDataEnd(int reqId)
        {
            var tmp = ScannerDataEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId), null);
                else
                    tmp(reqId);
            }
        }

        public event Action<AdvisorDataMessage> ReceiveFA;

        void EWrapper.receiveFA(int faDataType, string faXmlData)
        {
            var tmp = ReceiveFA;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new AdvisorDataMessage(faDataType, faXmlData)), null);
                else
                    tmp(new AdvisorDataMessage(faDataType, faXmlData));
            }
        }

        public event Action<BondContractDetailsMessage> BondContractDetails;

        void EWrapper.bondContractDetails(int requestId, ContractDetails contractDetails)
        {
            var tmp = BondContractDetails;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new BondContractDetailsMessage(requestId, contractDetails)), null);
                else
                    tmp(new BondContractDetailsMessage(requestId, contractDetails));
            }
        }

        public event Action<string> VerifyMessageAPI;

        void EWrapper.verifyMessageAPI(string apiData)
        {
            var tmp = VerifyMessageAPI;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(apiData), null);
                else
                    tmp(apiData);
            }
        }

        public event Action<bool, string> VerifyCompleted;

        void EWrapper.verifyCompleted(bool isSuccessful, string errorText)
        {
            var tmp = VerifyCompleted;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(isSuccessful, errorText), null);
                else
                    tmp(isSuccessful, errorText);
            }
        }

        public event Action<string, string> VerifyAndAuthMessageAPI;

        void EWrapper.verifyAndAuthMessageAPI(string apiData, string xyzChallenge)
        {
            var tmp = VerifyAndAuthMessageAPI;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(apiData, xyzChallenge), null);
                else
                    tmp(apiData, xyzChallenge);
            }
        }

        public event Action<bool, string> VerifyAndAuthCompleted;

        void EWrapper.verifyAndAuthCompleted(bool isSuccessful, string errorText)
        {
            var tmp = VerifyAndAuthCompleted;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(isSuccessful, errorText), null);
                else
                    tmp(isSuccessful, errorText);
            }
        }

        public event Action<int, string> DisplayGroupList;

        void EWrapper.displayGroupList(int reqId, string groups)
        {
            var tmp = DisplayGroupList;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId, groups), null);
                else
                    tmp(reqId, groups);
            }
        }

        public event Action<int, string> DisplayGroupUpdated;

        void EWrapper.displayGroupUpdated(int reqId, string contractInfo)
        {
            var tmp = DisplayGroupUpdated;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId, contractInfo), null);
                else
                    tmp(reqId, contractInfo);
            }
        }


        void EWrapper.connectAck()
        {
            if (ClientSocket.AsyncEConnect)
                ClientSocket.startApi();
        }

        public event Action<PositionMultiMessage> PositionMulti;

        void EWrapper.positionMulti(int reqId, string account, string modelCode, Contract contract, decimal pos, double avgCost)
        {
            var tmp = PositionMulti;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new PositionMultiMessage(reqId, account, modelCode, contract, pos, avgCost)), null);
                else
                    tmp(new PositionMultiMessage(reqId, account, modelCode, contract, pos, avgCost));
            }
        }

        public event Action<int> PositionMultiEnd;

        void EWrapper.positionMultiEnd(int reqId)
        {
            var tmp = PositionMultiEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId), null);
                else
                    tmp(reqId);
            }
        }

        public event Action<AccountUpdateMultiMessage> AccountUpdateMulti;

        void EWrapper.accountUpdateMulti(int reqId, string account, string modelCode, string key, string value, string currency)
        {
            var tmp = AccountUpdateMulti;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new AccountUpdateMultiMessage(reqId, account, modelCode, key, value, currency)), null);
                else
                    tmp(new AccountUpdateMultiMessage(reqId, account, modelCode, key, value, currency));
            }
        }

        public event Action<int> AccountUpdateMultiEnd;

        void EWrapper.accountUpdateMultiEnd(int reqId)
        {
            var tmp = AccountUpdateMultiEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId), null);
                else
                    tmp(reqId);
            }
        }

        public event Action<SecurityDefinitionOptionParameterMessage> SecurityDefinitionOptionParameter;

        void EWrapper.securityDefinitionOptionParameter(int reqId, string exchange, int underlyingConId, string tradingClass, string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            var tmp = SecurityDefinitionOptionParameter;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new SecurityDefinitionOptionParameterMessage(reqId, exchange, underlyingConId, tradingClass, multiplier, expirations, strikes)), null);
                else
                    tmp(new SecurityDefinitionOptionParameterMessage(reqId, exchange, underlyingConId, tradingClass, multiplier, expirations, strikes));
            }
        }

        public event Action<int> SecurityDefinitionOptionParameterEnd;

        void EWrapper.securityDefinitionOptionParameterEnd(int reqId)
        {
            var tmp = SecurityDefinitionOptionParameterEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId), null);
                else
                    tmp(reqId);
            }
        }

        public event Action<SoftDollarTiersMessage> SoftDollarTiers;

        void EWrapper.softDollarTiers(int reqId, SoftDollarTier[] tiers)
        {
            var tmp = SoftDollarTiers;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new SoftDollarTiersMessage(reqId, tiers)), null);
                else
                    tmp(new SoftDollarTiersMessage(reqId, tiers));
            }
        }

        public event Action<FamilyCode[]> FamilyCodes;

        void EWrapper.familyCodes(FamilyCode[] familyCodes)
        {
            var tmp = FamilyCodes;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(familyCodes), null);
                else
                    tmp(familyCodes);
            }
        }

        public event Action<SymbolSamplesMessage> SymbolSamples;

        void EWrapper.symbolSamples(int reqId, ContractDescription[] contractDescriptions)
        {
            var tmp = SymbolSamples;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new SymbolSamplesMessage(reqId, contractDescriptions)), null);
                else
                    tmp(new SymbolSamplesMessage(reqId, contractDescriptions));
            }
        }


        public event Action<DepthMktDataDescription[]> MktDepthExchanges;

        void EWrapper.mktDepthExchanges(DepthMktDataDescription[] depthMktDataDescriptions)
        {
            var tmp = MktDepthExchanges;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(depthMktDataDescriptions), null);
                else
                    tmp(depthMktDataDescriptions);
            }
        }

        public event Action<TickNewsMessage> TickNews;

        void EWrapper.tickNews(int tickerId, long timeStamp, string providerCode, string articleId, string headline, string extraData)
        {
            var tmp = TickNews;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new TickNewsMessage(tickerId, timeStamp, providerCode, articleId, headline, extraData)), null);
                else
                    tmp(new TickNewsMessage(tickerId, timeStamp, providerCode, articleId, headline, extraData));
            }
        }

        public event Action<int, Dictionary<int, KeyValuePair<string, char>>> SmartComponents;

        void EWrapper.smartComponents(int reqId, Dictionary<int, KeyValuePair<string, char>> theMap)
        {
            var tmp = SmartComponents;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId, theMap), null);
                else
                    tmp(reqId, theMap);
            }
        }

        public event Action<TickReqParamsMessage> TickReqParams;

        void EWrapper.tickReqParams(int tickerId, double minTick, string bboExchange, int snapshotPermissions)
        {
            var tmp = TickReqParams;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new TickReqParamsMessage(tickerId, minTick, bboExchange, snapshotPermissions)), null);
                else
                    tmp(new TickReqParamsMessage(tickerId, minTick, bboExchange, snapshotPermissions));
            }
        }

        public event Action<NewsProvider[]> NewsProviders;

        void EWrapper.newsProviders(NewsProvider[] newsProviders)
        {
            var tmp = NewsProviders;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(newsProviders), null);
                else
                    tmp(newsProviders);
            }
        }

        public event Action<NewsArticleMessage> NewsArticle;

        void EWrapper.newsArticle(int requestId, int articleType, string articleText)
        {
            var tmp = NewsArticle;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new NewsArticleMessage(requestId, articleType, articleText)), null);
                else
                    tmp(new NewsArticleMessage(requestId, articleType, articleText));
            }
        }

        public event Action<HistoricalNewsMessage> HistoricalNews;

        void EWrapper.historicalNews(int requestId, string time, string providerCode, string articleId, string headline)
        {
            var tmp = HistoricalNews;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new HistoricalNewsMessage(requestId, time, providerCode, articleId, headline)), null);
                else
                    tmp(new HistoricalNewsMessage(requestId, time, providerCode, articleId, headline));
            }
        }

        public event Action<HistoricalNewsEndMessage> HistoricalNewsEnd;

        void EWrapper.historicalNewsEnd(int requestId, bool hasMore)
        {
            var tmp = HistoricalNewsEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new HistoricalNewsEndMessage(requestId, hasMore)), null);
                else
                    tmp(new HistoricalNewsEndMessage(requestId, hasMore));
            }
        }

        public event Action<HeadTimestampMessage> HeadTimestamp;

        void EWrapper.headTimestamp(int reqId, string headTimestamp)
        {
            var tmp = HeadTimestamp;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new HeadTimestampMessage(reqId, headTimestamp)), null);
                else
                    tmp(new HeadTimestampMessage(reqId, headTimestamp));
            }
        }

        public event Action<HistogramDataMessage> HistogramData;

        void EWrapper.histogramData(int reqId, HistogramEntry[] data)
        {
            var tmp = HistogramData;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new HistogramDataMessage(reqId, data)), null);
                else
                    tmp(new HistogramDataMessage(reqId, data));
            }
        }

        public event Action<HistoricalDataMessage> HistoricalDataUpdate;

        void EWrapper.historicalDataUpdate(int reqId, Bar bar)
        {
            var tmp = HistoricalDataUpdate;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new HistoricalDataMessage(reqId, bar)), null);
                else
                    tmp(new HistoricalDataMessage(reqId, bar));
            }
        }

        public event Action<int, int, string> RerouteMktDataReq;

        void EWrapper.rerouteMktDataReq(int reqId, int conId, string exchange)
        {
            var tmp = RerouteMktDataReq;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId, conId, exchange), null);
                else
                    tmp(reqId, conId, exchange);
            }
        }

        public event Action<int, int, string> RerouteMktDepthReq;

        void EWrapper.rerouteMktDepthReq(int reqId, int conId, string exchange)
        {
            var tmp = RerouteMktDepthReq;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId, conId, exchange), null);
                else
                    tmp(reqId, conId, exchange);
            }
        }

        public event Action<MarketRuleMessage> MarketRule;

        void EWrapper.marketRule(int marketRuleId, PriceIncrement[] priceIncrements)
        {
            var tmp = MarketRule;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new MarketRuleMessage(marketRuleId, priceIncrements)), null);
                else
                    tmp(new MarketRuleMessage(marketRuleId, priceIncrements));
            }
        }

        public event Action<PnLMessage> pnl;

        void EWrapper.pnl(int reqId, double dailyPnL, double unrealizedPnL, double realizedPnL)
        {
            var tmp = pnl;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new PnLMessage(reqId, dailyPnL, unrealizedPnL, realizedPnL)), null);
                else
                    tmp(new PnLMessage(reqId, dailyPnL, unrealizedPnL, realizedPnL));
            }
        }

        public event Action<PnLSingleMessage> pnlSingle;

        void EWrapper.pnlSingle(int reqId, decimal pos, double dailyPnL, double unrealizedPnL, double realizedPnL, double value)
        {
            var tmp = pnlSingle;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new PnLSingleMessage(reqId, pos, dailyPnL, unrealizedPnL, realizedPnL, value)), null);
                else
                    tmp(new PnLSingleMessage(reqId, pos, dailyPnL, unrealizedPnL, realizedPnL, value));
            }
        }

        public event Action<HistoricalTickMessage> historicalTick;

        void EWrapper.historicalTicks(int reqId, HistoricalTick[] ticks, bool done)
        {
            var tmp = historicalTick;

            if (tmp != null)
                ticks.ToList().ForEach(tick => sc.Post(t => tmp(new HistoricalTickMessage(reqId, tick.Time, tick.Price, tick.Size)), null));
        }

        public event Action<HistoricalTickBidAskMessage> historicalTickBidAsk;

        void EWrapper.historicalTicksBidAsk(int reqId, HistoricalTickBidAsk[] ticks, bool done)
        {
            var tmp = historicalTickBidAsk;

            if (tmp != null)
                ticks.ToList().ForEach(tick => sc.Post(t =>
                                                           tmp(new HistoricalTickBidAskMessage(reqId, tick.Time, tick.TickAttribBidAsk, tick.PriceBid, tick.PriceAsk, tick.SizeBid, tick.SizeAsk)), null));
        }

        public event Action<HistoricalTickLastMessage> historicalTickLast;

        void EWrapper.historicalTicksLast(int reqId, HistoricalTickLast[] ticks, bool done)
        {
            var tmp = historicalTickLast;

            if (tmp != null)
                ticks.ToList().ForEach(tick => sc.Post(t =>
                                                           tmp(new HistoricalTickLastMessage(reqId, tick.Time, tick.TickAttribLast, tick.Price, tick.Size, tick.Exchange, tick.SpecialConditions)), null));
        }

        public event Action<TickByTickAllLastMessage> tickByTickAllLast;

        void EWrapper.tickByTickAllLast(int reqId, int tickType, long time, double price, decimal size, TickAttribLast tickAttribLast, string exchange, string specialConditions)
        {
            var tmp = tickByTickAllLast;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new TickByTickAllLastMessage(reqId, tickType, time, price, size, tickAttribLast, exchange, specialConditions)), null);
                else
                    tmp(new TickByTickAllLastMessage(reqId, tickType, time, price, size, tickAttribLast, exchange, specialConditions));
            }
        }

        public event Action<TickByTickBidAskMessage> tickByTickBidAsk;

        void EWrapper.tickByTickBidAsk(int reqId, long time, double bidPrice, double askPrice, decimal bidSize, decimal askSize, TickAttribBidAsk tickAttribBidAsk)
        {
            var tmp = tickByTickBidAsk;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new TickByTickBidAskMessage(reqId, time, bidPrice, askPrice, bidSize, askSize, tickAttribBidAsk)), null);
                else
                    tmp(new TickByTickBidAskMessage(reqId, time, bidPrice, askPrice, bidSize, askSize, tickAttribBidAsk));
            }
        }

        public event Action<TickByTickMidPointMessage> tickByTickMidPoint;

        void EWrapper.tickByTickMidPoint(int reqId, long time, double midPoint)
        {
            var tmp = tickByTickMidPoint;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new TickByTickMidPointMessage(reqId, time, midPoint)), null);
                else
                    tmp(new TickByTickMidPointMessage(reqId, time, midPoint));
            }
        }

        public event Action<OrderBoundMessage> OrderBound;

        void EWrapper.orderBound(long orderId, int apiClientId, int apiOrderId)
        {
            var tmp = OrderBound;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new OrderBoundMessage(orderId, apiClientId, apiOrderId)), null);
                else
                    tmp(new OrderBoundMessage(orderId, apiClientId, apiOrderId));
            }
        }

        public event Action<CompletedOrderMessage> CompletedOrder;

        void EWrapper.completedOrder(Contract contract, Order order, OrderState orderState)
        {
            var tmp = CompletedOrder;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new CompletedOrderMessage(contract, order, orderState)), null);
                else
                    tmp(new CompletedOrderMessage(contract, order, orderState));
            }
        }

        public event Action CompletedOrdersEnd;

        void EWrapper.completedOrdersEnd()
        {
            var tmp = CompletedOrdersEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(), null);
                else
                    tmp();
            }
        }

        public event Action<int, string> ReplaceFAEnd;

        void EWrapper.replaceFAEnd(int reqId, string text)
        {
            var tmp = ReplaceFAEnd;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId, text), null);
                else
                    tmp(reqId, text);
            }
        }

        public event Action<int, string> WshMetaData;

        public void wshMetaData(int reqId, string dataJson)
        {
            var tmp = WshMetaData;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId, dataJson), null);
                else
                    tmp(reqId, dataJson);
            }
        }

        public event Action<int, string> WshEventData;

        public void wshEventData(int reqId, string dataJson)
        {
            var tmp = WshEventData;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(reqId, dataJson), null);
                else
                    tmp(reqId, dataJson);
            }
        }

        public event Action<HistoricalScheduleMessage> HistoricalSchedule;

        public void historicalSchedule(int reqId, string startDateTime, string endDateTime, string timeZone, HistoricalSession[] sessions)
        {
            var tmp = HistoricalSchedule;

            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(new HistoricalScheduleMessage(reqId, startDateTime, endDateTime, timeZone, sessions)), null);
                else
                    tmp(new HistoricalScheduleMessage(reqId, startDateTime, endDateTime, timeZone, sessions));
            }
        }

        public event Action<string> UserInfo;

        void EWrapper.userInfo(int reqId, string whiteBrandingId)
        {
            var tmp = UserInfo;
            if (tmp != null)
            {
                if (sc != null)
                    sc.Post(t => tmp(whiteBrandingId), null);
                else
                    tmp(whiteBrandingId);
            }
        }
    }
}
