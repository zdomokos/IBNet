using System;
using IBApi;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Execution Data End Event Arguments
    /// </summary>
    [Serializable()]
    public class DeltaNuetralValidationEventArgs : EventArgs
    {
        private int requestId;
        private DeltaNeutralContract underComp;

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="requestId">Request Id</param>
        /// <param name="underComp">Underlying Component</param>
        public DeltaNuetralValidationEventArgs(int requestId, DeltaNeutralContract underComp)
        {
            this.requestId = requestId;
            this.underComp = underComp;
        }

        /// <summary>
        /// Uninitialized Constructor for Serialization
        /// </summary>
        public DeltaNuetralValidationEventArgs()
        {
            
        }

        /// <summary>
        /// Request Id
        /// </summary>
        public int RequestId
        {
            get => requestId;
	        set => requestId = value;
        }

        /// <summary>
        /// Underlying Component
        /// </summary>
        public DeltaNeutralContract UnderComp
        {
            get => underComp;
	        set => underComp = value;
        }
    }
}