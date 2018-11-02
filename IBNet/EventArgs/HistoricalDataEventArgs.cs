using System;
using IBApi;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Historical Data Event Arguments
    /// </summary>
    [Serializable]
    public class HistoricalDataEventArgs : EventArgs
    {
        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="requestId">The ticker Id of the request to which this bar is responding.</param>
        public HistoricalDataEventArgs(int requestId, Bar bar)
        {
            RequestId    = requestId;
            Bar = bar;
        }

        /// <summary>
        /// Uninitialized Constructor for Serialization
        /// </summary>
        public HistoricalDataEventArgs()
        {}

        /// <summary>
        /// The ticker Id of the request to which this bar is responding.
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// The bar data.
        /// </summary>
        public Bar Bar { get; private set; }
    }

    /// <summary>
    /// Event arguments class for the <see cref="InteractiveBrokersClient.HistoricalDataUpdate"/> event
    /// </summary>
    [Serializable]
    public class HistoricalDataUpdateEventArgs : EventArgs
    {
        public HistoricalDataUpdateEventArgs() {}

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalDataUpdateEventArgs"/> class
        /// </summary>
        public HistoricalDataUpdateEventArgs(int requestId, Bar bar)
        {
            RequestId = requestId;
            Bar = bar;
        }

        /// <summary>
        /// The request's identifier.
        /// </summary>
        public int RequestId { get; private set; }

        /// <summary>
        /// The bar data.
        /// </summary>
        public Bar Bar { get; private set; }
    }

    /// <summary>
    /// Historical Data Event Arguments
    /// </summary>
    [Serializable]
    public class HistoricalDataEndEventArgs : EventArgs
    {
        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="requestId">The ticker Id of the request to which this bar is responding.</param>
        /// <param name="start">The date-time stamp of the start of the bar.</param>
        /// <param name="end">The date-time stamp of the end of the bar.</param>
        public HistoricalDataEndEventArgs(int requestId, string start, string end)
        {
            RequestId = requestId;
            Start = start;
            End = end;
        }

        /// <summary>
        /// Uninitialized Constructor for Serialization
        /// </summary>
        public HistoricalDataEndEventArgs()
        {}

        /// <summary>
        /// 
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string End { get; set; }

    }
}
