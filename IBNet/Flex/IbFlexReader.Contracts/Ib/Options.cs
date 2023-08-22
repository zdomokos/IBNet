using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Options
    {
        public bool SplitUpOpenCloseTrades;
        public bool UseXmlReader;
    }
}
