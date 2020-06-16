using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IBApi;
using IBNet.Messages;

namespace IBNet
{
    public partial class IBClient
    {
        public Task<Contract> ResolveContractAsync(int conId, string refExch)
        {
            var reqId = new Random(DateTime.Now.Millisecond).Next();
            var resolveResult = new TaskCompletionSource<Contract>();
            var resolveContract_Error = new Action<int, int, string, Exception>((id, code, msg, ex) =>
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

            var tmpError = Error;
            var tmpContractDetails = ContractDetails;
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
                                                   {ConId = conId, Exchange = refExch});

            return resolveResult.Task;
        }

        public Task<Contract[]> ResolveContractAsync(string secType, string symbol, string currency, string exchange)
        {
            var reqId = new Random(DateTime.Now.Millisecond).Next();
            var res = new TaskCompletionSource<Contract[]>();
            var contractList = new List<Contract>();
            var resolveContract_Error = new Action<int, int, string, Exception>((id, code, msg, ex) =>
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

            var tmpError = Error;
            var tmpContractDetails = ContractDetails;
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
                                                   {SecType = secType, Symbol = symbol, Currency = currency, Exchange = exchange});

            return res.Task;
        }
    }
}