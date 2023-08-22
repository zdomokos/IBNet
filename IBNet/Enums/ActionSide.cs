using System;
using Headspring;

namespace IBNet.Enums
{
    /// <summary>
    /// Order  Action Side. Specifies whether securities should be bought or sold.
    /// </summary>
    [Serializable]
    public class ActionSide : Enumeration<ActionSide, string>
    {
        /// <summary>
        /// Security is to be bought.
        /// </summary>
        public static ActionSide Buy = new ActionSide("BUY", nameof(Buy));
        /// <summary>
        /// Security is to be sold.
        /// </summary>
        public static ActionSide Sell = new ActionSide("SELL", nameof(Sell));
        /// <summary>
        /// Undefined
        /// </summary>
        public static ActionSide Undefined = new ActionSide("", nameof(Undefined));
        /// <summary>
        /// Sell Short as part of a combo leg
        /// </summary>
        public static ActionSide SShort = new ActionSide("SSHORT", nameof(SShort));
        /// <summary>
        /// Short Sale Exempt action.
        /// SSHORTX allows some orders to be marked as exempt from the new SEC Rule 201
        /// </summary>
        public static ActionSide SShortX = new ActionSide("SSHORTX", nameof(SShortX));
        
        public ActionSide(string value, string name) : base(value, name) {}
    }
}
