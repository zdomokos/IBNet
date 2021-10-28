﻿using System.ComponentModel;

namespace IbFlexReader.Contracts
{
    using System.Collections.Generic;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FlexQueryResponse
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public FlexStatements FlexStatements { get; set; }

        public string QueryName { get; set; }

        public string Type { get; set; }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public List<ErrorMessage> Errors { get; set; }
        public string MappingErrors { get; set; }
    }
}