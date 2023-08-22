using System;
using Headspring;

namespace IBNet.Enums
{
    /// <summary>
    /// Security Id Type
    /// </summary>
    [Serializable]
    public class SecurityIdType : Enumeration<SecurityIdType, string>
    {
        /// <summary>
        /// No Security Id Type
        /// </summary>
        public static SecurityIdType None = new SecurityIdType("", nameof(None));

        /// <summary>
        /// Example: Apple: US0378331005
        /// </summary>
        public static SecurityIdType ISIN = new SecurityIdType("ISIN", nameof(ISIN));

        /// <summary>
        /// Example: Apple: 037833100
        /// </summary>
        public static SecurityIdType CUSIP = new SecurityIdType("CUSIP", nameof(CUSIP));

        /// <summary>
        /// Consists of 6-AN + check digit. Example: BAE: 0263494
        /// </summary>
        public static SecurityIdType SEDOL = new SecurityIdType("SEDOL", nameof(SEDOL));

        /// <summary>
        /// Consists of exchange-independent RIC Root and a suffix identifying the exchange. Example: AAPL.O for Apple on NASDAQ.
        /// </summary>
        public static SecurityIdType RIC = new SecurityIdType("RIC", nameof(RIC));

        public SecurityIdType(string value, string name) : base(value, name) { }
    }
}
