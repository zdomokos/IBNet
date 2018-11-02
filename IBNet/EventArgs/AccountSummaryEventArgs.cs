using System;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable()]
    public class AccountSummaryEventArgs : EventArgs
    {
        /// <summary>
        /// Full Constructor
        /// </summary>
        public AccountSummaryEventArgs(int reqId, string account, string tag, string value, string currency)
        {
            RequestId = reqId;
            Account = account;
            Tag = tag;
            Value = value;
            Currency = currency;
        }

        /// <summary>
        /// Uninitialized Constructor for Serialization
        /// </summary>
        public AccountSummaryEventArgs()
        {
        }

        /// <summary>
        /// Request Id
        /// </summary>
        public int RequestId { get; set; }

        public string Value { get; set; }

        public string Tag { get; set; }

        public string Account { get; set; }

        public string Currency { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable()]
    public class AccountSummaryEndEventArgs : EventArgs
    {
        /// <summary>
        /// Full Constructor
        /// </summary>
        public AccountSummaryEndEventArgs(int reqId)
        {
            RequestId = reqId;
        }

        /// <summary>
        /// Uninitialized Constructor for Serialization
        /// </summary>
        public AccountSummaryEndEventArgs()
        {
        }

        /// <summary>
        /// Request Id
        /// </summary>
        public int RequestId { get; set; }
    }
}