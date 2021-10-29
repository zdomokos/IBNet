﻿using System.ComponentModel;
using Ztg.Common.Types;

namespace IbFlexReader.Contracts
{
    using System.Collections.Generic;
    using IbFlexReader.Contracts.Ib;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FlexStatements
    {
        [TypeConverter(typeof(ListCountConverter))]
        public List<FlexStatement> FlexStatement { get; set; }

        public int? Count { get; set; }
    }
}