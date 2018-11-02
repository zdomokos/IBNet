using System;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Event arguments class for the <see cref="InteractiveBrokersClient.VerifyAndAuthMessageApi"/> event
    /// </summary>
    public class VerifyAndAuthMessageApiEventArgs : EventArgs
    {
        /// <summary>
        ///
        /// </summary>
        public string ApiData { get; private set; }

        /// <summary>
        ///
        /// </summary>
        public string XyzChallenge { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyAndAuthMessageApiEventArgs"/> class
        /// </summary>
        public VerifyAndAuthMessageApiEventArgs(string apiData, string xyzChallenge)
        {
            ApiData = apiData;
            XyzChallenge = xyzChallenge;
        }

        public VerifyAndAuthMessageApiEventArgs() {}
    }
}