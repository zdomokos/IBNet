using System;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Event arguments class for the <see cref="InteractiveBrokersClient.VerifyAndAuthCompleted"/> event
    /// </summary>
    [Serializable]
    public class VerifyAndAuthCompletedEventArgs : EventArgs
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
        /// Initializes a new instance of the <see cref="VerifyAndAuthCompletedEventArgs"/> class
        /// </summary>
        public VerifyAndAuthCompletedEventArgs(bool isSuccessful, string errorText)
        {
            IsSuccessful = isSuccessful;
            ErrorText = errorText;
        }

        public VerifyAndAuthCompletedEventArgs() {}
    }
}