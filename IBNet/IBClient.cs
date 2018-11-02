using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Diagnostics;
using IBApi;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Interactive Brokers Client
    /// Handles all communications to and from the TWS.
    /// </summary>
    public partial class IBClient : EWrapper, IDisposable
    {

        public readonly EReaderSignal Signal;

        public IBClient()
        {
            Signal = new EReaderMonitorSignal();
            _socket = new EClientSocket(this, Signal);
            ibTrace.Level = TraceLevel.Verbose;
        }

        public void Dispose()
        {
            Dispose(true);
            // This object will be cleaned up by the Dispose method. 
            // Therefore, you should call GC.SupressFinalize to 
            // take this object off the finalization queue  
            // and prevent finalization code for this object 
            // from executing a second time.
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// The bulk of the clean-up code is implemented in Dispose(bool)
        /// </summary>
        /// <param name="disposing">Allows the ondispose method to override the dispose action.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                GeneralTracer.WriteLineIf(ibTrace.TraceInfo, "IBClient Dispose");
                _socket.eDisconnect();
                _socket.Close();
            }
        }

        #region Tracer
        private GeneralTracer ibTrace = new GeneralTracer("ibInfo", "Interactive Brokers Parameter Info");
        private GeneralTracer ibTickTrace = new GeneralTracer("ibTicks", "Interactive Brokers Tick Info");
        #endregion
    }
}