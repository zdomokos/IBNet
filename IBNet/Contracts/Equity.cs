using System;
using IBApi;

namespace Krs.Ats.IBNet.Contracts
{
    /// <summary>
    /// Equity Class - uses default constructors for creating an equity contract.
    /// </summary>
    /// <seealso cref="Contract"/>
    [Serializable()]
    public class Equity : Contract
    {
        /// <summary>
        /// Create an Equity Contract for Smart Exchanges
        /// </summary>
        /// <param name="symbol">Symbol of the equity contract. See <see cref="Contract.Symbol"/>.</param>
        public Equity(string symbol)
        {
            Symbol = symbol;
            Exchange = "SMART";
            SecType = EnumDescConverter.GetEnumDescription(SecurityType.Stock);
            Currency = "USD";
        }

        /// <summary>
        /// Create an Equity Contract for a specific exchange
        /// </summary>
        /// <param name="symbol">Symbol for the equity contract. See <see cref="Contract.Symbol"/>.</param>
        /// <param name="exchange">Exchange for the equity contract. See <see cref="Contract.Exchange"/></param>
        public Equity(string symbol, string exchange)
        {
            Symbol = symbol;
            Exchange = exchange;
            SecType = EnumDescConverter.GetEnumDescription(SecurityType.Stock);
            Currency = "USD";
        }
    }
}
