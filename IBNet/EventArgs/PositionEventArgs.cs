using System;
using IBApi;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Provides the portfolio's open positions.
    /// </summary>
    [Serializable()]
    public class PositionEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="account">the account holding the position.</param>
        /// <param name="contract">contract the position's Contract</param>
        /// <param name="pos">pos the number of positions held.</param>
        /// <seealso cref="PositionEndEventArgs"/>
        public PositionEventArgs(string account, Contract contract, int pos, double avgCost)
        {
            Account = account;
            Contract = contract;
            Size = pos;
            AvgCost = avgCost;
        }

        /// <summary>
        /// Uninitialized Constructor for Serialization
        /// </summary>
        public PositionEventArgs() { }

        /// <summary>
        /// The account holding the position.
        /// </summary>
        public string Account { get; set; }
        
        /// <summary>
        /// Contract the position's Contract
        /// </summary>
        public Contract Contract { get; set; }
        
        /// <summary>
        /// Pos the number of positions held.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        ///
        /// </summary>
        public double AvgCost { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable()]
    public class PositionEndEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public PositionEndEventArgs()
        {
        }
    }
}