using System;
using IBApi;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Bond Contract Details Event Arguments
    /// </summary>
    [Serializable()]
    public class BondContractDetailsEventArgs : EventArgs
    {
        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="requestId">Request Id</param>
        /// <param name="contractDetails">This structure contains a full description of the bond contract being looked up.</param>
        public BondContractDetailsEventArgs(int requestId, ContractDetails contractDetails)
        {
            this.RequestId = requestId;
            this.ContractDetails = contractDetails;
        }

        /// <summary>
        /// Uninitialized Constructor for Serialization
        /// </summary>
        public BondContractDetailsEventArgs()
        {           
        }

        /// <summary>
        /// This structure contains a full description of the bond contract being looked up.
        /// </summary>
        public ContractDetails ContractDetails { get; set; }

        /// <summary>
        /// Request Id
        /// </summary>
        public int RequestId { get; set; }
    }
}