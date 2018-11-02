using System;
using IBApi;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Open Order Event Arguments
    /// </summary>
    [Serializable()]
    public class OpenOrderEventArgs : EventArgs
    {
        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="orderId">The order Id assigned by TWS. Used to cancel or update the order.</param>
        /// <param name="contract">Describes the contract for the open order.</param>
        /// <param name="order">Gives the details of the open order.</param>
        /// <param name="orderState">The openOrder() callback with the new OrderState() object will now be invoked each time TWS receives commission information for a trade.</param>
        public OpenOrderEventArgs(int orderId, Contract contract, Order order, OrderState orderState)
        {
            OrderId    = orderId;
            Order      = order;
            Contract   = contract;
            OrderState = orderState;
        }

        ///<summary>
        /// Parameterless OpenOrderEventArgs Constructor
        ///</summary>
        public OpenOrderEventArgs()
        {
            OrderId    = -1;
            Order      = new Order();
            Contract   = new Contract();
            OrderState = new OrderState();
        }


        /// <summary>
        /// The order Id assigned by TWS. Used to cancel or update the order.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Describes the contract for the open order.
        /// </summary>
        public Contract Contract { get; set; }

        /// <summary>
        /// Gives the details of the open order.
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// The openOrder() callback with the new OrderState() object will
        /// now be invoked each time TWS receives commission information for a trade.
        /// </summary>
        public OrderState OrderState { get; set; }
    }
}