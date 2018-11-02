using System;
using System.Globalization;
using IBApi;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Argument passed to interactive brokers when requesting execution history.
    /// </summary>
    [Serializable()]
    public class KrsExecutionFilter : ExecutionFilter
    {
        #region Private Variables

        private string acctCode;
        private int clientId;
        private string exchange;
        private string symbol;

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public KrsExecutionFilter()
        {
            SecurityType = SecurityType.Undefined;
            ActionSide = ActionSide.Undefined;
        }

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="clientId">Filter the results of the ReqExecutions() method based on the clientId.</param>
        /// <param name="acctCode">Filter the results of the ReqExecutions() method based on an account code.</param>
        /// <param name="time">Filter the results of the ReqExecutions() method based on execution reports received after the specified time.</param>
        /// <param name="symbol">Filter the results of the ReqExecutions() method based on the order symbol.</param>
        /// <param name="securityType">Refer to the Contract struct for the list of valid security types.</param>
        /// <param name="exchange">Filter the results of the ReqExecutions() method based on the order exchange.</param>
        /// <param name="side">Filter the results of the ReqExecutions() method based on the order action.</param>
        public KrsExecutionFilter(int clientId, string acctCode, DateTime time, string symbol, SecurityType securityType,
                               string exchange, ActionSide side)
        {
            DateTime = time;
            SecurityType = securityType;           
            ActionSide = side;

            Convert();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Filter the results of the ReqExecutions() method based on execution reports received after the specified time. 
        /// </summary>
        /// <remarks>The format for timeFilter is "yyyymmdd-hh:mm:ss"</remarks>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Filter the results of the ReqExecutions() method based on the order security type. 
        /// </summary>
        /// <remarks>Refer to the Contract struct for the list of valid security types.</remarks>
        public SecurityType SecurityType { get; set; }

        /// <summary>
        /// Filter the results of the ReqExecutions() method based on the order action. 
        /// </summary>
        /// <remarks>Refer to the Order struct for the list of valid order actions.</remarks>
        public ActionSide ActionSide { get; set; }

        #endregion

        public void Convert()
        {
            base.Time = DateTime.ToUniversalTime().ToString("yyyyMMdd-HH:mm:ss", CultureInfo.InvariantCulture);
            base.SecType = EnumDescConverter.GetEnumDescription(SecurityType);
            base.Side = EnumDescConverter.GetEnumDescription(ActionSide);
        }
    }
}