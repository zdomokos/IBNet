using System;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Event arguments class for the <see cref="InteractiveBrokersClient.DisplayGroupList"/> event
    /// </summary>
    [Serializable]
    public sealed class DisplayGroupListEventArgs : EventArgs
    {
        /// <summary>
        /// The requestId specified in queryDisplayGroups().
        /// </summary>
        public int RequestId { get; private set; }

        /// <summary>
        /// A list of integers representing visible group ID separated by the “|” character, and sorted by most used group first.
        /// This list will not change during TWS session (in other words, user cannot add a new group; sorting can change though).
        /// Example: "3|1|2"
        /// </summary>
        public string Groups { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayGroupListEventArgs"/> class
        /// </summary>
        public DisplayGroupListEventArgs(int reqId, string groups)
        {
            RequestId = reqId;
            Groups = groups;
        }

        public DisplayGroupListEventArgs() {}
    }
}