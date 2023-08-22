using System;
using Headspring;

namespace IBNet.Enums
{
    /// <summary>
    /// Order Type Enumerations
    /// </summary>
    [Serializable]
    public class OrderType : Enumeration<OrderType, string>
    {
        /// <summary>
        /// A Market order is an order to buy or sell an asset at the bid or offer price currently available in the marketplace.
        /// Bonds, Forex, Futures, Future Options, Options, Stocks, Warrants
        /// </summary>
        public static OrderType Market = new OrderType("MKT", nameof(Market));

        /// <summary>
        /// A market order that is submitted to execute as close to the closing price as possible.
        /// Non US Futures, Non US Options, Stocks
        /// </summary>
        //Changed from MKTCLS to MOC based on input from TWS
        public static OrderType MarketOnClose = new OrderType("MOC", nameof(MarketOnClose));

        /// <summary>
        /// A limit order is an order to buy or sell a contract at a specified price or better.
        /// Bonds, Forex, Futures, Future Options, Options, Stocks, Warrants
        /// </summary>
        public static OrderType Limit = new OrderType("LMT", nameof(Limit));

        /// <summary>
        /// An LOC (Limit-on-Close) order that executes at the closing price if the closing price is at or better than the submitted limit price, according to the rules of the specific exchange. Otherwise the order will be cancelled. 
        /// Non US Futures , Stocks
        /// </summary>
        public static OrderType LimitOnClose = new OrderType("LOC", nameof(LimitOnClose));

        /// <summary>
        /// An order that is pegged to buy on the best offer and sell on the best bid.
        /// Your order is pegged to buy on the best offer and sell on the best bid. You can also use an offset amount which is subtracted from the best offer for a buy order, and added to the best bid for a sell order.
        /// Stocks
        /// </summary>
        public static OrderType PeggedToMarket = new OrderType("PEGMKT", nameof(PeggedToMarket));

        /// <summary>
        /// A Stop order becomes a market order to buy or sell securities or commodities once the specified stop price is attained or penetrated.
        /// Forex, Futures, Future Options, Options, Stocks, Warrants
        /// </summary>
        public static OrderType Stop = new OrderType("STP", nameof(Stop));

        /// <summary>
        /// A STOP-LIMIT order is similar to a stop order in that a stop price will activate the order. However, once activated, the stop-limit order becomes a buy limit or sell limit order and can only be executed at a specific price or better. It is a combination of both the stop order and the limit order.
        /// Forex, Futures, Options, Stocks
        /// </summary>
        public static OrderType StopLimit = new OrderType("STP LMT", nameof(StopLimit));

        /// <summary>
        /// A trailing stop for a sell order sets the stop price at a fixed amount below the market price. If the market price rises, the stop loss price rises by the increased amount, but if the stock price falls, the stop loss price remains the same. The reverse is true for a buy trailing stop order.
        /// Forex, Futures, Future Options, Options, Stocks, Warrants
        /// </summary>
        public static OrderType TrailingStop = new OrderType("TRAIL", nameof(TrailingStop));

        /// <summary>
        /// A Relative order derives its price from a combination of the market quote and a user-defined offset amount. The order is submitted as a limit order and modified according to the pricing logic until it is executed or you cancel the order.
        /// Options, Stocks
        /// </summary>
        public static OrderType Relative = new OrderType("REL", nameof(Relative));

        /// <summary>
        /// The VWAP for a stock is calculated by adding the dollars traded for every transaction in that stock ("price" x "number of shares traded") and dividing the total shares traded. By default, a VWAP order is computed from the open of the market to the market close, and is calculated by volume weighting all transactions during this time period. TWS allows you to modify the cut-off and expiration times using the Time in Force and Expiration Date fields, respectively.
        /// Stocks
        /// </summary>
        public static OrderType VolumeWeightedAveragePrice = new OrderType("VWAP", nameof(VolumeWeightedAveragePrice));

        /// <summary>
        /// A trailing stop limit for a sell order sets the stop price at a fixed amount below the market price and defines a limit price for the sell order. If the market price rises, the stop loss price rises by the increased amount, but if the stock price falls, the stop loss price remains the same. When the order triggers, a limit order is submitted at the price you defined. The reverse is true for a buy trailing stop limit order.
        /// Forex, Futures, Future Options, Options, Stocks, Warrants
        /// </summary>
        public static OrderType TrailingStopLimit = new OrderType("TRAILLIMIT", nameof(TrailingStopLimit));

        /// <summary>
        /// TWS Version 857 introduced volatility trading of options, and a new order type, "VOL." What happens with VOL orders is that the limit price that is sent to the exchange is computed by TWS as a function of a daily or annualized option volatility provided by the user. VOL orders can be placed for any US option that trades on the BOX exchange. VOL orders are eligible for dynamic management, a powerful new functionality wherein TWS can manage options orders in response to specifications set by the user.
        /// </summary>
        public static OrderType Volatility = new OrderType("VOL", nameof(Volatility));

        /// <summary>
        /// VOL orders only. Enter an order type to instruct TWS to submit a
        /// delta neutral trade on full or partial execution of the VOL order.
        /// For no hedge delta order to be sent, specify NONE.
        /// </summary>
        public static OrderType None = new OrderType("NONE", nameof(None));

        /// <summary>
        /// Used to initialize the delta Order Field.
        /// </summary>
        public static OrderType Empty = new OrderType("", nameof(Empty));

        /// <summary>
        /// Default - used for Delta Neutral Order Type
        /// </summary>
        public static OrderType Default = new OrderType("Default", nameof(Default));

        /// <summary>
        /// Scale Order.
        /// </summary>
        public static OrderType Scale = new OrderType("SCALE", nameof(Scale));

        /// <summary>
        /// Market if Touched Order.
        /// </summary>
        public static OrderType MarketIfTouched = new OrderType("MIT", nameof(MarketIfTouched));

        /// <summary>
        /// Limit if Touched Order.
        /// </summary>
        public static OrderType LimitIfTouched = new OrderType("LIT", nameof(LimitIfTouched));

        public OrderType(string value, string name) : base(value, name) { }
    }
}
