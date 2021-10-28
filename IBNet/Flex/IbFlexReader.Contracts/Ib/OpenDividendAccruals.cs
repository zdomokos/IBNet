using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class OpenDividendAccruals
    {
        public OpenDividendAccrual OpenDividendAccrual { get; set; }
    }
}