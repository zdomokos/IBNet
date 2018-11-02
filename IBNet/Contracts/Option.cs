using System;
using System.Text;
using IBApi;

namespace Krs.Ats.IBNet.Contracts
{
    /// <summary>
    /// Option Class - uses default constructors for creating an option contract.
    /// </summary>
    /// <seealso cref="Contract"/>
    [Serializable()]
    public class Option : Contract
    {
        /// <summary>
        /// Creates an Option Contract
        /// </summary>
        /// <param name="equitySymbol">Symbol of the equity. See <see cref="Contract.Symbol"/>.</param>
        /// <param name="optionSymbol">Symbol of the option for the underlying equity. See <see cref="Contract.LocalSymbol"/>.</param>
        /// <param name="expiry">Option Expiration String. See <see cref="Contract.Expiry"/>.</param>
        /// <param name="right">Option Right (Put or Call). See <see cref="Contract.Right"/>.</param>
        /// <param name="strike">Option Strike Price. See <see cref="Contract.Strike"/>.</param>
        public Option(string equitySymbol, string optionSymbol, string expiry, RightType right, double strike)
        {
            ConId       = 0;
            Symbol      = equitySymbol;
            SecType     = EnumDescConverter.GetEnumDescription(SecurityType.Option);
            LastTradeDateOrContractMonth = expiry;
            Strike      = strike;
            Right       = EnumDescConverter.GetEnumDescription(right);
            Multiplier  = "100";
            Exchange    = "SMART";
            Currency    = "USD";
            LocalSymbol = optionSymbol;
            PrimaryExch = "SMART";
            SecIdType   = EnumDescConverter.GetEnumDescription(SecurityIdType.None);
            SecId       = string.Empty;
        }

        /// <summary>
        /// Creates an Option Contract
        /// </summary>
        /// <param name="equitySymbol">Symbol of the equity. See <see cref="Contract.Symbol"/>.</param>
        /// <param name="optionSymbol">Symbol of the option for the underlying equity. See <see cref="Contract.LocalSymbol"/>.</param>
        /// <param name="year">Option Expiration Year. See <see cref="Contract.Expiry"/>.</param>
        /// <param name="month">Option Expiration Month. See <see cref="Contract.Expiry"/>.</param>
        /// <param name="right">Option Right (Put or Call). See <see cref="Contract.Right"/>.</param>
        /// <param name="strike">Option Strike Price. See <see cref="Contract.Strike"/>.</param>
        public Option(string equitySymbol, string optionSymbol, int year, int month, RightType right, double strike)
        {
            ConId       = 0;
            Symbol      = equitySymbol;
            SecType     = EnumDescConverter.GetEnumDescription(SecurityType.Option);
            LastTradeDateOrContractMonth = "";
            Strike      = strike;
            Right       = EnumDescConverter.GetEnumDescription(right);
            Multiplier  = "100";
            Exchange    = "SMART";
            Currency    = "USD";
            LocalSymbol = optionSymbol;
            PrimaryExch = "SMART";
            SecIdType   = EnumDescConverter.GetEnumDescription(SecurityIdType.None);
            SecId       = string.Empty;

            var ExpirationString = new StringBuilder();
            ExpirationString.AppendFormat("{0:0000}{1:00}", year, month);
            LastTradeDateOrContractMonth = ExpirationString.ToString();
        }

        /// <summary>
        /// Creates an Option Contract
        /// </summary>
        /// <param name="symbol">This is the symbol of the underlying asset.</param>
        /// <param name="exchange">The order destination, such as Smart.</param>
        /// <param name="securityType">This is the security type.</param>
        /// <param name="currency">Specifies the currency.</param>
        /// <param name="expiry">The expiration date. Use the format YYYYMM.</param>
        /// <param name="strike">The strike price.</param>
        /// <param name="right">Specifies a Put or Call.</param>
        public Option(string symbol, string exchange, SecurityType securityType, string currency, string expiry, double strike, RightType right)
        {
            ConId       = 0;
            Symbol      = symbol;
            SecType     = EnumDescConverter.GetEnumDescription(securityType);
            LastTradeDateOrContractMonth = expiry;
            Strike      = strike;
            Right       = EnumDescConverter.GetEnumDescription(right);
            Multiplier  = null;
            Exchange    = exchange;
            Currency    = currency;
            LocalSymbol = null;
            PrimaryExch = null;
            SecIdType   = EnumDescConverter.GetEnumDescription(SecurityIdType.None);
            SecId       = string.Empty;


        }
    }
}
