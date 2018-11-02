using System;
using IBApi;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Contract Details Event Arguments
    /// </summary>
    [Serializable()]
    public class ContractDetailsEventArgs : EventArgs
    {
        private ContractDetails contractDetails;
        private int requestId;

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="requestId">Request Id</param>
        /// <param name="contractDetails">This structure contains a full description of the contract being looked up.</param>
        public ContractDetailsEventArgs(int requestId, ContractDetails contractDetails)
        {
            this.requestId = requestId;
            this.contractDetails = contractDetails;
        }

        /// <summary>
        /// Uninitialized Constructor for Serialization
        /// </summary>
        public ContractDetailsEventArgs()
        {
            
        }

        /// <summary>
        /// This structure contains a full description of the contract being looked up.
        /// </summary>
        public ContractDetails ContractDetails
        {
            get => contractDetails;
	        set => contractDetails = value;
        }

        /// <summary>
        /// Request Id
        /// </summary>
        public int RequestId
        {
            get => requestId;
	        set => requestId = value;
        }
    }
}