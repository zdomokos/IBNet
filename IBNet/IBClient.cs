using System;
using IBApi;
using System.Threading;

namespace IBNet;

/// <summary>
/// Interactive Brokers Client
/// Handles all communications to and from the TWS.
/// https://interactivebrokers.github.io/tws-api/historical_bars.html
/// </summary>
public partial class IBClient : EWrapper, IDisposable
{
    public void Dispose()
    {
            Dispose(true);
            // This object will be cleaned up by the Dispose method.      // Therefore, you should call GC.SupressFinalize to      // take this object off the finalization queue       // and prevent finalization code for this object      // from executing a second time.
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
                ClientSocket.eDisconnect();
                ClientSocket.Close();
            }
        }

    private void FireEvent(SendOrPostCallback action, object state)
    {
            if (sc != null)
                sc.Post(action, state);
            else
                action(state);
        }

    private GeneralTracer        ibTrace = new GeneralTracer("ibInfo", "Interactive Brokers Parameter Info");
    private EReaderMonitorSignal _signal = new EReaderMonitorSignal();
    private Thread               _messageDispatchThread;
}