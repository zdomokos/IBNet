/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBNet.Messages;

public class HistoricalDataEndMessage
{
    public HistoricalDataEndMessage(int requestId, string startDate, string endDate)
    {
        RequestId = requestId;
        StartDate = startDate;
        EndDate   = endDate;
    }
    
    public string StartDate { get; set; }
    public int    RequestId { get; set; }
    public string EndDate   { get; set; }
}