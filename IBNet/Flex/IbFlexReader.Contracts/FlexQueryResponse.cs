using System.ComponentModel;
using Ztg.Common.Types;

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

        [TypeConverter(typeof(ListCountConverter))]
        public List<ErrorMessage> Errors { get; set; }
        public string MappingErrors { get; set; }
        
        public override string ToString() { return $"Statements: {FlexStatements?.Count}"; }
    }
}