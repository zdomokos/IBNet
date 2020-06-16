/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;
using System.Globalization;
using IBApi;

namespace IBNet.Utils
{
    public class DateUtils
    {
        public static DateTime ToUtcDateTime(string ibDateTime)
        {
            //Comes in as seconds
            //2 - dates are returned as a long integer specifying the number of seconds since 1/1/1970 GMT.
            string d        = ibDateTime;
            long   longDate = Int64.Parse(d, CultureInfo.InvariantCulture);
            //Check if date time string or seconds
            DateTime timeStamp;
            if (longDate < 30000000)
                timeStamp = new DateTime(Int32.Parse(d.Substring(0, 4))
                                       , Int32.Parse(d.Substring(4, 2))
                                       , Int32.Parse(d.Substring(6, 2)), 0, 0, 0);
            else
                timeStamp = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(longDate);

            return timeStamp;
        }

        public static string UnixMillisecondsToString(long milliseconds, string dateFormat)
        {
            return string.Format("{0:" + dateFormat + "}", DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc).AddMilliseconds(milliseconds));
        }
    }

    public class InstrumentUtils
    {
        public static string ContractToString(Contract contract)
        {
            return contract.Symbol + " " + contract.SecType + " " + contract.Currency + " @ " + contract.Exchange;
        }

        public static bool ContractsAreEqual(Contract contractA, Contract contractB)
        {
            if (contractA.Symbol.Equals(contractB.Symbol) && contractA.SecType.Equals(contractB.SecType) && contractA.Currency.Equals(contractB.Currency))
            {
                if (contractA.LastTradeDateOrContractMonth != null && contractB.LastTradeDateOrContractMonth != null)
                {
                    if (contractA.LastTradeDateOrContractMonth.Equals(contractB.LastTradeDateOrContractMonth))
                    {
                        if (contractA.Multiplier != null && contractB.Multiplier != null)
                        {
                            return contractA.Multiplier.Equals(contractB.Multiplier);
                        }
                        else
                            return true;
                    }
                }
                else
                    return true;
            }

            return false;
        }
    }
}