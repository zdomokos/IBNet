using System;

namespace IBNet.Enums
{
    /// <summary>
    /// Order Origin Fields
    /// </summary>
    [Serializable] 
    public enum OrderOrigin
    {
        /// <summary>
        /// Order originated from the customer
        /// </summary>
        Customer = 0,
        /// <summary>
        /// Order originated from teh firm
        /// </summary>
        Firm = 1
    }
}
