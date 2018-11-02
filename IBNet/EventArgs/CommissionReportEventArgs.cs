using System;
using IBApi;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Contract Details Event Arguments
    /// </summary>
    [Serializable()]
    public class CommissionReportEventArgs : EventArgs
    {
        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="accountName">Account Name</param>
        public CommissionReportEventArgs(CommissionReport report)
        {
            Report = report;
        }

        /// <summary>
        /// Uninitialized Constructor for Serialization
        /// </summary>
        public CommissionReportEventArgs()
        {
        }

        /// <summary>
        /// Request Id
        /// </summary>
        public CommissionReport Report { get; set; }
    }
}