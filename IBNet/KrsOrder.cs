using IBApi;

namespace Krs.Ats.IBNet
{
    public class KrsOrderFactory
    {
        public static Order CreateOrder(ActionSide action, OrderType orderType
            , double limitPrice, double auxPrice, int quantity, bool outRth, int parentId)
        {
            var order = new Order
            {
                Action        = EnumDescConverter.GetEnumDescription(action),
                OutsideRth    = false,
                LmtPrice      = limitPrice,
                OrderType     = EnumDescConverter.GetEnumDescription(orderType),
                TotalQuantity = quantity,
                ParentId      = parentId,
            };
            return order;
        }
        
    }
}

//    /// <summary>
//    /// Order class passed to Interactive Brokers to place an order.
//    /// </summary>
//    [Serializable()]
//    public class KrsOrder : Order
//    {
//        /// <summary>
//        /// Identifies the side. Valid values are: BUY, SELL, SSHORT
//        /// </summary>
//        public ActionSide Action { get; set; }

//        /// <summary>
//        /// The order type.
//        /// </summary>
//        /// <seealso cref="OrderType"/>
//        public OrderType OrderType { get; set; }

//        /// <summary>
//        /// The time in force.
//        /// </summary>
//        /// <remarks>Valid values are: DAY, GTC, IOC, GTD.</remarks>
//        /// <seealso cref="TimeInForce"/>
//        public TimeInForce Tif { get; set; }

//        /// <summary>
//        /// Tells how to handle remaining orders in an OCA group when one order or part of an order executes.
//        /// </summary>
//        /// <remarks>
//        /// Valid values include:
//        /// <list type="bullet">
//        /// <item>1 = Cancel all remaining orders with block.</item>
//        /// <item>2 = Remaining orders are proportionately reduced in size with block.</item>
//        /// <item>3 = Remaining orders are proportionately reduced in size with no block.</item>
//        /// </list>
//        /// If you use a value "with block"gives your order has overfill protection. This means  that only one order in the group will be routed at a time to remove the possibility of an overfill.
//        /// </remarks>
//        /// <seealso cref="OcaType"/>
//        public OcaType OcaType { get; set; }

//        /// <summary>
//        /// This is the LIMIT price, used for limit, stop-limit and relative orders.
//        /// In all other cases specify zero. For relative orders with no limit price,
//        /// also specify zero.
//        /// </summary>
//        public double LimitPrice { get; set; }

//        /// <summary>
//        /// The Financial Advisor group the trade will be allocated to -- use an empty String if not applicable.
//        /// </summary>
//        public string FAGroup { get; set; }

//        /// <summary>
//        /// The Financial Advisor allocation profile the trade will be allocated to -- use an empty String if not applicable.
//        /// </summary>
//        public string FAProfile { get; set; }

//        /// <summary>
//        /// The Financial Advisor allocation method the trade will be allocated with -- use an empty String if not applicable.
//        /// </summary>
//        public FinancialAdvisorAllocationMethod FAMethod { get; set; }

//        /// <summary>
//        /// The Financial Advisor percentage concerning the trade's allocation -- use an empty String if not applicable.
//        /// </summary>
//        public string FAPercentage { get; set; }
//    }
