using System;
using Headspring;

namespace IBNet.Enums
{
    /// <summary>
    /// Bar Size Requests
    /// </summary>
    [Serializable]
    public class BarSize : Enumeration<BarSize, string>
    {
        public static BarSize S1  = new BarSize("1 sec", nameof(S1));
        public static BarSize S5  = new BarSize("5 secs", nameof(S5));
        public static BarSize S15 = new BarSize("15 secs", nameof(S15));
        public static BarSize S30 = new BarSize("30 secs", nameof(S30));
        public static BarSize M1  = new BarSize("1 min", nameof(M1));
        public static BarSize M2  = new BarSize("2 mins", nameof(M2));
        public static BarSize M3  = new BarSize("3 mins", nameof(M3));
        public static BarSize M5  = new BarSize("5 mins", nameof(M5));
        public static BarSize M10  = new BarSize("10 mins", nameof(M10));
        public static BarSize M15 = new BarSize("15 mins", nameof(M15));
        public static BarSize M20 = new BarSize("20 mins", nameof(M20));
        public static BarSize M30 = new BarSize("30 mins", nameof(M30));
        public static BarSize H1  = new BarSize("1 hour", nameof(H1));
        public static BarSize H2  = new BarSize("2 hours", nameof(H2));
        public static BarSize H3  = new BarSize("3 hours", nameof(H3));
        public static BarSize H4  = new BarSize("4 hours", nameof(H4));
        public static BarSize H8  = new BarSize("8 hours", nameof(H8));
        public static BarSize D1  = new BarSize("1 day", nameof(D1));
        public static BarSize W  = new BarSize("1 week", nameof(W));
        public static BarSize M  = new BarSize("1 month", nameof(M));

        public BarSize(string value, string name) : base(value, name) { }
    }
}
