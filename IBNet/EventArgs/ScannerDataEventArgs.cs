using System;
using IBApi;

namespace Krs.Ats.IBNet
{
	/// <summary>
	/// Scanner Data Event Arguments
	/// </summary>
	[Serializable()]
	public class ScannerDataEventArgs : EventArgs
	{
		private string benchmark;
		private ContractDetails contractDetails;
		private string distance;
		private string legsStr;
		private string projection;
		private int rank;
		private int requestId;

		/// <summary>
		/// Full Constructor
		/// </summary>
		/// <param name="requestId">The ticker ID of the request to which this row is responding.</param>
		/// <param name="rank">The ranking within the response of this bar.</param>
		/// <param name="contractDetails">This structure contains a full description of the contract that was executed.</param>
		/// <param name="distance">Meaning varies based on query.</param>
		/// <param name="benchmark">Meaning varies based on query.</param>
		/// <param name="projection">Meaning varies based on query.</param>
		/// <param name="legsStr">Describes combo legs when scan is returning EFP.</param>
		public ScannerDataEventArgs(int requestId, int rank, ContractDetails contractDetails, string distance,
									string benchmark, string projection, string legsStr)
		{
			this.requestId = requestId;
			this.legsStr = legsStr;
			this.projection = projection;
			this.benchmark = benchmark;
			this.distance = distance;
			this.contractDetails = contractDetails;
			this.rank = rank;
		}

		/// <summary>
		/// Uninitialized Constructor for Serialization
		/// </summary>
		public ScannerDataEventArgs()
		{
			
		}

		/// <summary>
		/// The ticker ID of the request to which this row is responding.
		/// </summary>
		public int RequestId
		{
			get => requestId;
			set => requestId = value;
		}

		/// <summary>
		/// The ranking within the response of this bar.
		/// </summary>
		public int Rank
		{
			get => rank;
			set => rank = value;
		}

		/// <summary>
		/// This structure contains a full description of the contract that was executed.
		/// </summary>
		public ContractDetails ContractDetails
		{
			get => contractDetails;
			set => contractDetails = value;
		}

		/// <summary>
		/// Meaning varies based on query.
		/// </summary>
		public string Distance
		{
			get => distance;
			set => distance = value;
		}

		/// <summary>
		/// Meaning varies based on query.
		/// </summary>
		public string Benchmark
		{
			get => benchmark;
			set => benchmark = value;
		}

		/// <summary>
		/// Meaning varies based on query.
		/// </summary>
		public string Projection
		{
			get => projection;
			set => projection = value;
		}

		/// <summary>
		/// Describes combo legs when scan is returning EFP.
		/// </summary>
		public string LegsStr
		{
			get => legsStr;
			set => legsStr = value;
		}
	}
}