/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBNet.Messages;

public class HistoricalDataMessage
{
    public HistoricalDataMessage(int reqId, IBApi.Bar bar)
    {
        RequestId = reqId;
        Date      = bar.Time;
        Open      = bar.Open;
        High      = bar.High;
        Low       = bar.Low;
        Close     = bar.Close;
        Volume    = bar.Volume;
        Count     = bar.Count;
        Wap       = bar.WAP;
    }
    
    protected bool hasGaps;

    public int     RequestId { get; set; }
    public string  Date      { get; set; }
    public double  Open      { get; set; }
    public double  High      { get; set; }
    public double  Low       { get; set; }
    public double  Close     { get; set; }
    public decimal Volume    { get; set; }
    public int     Count     { get; set; }
    public decimal Wap       { get; set; }
}