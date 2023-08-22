using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace IBNet.Utils
{
    public class ListCountConverter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is IList list && destinationType == typeof(string))
            {
                return $"Count: {list.Count}";
            }

            return base.ConvertTo(
                context,
                culture,
                value,
                destinationType);
        }
    }
}
