using System;

namespace IBNet.Enums
{
    /// <summary>
    /// Used for the set server log level
    /// </summary>
    [Serializable] 
    public enum ServerLogLevel
    {
        /// <summary>
        /// System Messages
        /// </summary>
        System = 1,
        /// <summary>
        /// Error Messages
        /// </summary>
        Error = 2,
        /// <summary>
        /// Warning Messages
        /// </summary>
        Warning = 3,
        /// <summary>
        /// Information Messages
        /// </summary>
        Information = 4,
        /// <summary>
        /// Detail Messages
        /// </summary>
        Detail = 5
    }
}