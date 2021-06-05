using System;
using IBApi;

namespace IBSamples
{
    public class EWrapperImpl : DefaultEWrapper 
    {
        EClientSocket clientSocket;
        private int nextOrderId;
        
        public EWrapperImpl()
        {
            clientSocket = new EClientSocket(this, new EReaderMonitorSignal());
        }

        public EClientSocket ClientSocket
        {
            get { return clientSocket; }
            set { clientSocket = value; }
        }

        public int NextOrderId
        {
            get { return nextOrderId; }
            set { nextOrderId = value; }
        }

        public override void error(Exception e)
        {
            Console.WriteLine("Error: "+e);
            throw e;//remove after testing!
        }
        
        public override void error(string str)
        {
            Console.WriteLine("Error: "+str+"\n");
        }
        
        public override void error(int id, int errorCode, string errorMsg)
        {
            Console.WriteLine("Error. Id: " + id + ", Code: " + errorCode + ", Msg: " + errorMsg + "\n");
        }
        
        public override void connectionClosed()
        {
            Console.WriteLine("Connection closed.\n");
        }
        
        public override void currentTime(long time) 
        {
            Console.WriteLine("Current Time: "+time+"\n");
        }

        public override void tickPrice(int tickerId, int field, double price, TickAttrib attribs)
        {
            Console.WriteLine("Tick Price. Ticker Id:"+tickerId+", Field: "+field+", Price: "+price+", CanAutoExecute: "+attribs.CanAutoExecute+"\n");
        }
        
        public override void tickSize(int tickerId, int field, long size)
        {
            Console.WriteLine("Tick Size. Ticker Id:" + tickerId + ", Field: " + field + ", Size: " + size+"\n");
        }
        
        public override void tickString(int tickerId, int tickType, string value)
        {
            Console.WriteLine("Tick string. Ticker Id:" + tickerId + ", Type: " + tickType + ", Value: " + value+"\n");
        }

        public override void tickGeneric(int tickerId, int field, double value)
        {
            Console.WriteLine("Tick Generic. Ticker Id:" + tickerId + ", Field: " + field + ", Value: " + value+"\n");
        }

        public override void tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture, int holdDays, string futureExpiry, double dividendImpact, double dividendsToExpiry)
        {
            Console.WriteLine("TickEFP. "+tickerId+", Type: "+tickType+", BasisPoints: "+basisPoints+", FormattedBasisPoints: "+formattedBasisPoints+", ImpliedFuture: "+impliedFuture+", HoldDays: "+holdDays+", FutureExpiry: "+futureExpiry+", DividendImpact: "+dividendImpact+", DividendsToExpiry: "+dividendsToExpiry+"\n");
        }

        public override void tickSnapshotEnd(int tickerId)
        {
            Console.WriteLine("TickSnapshotEnd: "+tickerId+"\n");
        }

        public override void nextValidId(int orderId) 
        {
            Console.WriteLine("Next Valid Id: "+orderId+"\n");
            NextOrderId = orderId;
        }

        public override void deltaNeutralValidation(int reqId, DeltaNeutralContract deltaNeutralContract)
        {
            Console.WriteLine("DeltaNeutralValidation. "+reqId+", ConId: "+deltaNeutralContract.ConId+", Delta: "+deltaNeutralContract.Delta+", Price: "+deltaNeutralContract.Price+"\n");
        }

        public override void managedAccounts(string accountsList) 
        {
            Console.WriteLine("Account list: "+accountsList+"\n");
        }

        public override void tickOptionComputation(int tickerId, int field, int tickAttrib, double impliedVolatility, double delta, double optPrice, double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            Console.WriteLine("TickOptionComputation. TickerId: "+tickerId+", field: "+field+", ImpliedVolatility: "+impliedVolatility+", Delta: "+delta
                +", OptionPrice: "+optPrice+", pvDividend: "+pvDividend+", Gamma: "+gamma+", Vega: "+vega+", Theta: "+theta+", UnderlyingPrice: "+undPrice+"\n");
        }

        public override void accountSummary(int reqId, string account, string tag, string value, string currency)
        {
            Console.WriteLine("Acct Summary. ReqId: " + reqId + ", Acct: " + account + ", Tag: " + tag + ", Value: " + value + ", Currency: " + currency+"\n");
        }

        public override void accountSummaryEnd(int reqId)
        {
            Console.WriteLine("AccountSummaryEnd. Req Id: "+reqId+"\n");
        }

        public override void updateAccountValue(string key, string value, string currency, string accountName)
        {
            Console.WriteLine("UpdateAccountValue. Key: " + key + ", Value: " + value + ", Currency: " + currency + ", AccountName: " + accountName+"\n");
        }

        public override void updatePortfolio(Contract contract, double position, double marketPrice, double marketValue, double averageCost, double unrealizedPNL, double realizedPNL, string accountName)
        {
            Console.WriteLine("UpdatePortfolio. "+contract.Symbol+", "+contract.SecType+" @ "+contract.Exchange
                +": Position: "+position+", MarketPrice: "+marketPrice+", MarketValue: "+marketValue+", AverageCost: "+averageCost
                +", UnrealisedPNL: "+unrealizedPNL+", RealisedPNL: "+realizedPNL+", AccountName: "+accountName+"\n");
        }

        public override void updateAccountTime(string timestamp)
        {
            Console.WriteLine("UpdateAccountTime. Time: " + timestamp+"\n");
        }

        public override void accountDownloadEnd(string account)
        {
            Console.WriteLine("Account download finished: "+account+"\n");
        }

        public virtual void orderStatus(int orderId, string status, double filled, double remaining, double avgFillPrice, int permId, int parentId, double lastFillPrice, int clientId, string whyHeld, double mktCapPrice)
        {
            Console.WriteLine("OrderStatus. Id: "+orderId+", Status: "+status+", Filled"+filled+", Remaining: "+remaining
                +", AvgFillPrice: "+avgFillPrice+", PermId: "+permId+", ParentId: "+parentId+", LastFillPrice: "+lastFillPrice+", ClientId: "+clientId+", WhyHeld: "+whyHeld+"\n");
        }

        public override void openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            Console.WriteLine("OpenOrder. ID: "+orderId+", "+contract.Symbol+", "+contract.SecType+" @ "+contract.Exchange+": "+order.Action+", "+order.OrderType+" "+order.TotalQuantity+", "+orderState.Status+"\n");
        }

        public override void openOrderEnd()
        {
            Console.WriteLine("OpenOrderEnd");
        }

        public override void contractDetails(int reqId, ContractDetails contractDetails)
        {
            Console.WriteLine("ContractDetails. ReqId: "+reqId+" - "+contractDetails.Contract.Symbol+", "+contractDetails.Contract.SecType+", ConId: "+contractDetails.Contract.ConId+" @ "+contractDetails.Contract.Exchange+"\n");
        }

        public override void contractDetailsEnd(int reqId)
        {
            Console.WriteLine("ContractDetailsEnd. "+reqId+"\n");
        }

        public override void execDetails(int reqId, Contract contract, Execution execution)
        {
            Console.WriteLine("ExecDetails. "+reqId+" - "+contract.Symbol+", "+contract.SecType+", "+contract.Currency+" - "+execution.ExecId+", "+execution.OrderId+", "+execution.Shares+"\n");
        }

        public override void execDetailsEnd(int reqId)
        {
            Console.WriteLine("ExecDetailsEnd. "+reqId+"\n");
        }

        public override void commissionReport(CommissionReport commissionReport)
        {
            Console.WriteLine("CommissionReport. "+commissionReport.ExecId+" - "+commissionReport.Commission+" "+commissionReport.Currency+" RPNL "+commissionReport.RealizedPNL+"\n");
        }

        public override void fundamentalData(int reqId, string data)
        {
            Console.WriteLine("FundamentalData. " + reqId + "" + data+"\n");
        }

        public virtual void historicalData(int reqId, Bar bar)
        {
            Console.WriteLine("HistoricalData. "+reqId+" - Date: "+bar.Time+", Open: "+bar.Open+", High: "+bar.High+", Low: "+bar.Low+", Close: "+bar.Close+", Volume: "+bar.Volume+", Count: "+bar.Count+", WAP: "+bar.WAP+"\n");
        }

        public void historicalData2(int reqId, string date, double open, double high, double low, double close, int volume, int count,
            double WAP, bool hasGaps, int recordNumber, int recordTotal)
        {
            throw new NotImplementedException();
        }

        public void historicalDataEnd(int reqId, string start, string end)
        {
            throw new NotImplementedException();
        }

        public override void marketDataType(int reqId, int marketDataType)
        {
            //WARN: when we request this, we never send a requestId
            //This is also not returning anything when invoked
            Console.WriteLine("MarketDataType. "+reqId+", Type: "+marketDataType+"\n");
        }

        public override void updateMktDepth(int tickerId, int position, int operation, int side, double price, long size)
        {
            Console.WriteLine("UpdateMarketDepth. " + tickerId + " - Position: " + position + ", Operation: " + operation + ", Side: " + side + ", Price: " + price + ", Size" + size+"\n");
        }

        //WARN: Could not test!
        public override void updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, long size, bool isSmartDepth)
        {
            Console.WriteLine("UpdateMarketDepthL2. " + tickerId + " - Position: " + position + ", Operation: " + operation + ", Side: " + side + ", Price: " + price + ", Size" + size+"\n");
        }

        //WARN: Could not test!
        public override void updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            Console.WriteLine("News Bulletins. "+msgId+" - Type: "+msgType+", Message: "+message+", Exchange of Origin: "+origExchange+"\n");
        }

        public override void position(string account, Contract contract, double pos, double avgCost)
        {
            Console.WriteLine("Position. "+account+" - Symbol: "+contract.Symbol+", SecType: "+contract.SecType+", Currency: "+contract.Currency+", Position: "+pos+"\n");
        }

        public override void positionEnd()
        {
            Console.WriteLine("PositionEnd \n");
        }

        public override void realtimeBar(int reqId, long time, double open, double high, double low, double close, long volume, double WAP, int count)
        {
            Console.WriteLine("RealTimeBars. " + reqId + " - Time: " + time + ", Open: " + open + ", High: " + high + ", Low: " + low + ", Close: " + close + ", Volume: " + volume + ", Count: " + count + ", WAP: " + WAP+"\n");
        }

        public override void scannerParameters(string xml)
        {
            Console.WriteLine("ScannerParameters. "+xml+"\n");
        }

        public override void scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
            Console.WriteLine("ScannerData. "+reqId+" - Rank: "+rank+", Symbol: "+contractDetails.Contract.Symbol+", SecType: "+contractDetails.Contract.SecType+", Currency: "+contractDetails.Contract.Currency
                +", Distance: "+distance+", Benchmark: "+benchmark+", Projection: "+projection+", Legs String: "+legsStr+"\n");
        }

        public override void scannerDataEnd(int reqId)
        {
            Console.WriteLine("ScannerDataEnd. "+reqId+"\n");
        }

        public override void receiveFA(int faDataType, string faXmlData)
        {
            Console.WriteLine("Receing FA: "+faDataType+" - "+faXmlData+"\n");
        }
    }
}
