using System;
using IBApi;

namespace Krs.Ats.IBNet
{
	/// <summary>
	/// Tick Price Event Arguments
	/// </summary>
	[Serializable()]
	public class TickPriceEventArgs : EventArgs
	{
		private double price;
		private int tickerId;

		private TickType tickType;

		/// <summary>
		/// Full Constructor
		/// </summary>
		/// <param name="tickerId">The ticker Id that was specified previously in the call to reqMktData().</param>
		/// <param name="tickType">Specifies the type of price.</param>
		/// <param name="price">Specifies the price for the specified field.</param>
		/// <param name="attribs"> an TickAttrib object that contains price attributes such as TickAttrib::CanAutoExecute, TickAttrib::PastLimit and TickAttrib::PreOpen..</param>
		public TickPriceEventArgs(int tickerId, TickType tickType, double price, TickAttrib attribs)
		{
			this.tickerId = tickerId;
			this.price = price;
			this.tickType = tickType;
			Attribs = attribs;
		}

		/// <summary>
		/// Uninitialized Constructor for Serialization
		/// </summary>
		public TickPriceEventArgs()
		{
			
		}

		/// <summary>
		/// The ticker Id that was specified previously in the call to reqMktData().
		/// </summary>
		public int TickerId
		{
			get => tickerId;
			set => tickerId = value;
		}

		/// <summary>
		/// Specifies the type of price.
		/// </summary>
		public TickType TickType
		{
			get => tickType;
			set => tickType = value;
		}

		/// <summary>
		/// Specifies the price for the specified field.
		/// </summary>
		public double Price
		{
			get => price;
			set => price = value;
		}

		/// <summary>
		/// specifies whether the price tick is available for automatic execution.
		/// </summary>
		/// <remarks>Possible values are:
		/// 0 = not eligible for automatic execution
		/// 1 = eligible for automatic execution</remarks>
		public TickAttrib Attribs
		{
			get;
			set;
		}
	}
}