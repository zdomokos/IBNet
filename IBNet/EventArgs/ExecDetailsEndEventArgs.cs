using System;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Execution Data End Event Arguments
    /// </summary>
    [Serializable()]
    public class ExecDetailsEndEventArgs : EventArgs
    {
        private int requestId;

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="requestId">Request Id</param>
        public ExecDetailsEndEventArgs(int requestId)
        {
            this.requestId = requestId;
        }

        /// <summary>
        /// Uninitialized Constructor for Serialization
        /// </summary>
        public ExecDetailsEndEventArgs()
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
    }
}