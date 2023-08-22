using System.ComponentModel;

namespace IbFlexReader.Contracts.Ib
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Constants
    {
        public const string DateFormat = "yyyyMMdd";
        public const string TimeFormat = "HHmmss";
        public const string DateTimeFormat = DateFormat + ";" + TimeFormat;
    }
}
