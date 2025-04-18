/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBNet.Messages;

public class AdvisorDataMessage
{
    public AdvisorDataMessage(int faDataType, string data)
    {
        FaDataType = faDataType;
        Data       = data;
    }

    public int    FaDataType { get; set; }
    public string Data       { get; set; }
}