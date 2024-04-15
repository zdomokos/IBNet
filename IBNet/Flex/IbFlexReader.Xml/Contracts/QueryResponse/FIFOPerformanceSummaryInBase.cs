namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "FifoPerformanceSummaryInBase")]
    public class FifoPerformanceSummaryInBase
    {
        [XmlElement(ElementName = "FifoPerformanceSummaryUnderlying")]
        public List<FifoPerformanceSummaryUnderlying> FifoPerformanceSummaryUnderlying { get; set; }
    }
}
