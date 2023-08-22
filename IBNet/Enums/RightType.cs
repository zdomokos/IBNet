using System;
using Ztg.Common.DataStructures.Enums;

namespace IBNet.Enums
{
    /// <summary>
    /// Option Right Type (Put or Call)
    /// </summary>
    [Serializable]
    public class RightType : Enumeration<RightType, string>
    {
        public static RightType Put = new RightType("P", nameof(Put));
        public static RightType Call = new RightType("C", nameof(Call));

        public RightType(string value, string name) : base(value, name) { }
    }
}
