/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBNet.Messages;

public class MarketDataTypeMessage
{
    public MarketDataTypeMessage(int requestId, int marketDataType)
    {
        RequestId      = requestId;
        MarketDataType = marketDataType;
    }

    public int RequestId { get; set; }
    public int MarketDataType { get; set; }
}