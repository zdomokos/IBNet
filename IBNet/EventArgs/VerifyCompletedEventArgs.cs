using System;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Event arguments class for the <see cref="InteractiveBrokersClient.VerifyCompleted"/> event
    /// </summary>
    [Serializable]
    public class VerifyCompletedEventArgs : EventArgs
    {
        /// <summary>
        ///
        /// </summary>
        public bool IsSuccessful { get; private set; }

        /// <summary>
        ///
        /// </summary>
        public string ErrorText { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyCompletedEventArgs"/> class
        /// </summary>
        public VerifyCompletedEventArgs(bool isSuccessful, string errorText)
        {
            IsSuccessful = isSuccessful;
            ErrorText = errorText;
        }

        public VerifyCompletedEventArgs() {}
    }
}