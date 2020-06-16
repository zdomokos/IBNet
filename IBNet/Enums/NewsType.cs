using System;

namespace IBNet.Enums
{
    /// <summary>
    /// News Message Type
    /// </summary>
    [Serializable]
    public enum NewsType
    {
        /// <summary>
        /// Reqular news bulletin
        /// </summary>
        Regular = 1,
        /// <summary>
        /// Exchange no longer available for trading
        /// </summary>
        ExchangeUnavailable = 2,
        /// <summary>
        /// Exchange is available for trading
        /// </summary>
        ExchangeAvailable = 3
    }
}