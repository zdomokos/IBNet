using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Order Status reported by enum order status.
/// </summary>
[Serializable]
public class OrderStatus : Enumeration<OrderStatus, string>
{
    /// <summary>
    /// indicates that you have transmitted the order, but have not yet received
    /// confirmation that it has been accepted by the order destination.
    /// This order status is not sent by TWS and should be explicitly set by the API developer when an order is submitted.
    /// </summary>
    public static OrderStatus PendingSubmit = new("PendingSubmit", nameof(PendingSubmit));

    /// <summary>
    /// PendingCancel - indicates that you have sent a request to cancel the order
    /// but have not yet received cancel confirmation from the order destination.
    /// At this point, your order is not confirmed canceled. You may still receive
    /// an execution while your cancellation request is pending.
    /// This order status is not sent by TWS and should be explicitly set by the API developer when an order is canceled.
    /// </summary>
    public static OrderStatus PendingCancel = new("PendingCancel", nameof(PendingCancel));

    /// <summary>
    /// indicates that a simulated order type has been accepted by the IB system and
    /// that this order has yet to be elected. The order is held in the IB system
    /// (and the status remains DARK BLUE) until the election criteria are met.
    /// At that time the order is transmitted to the order destination as specified
    /// (and the order status color will change).
    /// </summary>
    public static OrderStatus PreSubmitted = new("PreSubmitted", nameof(PreSubmitted));

    /// <summary>
    /// indicates that your order has been accepted at the order destination and is working.
    /// </summary>
    public static OrderStatus Submitted = new("Submitted", nameof(Submitted));

    /// <summary>
    /// indicates that the balance of your order has been confirmed canceled by the IB system.
    /// This could occur unexpectedly when IB or the destination has rejected your order.
    /// </summary>
    public static OrderStatus Canceled = new("Cancelled", nameof(Canceled));

    /// <summary>
    /// The order has been completely filled.
    /// </summary>
    public static OrderStatus Filled = new("Filled", nameof(Filled));

    /// <summary>
    /// The Order is inactive
    /// </summary>
    public static OrderStatus Inactive = new("Inactive", nameof(Inactive));

    /// <summary>
    /// The order is Partially Filled
    /// </summary>
    public static OrderStatus PartiallyFilled = new("PartiallyFilled", nameof(PartiallyFilled));

    /// <summary>
    /// Api Pending
    /// </summary>
    public static OrderStatus ApiPending = new("ApiPending", nameof(ApiPending));

    /// <summary>
    /// Api Cancelled
    /// </summary>
    public static OrderStatus ApiCancelled = new("ApiCancelled", nameof(ApiCancelled));

    /// <summary>
    /// Indicates that there is an error with this order
    /// This order status is not sent by TWS and should be explicitly set by the API developer when an error has occured.
    /// </summary>
    public static OrderStatus Error = new("Error", nameof(Error));

    /// <summary>
    /// No Order Status
    /// </summary>
    public static OrderStatus None = new("", nameof(None));

    public OrderStatus(string value, string name) : base(value, name)
    { }
}