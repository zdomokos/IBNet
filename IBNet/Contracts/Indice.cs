using System;
using IBApi;
using IBNet.Enums;

namespace IBNet.Contracts;

/// <summary>
/// Create a contract with the default parameters for an indice
/// </summary>
/// <seealso cref="Contract"/>
[Serializable]
public class Index : Contract
{
    /// <summary>
    /// Create an Indice Contract for a specific exchange
    /// </summary>
    /// <param name="symbol">Symbol for the indice contract. See <see cref="Contract.Symbol"/>.</param>
    /// <param name="exchange">Exchange for the indice contract. See <see cref="Contract.Exchange"/></param>
    public Index(string symbol, string exchange)
    {
            Symbol = symbol;
            Exchange = exchange;
            SecType = SecurityType.Index.Value;
            Currency = "USD";
        }
}