/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBNet.Messages;

public abstract class MarketDataMessage
{
    public MarketDataMessage(int requestId, int field)
    {
        RequestId = requestId;
        Field     = field;
    }

    public int RequestId { get; set; }
    public int Field { get; set; }
}