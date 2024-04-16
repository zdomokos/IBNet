using IBApi;
using IBNet.Enums;

namespace IBNet.Contracts;

/// <summary>
/// Future Class - uses default constructors for creating an future contract.
/// </summary>
/// <seealso cref="Contract"/>
[Serializable]
public class Future : Contract
{
    /// <summary>
    /// Create n Future Contract for a specific exchange
    /// </summary>
    /// <param name="symbol">Symbol for the future contract. See <see cref="Contract.Symbol"/>.</param>
    /// <param name="exchange">Exchange for the future contract. See <see cref="Contract.Exchange"/>.</param>
    /// <param name="expiry">Expiry for a future contract. See <see cref="Contract.Expiry"/>.</param>
    public Future(string symbol, string exchange, string expiry)
    {
        Symbol                       = symbol;
        Exchange                     = exchange;
        SecType                      = SecurityType.Future.Value;
        Currency                     = "USD";
        LastTradeDateOrContractMonth = expiry;
    }

    /// <summary>
    /// Create a Future Contract for a specific exchange
    /// </summary>
    /// <param name="symbol">Symbol for the future contract. See <see cref="Contract.Symbol"/>.</param>
    /// <param name="exchange">Exchange for the future contract. See <see cref="Contract.Exchange"/>.</param>
    /// <param name="expiry">Expiry for a future contract. See <see cref="Contract.Expiry"/>.</param>
    /// <param name="currency">Currency for a future contract. See <see cref="Contract.Currency"/>.</param>
    public Future(string symbol, string exchange, string expiry, string currency)
    {
        Symbol                       = symbol;
        Exchange                     = exchange;
        SecType                      = SecurityType.Future.Value;
        Currency                     = currency;
        LastTradeDateOrContractMonth = expiry;
    }

    /// <summary>
    /// Create a Future Contract for a specific exchange
    /// </summary>
    /// <param name="symbol">Symbol for the future contract. See <see cref="Contract.Symbol"/>.</param>
    /// <param name="exchange">Exchange for the future contract. See <see cref="Contract.Exchange"/>.</param>
    /// <param name="expiry">Expiry for a future contract. See <see cref="Contract.Expiry"/>.</param>
    /// <param name="currency">Currency for a future contract. See <see cref="Contract.Currency"/>.</param>
    /// <param name="multiplier">Multiplier for a future contract. See <see cref="Contract.Multiplier"/>.</param>
    public Future(string symbol, string exchange, string expiry, string currency, double multiplier)
    {
        Symbol                       = symbol;
        Exchange                     = exchange;
        SecType                      = SecurityType.Future.Value;
        Currency                     = currency;
        LastTradeDateOrContractMonth = expiry;
        Multiplier                   = multiplier.ToString();
    }
}