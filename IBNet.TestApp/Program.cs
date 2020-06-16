using System;
using System.Threading;
using IBApi;
using IBNet.Contracts;
using IBNet.Enums;
using IBNet.Messages;

namespace IBNet.TestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ibClientTest = new IBNetTest();
            ibClientTest.Run();
        }
    }

    public class IBNetTest
    {
        private IBClient client;
        int NextOrderId;
        
        public void Run()
        {
            Contract TF;
            Contract TickNasdaq;
            Contract VolNasdaq;
            Contract AdNasdaq;
            Contract TickNyse;
            Contract VolNyse;
            Contract AdNyse;
            Contract YmEcbot;
            Contract ES;
            Contract SPY;
            Contract ZN;
            Contract ZB;
            Contract ZT;
            Contract ZF;
            client = new IBClient(); // {ThrowExceptions = true};

            client.TickPrice        += client_TickPrice;
            client.TickSize         += client_TickSize;
            client.Error            += ClientOnError;
            client.NextValidId      += ClientOnNextValidId;
            client.UpdateMktDepth   += client_UpdateMktDepth;
            client.RealtimeBar      += client_RealTimeBar;
            client.OrderStatus      += client_OrderStatus;
            client.ExecDetails      += client_ExecDetails;
            //client.CommissionReport += client_CommissionReport;

            Console.WriteLine("Connecting to IB.");
            //client.Connect("127.0.0.1", 7496, 10);
            client.Connect("192.168.50.12", 7496, 10);

            //TF = new Future("TF", "NYBOT", "USD", "200909");
            //YmEcbot = new Future("YM", "ECBOT", "USD", "200909");
            //ES = new Future("ES", "GLOBEX", "USD", "200909");
            //SPY = new Future("SPY", "GLOBEX", "USD", "200909");
            //ZN = new Future("ZN", "ECBOT", "USD", "200909");
            //ZB = new Future("ZB", "ECBOT", "USD", "200909");
            //ZT = new Future("ZT", "ECBOT", "USD", "200909");
            //ZF = new Future("ZF", "ECBOT", "USD", "200909");

            //TickNasdaq = new Index("TICK-NASD", "NASDAQ");
            //VolNasdaq = new Index("VOL-NASD", "NASDAQ");
            //AdNasdaq = new Index("AD-NASD", "NASDAQ");
            //TickNyse = new Index("TICK-NYSE", "NYSE");
            //VolNyse = new Index("VOL-NYSE", "NYSE");
            //AdNyse = new Index("AD-NYSE", "NYSE");

            //New Contract Creation Features
            //var Google = new Equity("GOOG");

            //Forex Test
            var EUR = new Forex("EUR", "USD");

            //Order BuyContract = KrsOrderFactory.CreateOrder(ActionSide.Buy, OrderType.Limit, 560, 0, 1, false, 0);
            //BuyContract.OutsideRth = false;
            //BuyContract.LimitPrice = 560;
            //BuyContract.OrderType = OrderType.Limit;
            //BuyContract.TotalQuantity = 1;
            //client.PlaceOrder(503, TF, BuyContract);

            client.RequestExecutions(NextOrderId++, new ExecutionFilter());
            client.RequestAllOpenOrders();

            client.RequestMarketData(NextOrderId++, EUR, null, false, false, null);
            client.RequestMarketDepth(NextOrderId++, EUR, 5, false, null);
            client.RequestRealTimeBars(NextOrderId++, EUR, 5, RealTimeBarType.Midpoint, false, null);
            //client.RequestMarketData(NextOrderId++, EUR, null, false, false);


            while (true)
            {
                Thread.Sleep(100);
            }
        }

        static void client_ExecDetails(ExecutionMessage e)
        {
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                              e.Contract.Symbol, e.Execution.AcctNumber, e.Execution.ClientId, e.Execution.Exchange, e.Execution.ExecId,
                              e.Execution.Liquidation, e.Execution.OrderId, e.Execution.PermId, e.Execution.Price, e.Execution.Shares, e.Execution.Side, e.Execution.Time);
        }

        static void client_CommissionReport(CommissionMessage e)
        {
            Console.WriteLine("Received commision report: " + e.CommissionReport);
        }

        static void client_RealTimeBar(RealTimeBarMessage e)
        {
            Console.WriteLine("Received Real Time Bar: " + e.Close);
        }

        static void client_OrderStatus(OrderStatusMessage e)
        {
            Console.WriteLine("Order Placed.");
        }

        static void client_UpdateMktDepth(DeepBookMessage e)
        {
            // Console.WriteLine("Tick ID: " + e. + " Tick Side: " + EnumDescConverter.ToIBTxt(e.Side) +
            //                   " Tick Size: " + e.Size + " Tick Price: " + e.Price + " Tick Position: " + e.Position +
            //                   " Operation: " + EnumDescConverter.ToIBTxt(e.Operation));
        }

        private void ClientOnNextValidId(ConnectionStatusMessage obj)
        {
            Console.WriteLine($"Next Valid Id: {client.NextOrderId}");
            NextOrderId = client.NextOrderId;
        }

        static void client_TickSize(TickSizeMessage e)
        {
            Console.WriteLine("Tick Size: " + e.Size + " Tick Type: " + e.Field);
        }


        private static void ClientOnError(int arg1, int arg2, string arg3, Exception arg4)
        {
            Console.WriteLine($"Error: ticker {arg1} {ErrorMessageCode.FromValue(arg2).Name} {arg3} {arg4?.Message}");
        }

        static void client_Error(ErrorMessageCode e)
        {
            //Console.WriteLine("Error: "+ e.ErrorMsg);
        }

        static void client_TickPrice(TickPriceMessage e)
        {
            //Console.WriteLine("Price: " + e.Price + " Tick Type: " + TickType. EnumDescConverter.ToIBTxt((TickType) e.Field));
        }
    }
}

/*
using System;
using System.Threading;
using IBApi;

namespace IBSamples
{
    public class Sample
    {

        public static int Main(string[] args)
        {
            EWrapperImpl testImpl = new EWrapperImpl();
            testImpl.ClientSocket.eConnect("127.0.0.1", 7496, 222);
            while (testImpl.NextOrderId <= 0) { }
            //for (int i = 0; i < 2; i++)
            {
                testConnectDisconnect(testImpl);
            }
            Console.WriteLine("Disconnecting...");
            testImpl.ClientSocket.eDisconnect();
            return 0;
        }

        private static void testConnectDisconnect(EWrapperImpl wrapper)
        {

            //Order order = OrderSamples.LimitOrder();
            //Contract contract = ContractSamples.getOption();

            //wrapper.ClientSocket.reqMktData(1, ContractSamples.getOption(), "", false);
            //wrapper.ClientSocket.reqMktData(3, ContractSamples.getEuropeanStock(), "", false);
            //wrapper.ClientSocket.reqGlobalCancel();
            //wrapper.ClientSocket.reqCurrentTime();
            //wrapper.ClientSocket.reqMktData(1, ContractSamples.getForex(), "", false);
            //wrapper.ClientSocket.calculateImpliedVolatility(2, ContractSamples.getOption(), 10, 345);
            //wrapper.ClientSocket.calculateOptionPrice(3, ContractSamples.getOption(), 4.69, 345);
            //wrapper.ClientSocket.reqAccountSummary(1, "All", AccountSummaryTags.GetAllTags());
            //wrapper.ClientSocket.reqAccountUpdates(true, "DU150462");
            //wrapper.ClientSocket.reqAllOpenOrders();
            //wrapper.ClientSocket.reqAutoOpenOrders(true);
            //wrapper.ClientSocket.reqOpenOrders();
            //wrapper.ClientSocket.placeOrder(wrapper.NextOrderId, ContractSamples.getForex(), order);

            wrapper.ClientSocket.placeOrder(wrapper.NextOrderId, ContractSamples.getComboContract(), OrderSamples.LimitOrderForComboWithLegPrice());

            //wrapper.ClientSocket.reqContractDetails(1, ContractSamples.getForex());
            //wrapper.ClientSocket.reqExecutions(1, new ExecutionFilter());
            //wrapper.ClientSocket.reqMktData(2, ContractSamples.getForex(), "", false);
            //wrapper.ClientSocket.reqFundamentalData(1, ContractSamples.getEuropeanStock(), "snapshot");
            //wrapper.ClientSocket.reqHistoricalData(1, ContractSamples.getEurUsdForex(), "20130722 23:59:59", "1 D", "1 hour", "MIDPOINT", 1, 1);
            //wrapper.ClientSocket.cancelHistoricalData(1);
            //wrapper.ClientSocket.reqFundamentalData(2, ContractSamples.getEuropeanStock(), "snapshot");
            //wrapper.ClientSocket.reqIds(-1);
            //wrapper.ClientSocket.reqManagedAccts();
            //wrapper.ClientSocket.reqMarketDataType(1);
            //wrapper.ClientSocket.reqMarketDepth(1, ContractSamples.getForex(), 5);
            //wrapper.ClientSocket.reqNewsBulletins(true);
            //wrapper.ClientSocket.reqPositions();
            //wrapper.ClientSocket.reqRealTimeBars(1, ContractSamples.getForex(), -1, "MIDPOINT", true);
            //wrapper.ClientSocket.reqScannerParameters();
            //wrapper.ClientSocket.exerciseOptions(1, ContractSamples.getOption(), 1, 20, null, 1);
            //wrapper.ClientSocket.reqScannerSubscription(1, GetScannerSubscription());
            //wrapper.ClientSocket.requestFA(Constants.FaProfiles);            

            //NOT WORKING (ALSO CHECKED WITH JAVA 969)
            wrapper.ClientSocket.setServerLogLevel(1);
            Thread.Sleep(500000);
        }

        private static ScannerSubscription GetScannerSubscription()
        {
            ScannerSubscription scanSub = new ScannerSubscription();
            scanSub.Instrument = "STOCK.EU";
            scanSub.LocationCode = "STK.EU.IBIS";
            scanSub.ScanCode = "HOT_BY_VOLUME";
            return scanSub;
        }
    }
}
*/