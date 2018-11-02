using System;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Order Status Event Arguments
    /// </summary>
    [Serializable()]
    public class OrderStatusEventArgs : EventArgs
    {
        private double _averageFillPrice;
        private int _clientId;
        private int _filled;
        private double _lastFillPrice;
        private int _orderId;
        private int _parentId;
        private int _permId;
        private int _remaining;
        private string _whyHeld;

        private OrderStatus _status;

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="orderId">The order Id that was specified previously in the call to placeOrder().</param>
        /// <param name="status">The order status.</param>
        /// <param name="filled">Specifies the number of shares that have been executed.</param>
        /// <param name="remaining">Specifies the number of shares still outstanding.</param>
        /// <param name="averageFillPrice">The average price of the shares that have been executed.
        /// This parameter is valid only if the filled parameter value
        /// is greater than zero. Otherwise, the price parameter will be zero.</param>
        /// <param name="permId">The TWS id used to identify orders. Remains the same over TWS sessions.</param>
        /// <param name="parentId">The order ID of the parent order, used for bracket and auto trailing stop orders.</param>
        /// <param name="lastFillPrice">The last price of the shares that have been executed. This parameter is valid
        /// only if the filled parameter value is greater than zero. Otherwise, the price parameter will be zero.</param>
        /// <param name="clientId">The ID of the client (or TWS) that placed the order.
        /// The TWS orders have a fixed clientId and orderId of 0 that distinguishes them from API orders.</param>
        /// <param name="whyHeld">This field is used to identify an order held when TWS is trying to locate shares for a short sell.
        /// The value used to indicate this is 'locate'.</param>
        /// <param name="mktCapPrice">mktCapPrice If an order has been capped, this indicates the current capped price. Requires TWS 967+ and API v973.04+. Python API specifically requires API v973.06+.</param>
        public OrderStatusEventArgs(int orderId, OrderStatus status, int filled, int remaining, double averageFillPrice,
                                    int permId, int parentId, double lastFillPrice, int clientId, string whyHeld, double mktCapPrice)
        {
            _orderId = orderId;
            _clientId = clientId;
            _lastFillPrice = lastFillPrice;
            _parentId = parentId;
            _permId = permId;
            _averageFillPrice = averageFillPrice;
            _remaining = remaining;
            _filled = filled;
            _status = status;
            _whyHeld = whyHeld;
            MktCapPrice = mktCapPrice;
        }

        ///<summary>
        /// Parameterless OrderStatusEventArgs Constructor for serialization
        ///</summary>
        public OrderStatusEventArgs()
        {
            _orderId = -1;
            _clientId = -1;
            _lastFillPrice = -1;
            _parentId = -1;
            _permId = -1;
            _averageFillPrice = -1;
            _remaining = -1;
            _filled = -1;
            _status = OrderStatus.Error; //OrderStatus.None;
            _whyHeld = "";
        }
        
        /// <summary>
        /// The order Id that was specified previously in the call to placeOrder().
        /// </summary>
        public int OrderId
        {
            get => _orderId;
	        set => _orderId = value;
        }

        /// <summary>
        /// The order status.
        /// </summary>
        /// <remarks>Possible values include:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>PendingSubmit</term>
        /// <description>indicates that you have transmitted the order, but have not yet received confirmation that it has been accepted by the order destination. This order status is not sent by TWS and should be explicitly set by the API developer when an order is submitted.</description>
        /// </item>
        /// <item>
        /// <term>PendingCancel</term>
        /// <description>Indicates that you have sent a request to cancel the order but have not yet received cancel confirmation from the order destination. At this point, your order is not confirmed canceled. You may still receive an execution while your cancellation request is pending. This order status is not sent by TWS and should be explicitly set by the API developer when an order is canceled.</description>
        /// </item>
        /// <item>
        /// <term>PreSubmitted</term>
        /// <description>Indicates that a simulated order type has been accepted by the IB system and that this order has yet to be elected. The order is held in the IB system (and the status remains DARK BLUE) until the election criteria are met. At that time the order is transmitted to the order destination as specified (and the order status color will change).</description>
        /// </item>
        /// <item>
        /// <term>Submitted</term>
        /// <description>Indicates that your order has been accepted at the order destination and is working.</description>
        /// </item>
        /// <item>
        /// <term>Cancelled</term>
        /// <description>Indicates that the balance of your order has been confirmed canceled by the IB system. This could occur unexpectedly when IB or the destination has rejected your order.</description>
        /// </item>
        /// <item>
        /// <term>Filled</term>
        /// <description>The order has been completely filled.</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="OrderStatus"/>
        public OrderStatus Status
        {
            get => _status;
	        set => _status = value;
        }

        /// <summary>
        /// Specifies the number of shares that have been executed.
        /// </summary>
        public int Filled
        {
            get => _filled;
	        set => _filled = value;
        }

        /// <summary>
        /// Specifies the number of shares still outstanding.
        /// </summary>
        public int Remaining
        {
            get => _remaining;
	        set => _remaining = value;
        }

        /// <summary>
        /// The average price of the shares that have been executed.
        /// This parameter is valid only if the filled parameter value
        /// is greater than zero. Otherwise, the price parameter will be zero.
        /// </summary>
        public double AverageFillPrice
        {
            get => _averageFillPrice;
	        set => _averageFillPrice = value;
        }

        /// <summary>
        /// The TWS id used to identify orders. Remains the same over TWS sessions.
        /// </summary>
        public int PermId
        {
            get => _permId;
	        set => _permId = value;
        }

        /// <summary>
        /// The order ID of the parent order, used for bracket and auto trailing stop orders.
        /// </summary>
        public int ParentId
        {
            get => _parentId;
	        set => _parentId = value;
        }

        /// <summary>
        /// The last price of the shares that have been executed. This parameter is valid
        /// only if the filled parameter value is greater than zero. Otherwise, the price parameter will be zero.
        /// </summary>
        public double LastFillPrice
        {
            get => _lastFillPrice;
	        set => _lastFillPrice = value;
        }

        /// <summary>
        /// The ID of the client (or TWS) that placed the order.
        /// The TWS orders have a fixed clientId and orderId of 0 that distinguishes them from API orders.
        /// </summary>
        public int ClientId
        {
            get => _clientId;
	        set => _clientId = value;
        }

        /// <summary>
        /// This field is used to identify an order held when TWS is trying to locate shares for a short sell.
        /// The value used to indicate this is 'locate'.
        /// </summary>
        /// <remarks>This field is supported starting with TWS release 872.</remarks>
        public string WhyHeld
        {
            get => _whyHeld;
	        set => _whyHeld = value;
        }

        public double MktCapPrice { get; set; }
    }
}