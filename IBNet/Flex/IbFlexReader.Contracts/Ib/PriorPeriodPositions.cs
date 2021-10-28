﻿using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class PriorPeriodPositions
    {
        public List<PriorPeriodPosition> PriorPeriodPosition { get; set; }
    }
}