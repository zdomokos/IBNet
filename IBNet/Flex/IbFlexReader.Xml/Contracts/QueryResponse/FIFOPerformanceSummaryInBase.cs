namespace IbFlexReader.Xml.Contracts.QueryResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "FIFOPerformanceSummaryInBase")]
    public class FIFOPerformanceSummaryInBase
    {
        [XmlElement(ElementName = "FIFOPerformanceSummaryUnderlying")]
        public List<FIFOPerformanceSummaryUnderlying> FIFOPerformanceSummaryUnderlying { get; set; }
    }
}
