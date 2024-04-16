using IBApi;
using IBNet.Enums;

namespace IBNet.Contracts;

/// <summary>
/// Forex Currency Contract
/// for use on the IdealPro or Ideal exchanges
/// </summary>
[Serializable]
public class Forex : Contract
{
    /// <summary>
    /// Creates a Forex Contract for use on the IdealPro or Ideal exchanges
    /// </summary>
    /// <param name="currency">Foreign Currency to Exchange</param>
    /// <param name="baseCurrency">Base Currency</param>
    /// <param name="exchange">IDEALPRO or IDEAL</param>
    public Forex(string currency, string baseCurrency, string exchange)
    {
        Symbol   = currency;
        Currency = baseCurrency;
        Exchange = exchange;
        SecType  = SecurityType.Cash.Value;
    }

    /// <summary>
    /// Creates a Forex Contract for use on the IdealPro Exchange
    /// </summary>
    /// <param name="currency">Foreign Currency to Exchange</param>
    /// <param name="baseCurrency">Base Currency</param>
    public Forex(string currency, string baseCurrency)
    {
        Symbol   = currency;
        Currency = baseCurrency;
        Exchange = "IDEALPRO";
        SecType  = SecurityType.Cash.Value;
    }
}