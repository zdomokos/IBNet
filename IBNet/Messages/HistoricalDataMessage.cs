/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBNet.Messages;

public class HistoricalDataMessage
{
    protected int     requestId;
    protected string  date;
    protected double  open;
    protected double  high;
    protected double  low;
    protected double  close;
    protected decimal volume;
    protected int     count;
    protected decimal wap;
    protected bool    hasGaps;

    public int RequestId
    {
        get => requestId;
        set => requestId = value;
    }

    public string Date
    {
        get => date;
        set => date = value;
    }

    public double Open
    {
        get => open;
        set => open = value;
    }


    public double High
    {
        get => high;
        set => high = value;
    }

    public double Low
    {
        get => low;
        set => low = value;
    }

    public double Close
    {
        get => close;
        set => close = value;
    }

    public decimal Volume
    {
        get => volume;
        set => volume = value;
    }

    public int Count
    {
        get => count;
        set => count = value;
    }

    public decimal Wap
    {
        get => wap;
        set => wap = value;
    }

    public bool HasGaps
    {
        get => hasGaps;
        set => hasGaps = value;
    }

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
}