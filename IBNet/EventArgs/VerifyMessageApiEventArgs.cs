using System;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Event arguments class for the <see cref="InteractiveBrokersClient.VerifyMessageApi"/> event
    /// </summary>
    [Serializable]
    public class VerifyMessageApiEventArgs : EventArgs
    {
        /// <summary>
        ///
        /// </summary>
        public string ApiData { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyMessageApiEventArgs"/> class
        /// </summary>
        public VerifyMessageApiEventArgs(string apiData)
        {
            ApiData = apiData;
        }

        public VerifyMessageApiEventArgs() {}
    }
}