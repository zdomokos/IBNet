﻿using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FxPositions
    {
        public List<FxPosition> FxPosition { get; set; }
        public FxLots           FxLots     { get; set; }
    }
}
