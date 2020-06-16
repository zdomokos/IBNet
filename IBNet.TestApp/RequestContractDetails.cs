using System;
using System.Threading;
using IBApi;

namespace IBSamples
{
    public class RequestContractDetails : EWrapperImpl
    {
        private bool isFinished;

        public bool IsFinished
        {
            get { return isFinished; }
            set { isFinished = value; }
        }
        
        public static int Test(string[] args)
        {
            RequestContractDetails testImpl = new RequestContractDetails();
            testImpl.ClientSocket.eConnect("127.0.0.1", 7496, 0);
            while (testImpl.NextOrderId <= 0) { }

            //We can request the whole option's chain by giving a brief description of the contract
            //i.e. we only specify symbol, currency, secType and exchange (SMART)
            Contract optionContract = ContractSamples.getOptionForQuery();

            testImpl.ClientSocket.reqContractDetails(1, optionContract);

            while (!testImpl.isFinished) { }
            Thread.Sleep(10000);
            Console.WriteLine("Disconnecting...");
            testImpl.ClientSocket.eDisconnect();
            return 0;
        }
        
        public override void contractDetailsEnd(int reqId)
        {
            Console.WriteLine("Finished receiving all matching contracts.");
            isFinished = true;
        }

        public override void contractDetails(int reqId, ContractDetails contractDetails)
        {
            Console.WriteLine("/*******Incoming Contract Details - RequestId "+reqId+"************/");
            Console.WriteLine(contractDetails.Contract.Symbol + " " + contractDetails.Contract.SecType + " @ " + contractDetails.Contract.Exchange);
            Console.WriteLine("Expiry: " + contractDetails.Contract.LastTradeDateOrContractMonth + ", Right: " + contractDetails.Contract.Right);
            Console.WriteLine("Strike: " + contractDetails.Contract.Strike + ", Multiplier: " + contractDetails.Contract.Multiplier);
            Console.WriteLine("/*******     End     *************/\n");
        }

    }
}
