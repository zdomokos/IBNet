using System;
using IBApi;
using Krs.Ats.IBNet;
using System.Threading;
using Krs.Ats.IBNet.Contracts;

namespace Krs.Ats.TestApp
{
    class Program
    {
        private static int NextOrderId;
        private static Contract TF;
        private static Contract TickNasdaq;
        private static Contract VolNasdaq;
        private static Contract AdNasdaq;
        private static Contract TickNyse;
        private static Contract VolNyse;
        private static Contract AdNyse;
        private static Contract YmEcbot;
        private static Contract ES;
        private static Contract SPY;
        private static Contract ZN;
        private static Contract ZB;
        private static Contract ZT;
        private static Contract ZF;
        private static IBClient client;
        static void Main(string[] args)
        {
            client = new IBClient {ThrowExceptions = true};

            client.TickPrice += client_TickPrice;
            client.TickSize += client_TickSize;
            client.Error += client_Error;
            client.NextValidId += client_NextValidId;
            client.UpdateMarketDepth += client_UpdateMktDepth;
            client.RealTimeBar += client_RealTimeBar;
            client.OrderStatus += client_OrderStatus;
            client.ExecDetails += client_ExecDetails;
            client.CommissionReport += client_CommissionReport;

            Console.WriteLine("Connecting to IB.");
            client.Connect("127.0.0.1", 7496, 10);

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

            client.RequestExecutions(NextOrderId++, new KrsExecutionFilter());
            client.RequestAllOpenOrders();

            client.RequestMarketData(NextOrderId++, EUR, null, false, false);
            client.RequestMarketDepth(NextOrderId++, EUR, 5);
            client.RequestRealTimeBars(NextOrderId++, EUR, 5, RealTimeBarType.Midpoint, false);
            //client.RequestMarketData(NextOrderId++, EUR, null, false, false);

            while(true)
            {
                Thread.Sleep(100);
            }
        }

        static void client_ExecDetails(object sender, ExecDetailsEventArgs e)
        {
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                e.Contract.Symbol, e.Execution.AcctNumber, e.Execution.ClientId, e.Execution.Exchange, e.Execution.ExecId,
                e.Execution.Liquidation, e.Execution.OrderId, e.Execution.PermId, e.Execution.Price, e.Execution.Shares, e.Execution.Side, e.Execution.Time);
        }

        static void client_CommissionReport(object sender, CommissionReportEventArgs e)
        {
            Console.WriteLine("Received commision report: " + e.Report);
        }

        static void client_RealTimeBar(object sender, RealTimeBarEventArgs e)
        {
            Console.WriteLine("Received Real Time Bar: " + e.Close);
        }

        static void client_OrderStatus(object sender, OrderStatusEventArgs e)
        {
            Console.WriteLine("Order Placed.");
        }

        static void client_UpdateMktDepth(object sender, UpdateMarketDepthEventArgs e)
        {
            Console.WriteLine("Tick ID: " + e.TickerId + " Tick Side: " + EnumDescConverter.GetEnumDescription(e.Side) +
                              " Tick Size: " + e.Size + " Tick Price: " + e.Price + " Tick Position: " + e.Position +
                              " Operation: " + EnumDescConverter.GetEnumDescription(e.Operation));
        }

        static void client_NextValidId(object sender, NextValidIdEventArgs e)
        {
            Console.WriteLine("Next Valid Id: " + e.OrderId);
            NextOrderId = e.OrderId;
        }

        static void client_TickSize(object sender, TickSizeEventArgs e)
        {
            Console.WriteLine("Tick Size: " + e.Size + " Tick Type: " + EnumDescConverter.GetEnumDescription(e.TickType));
        }

        static void client_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("Error: "+ e.ErrorMsg);
        }

        static void client_TickPrice(object sender, TickPriceEventArgs e)
        {
            Console.WriteLine("Price: " + e.Price + " Tick Type: " + EnumDescConverter.GetEnumDescription(e.TickType));
        }
    }
}
