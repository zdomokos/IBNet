using System;
using Ztg.Common.DataStructures.Enums;

namespace IBNet.Enums
{
    /// <summary>
    /// Used for Rule 80A describes the type of trader.
    /// </summary>
    [Serializable]
    public class AgentDescription : Enumeration<AgentDescription, string>
    {
        public static AgentDescription Individual = new AgentDescription("I", nameof(Individual));
        public static AgentDescription Agency = new AgentDescription("A", nameof(Agency));
        public static AgentDescription AgentOtherMember = new AgentDescription("W", nameof(AgentOtherMember));
        public static AgentDescription IndividualPTIA = new AgentDescription("J", nameof(IndividualPTIA));
        public static AgentDescription AgencyPTIA = new AgentDescription("U", nameof(AgencyPTIA));
        public static AgentDescription AgentOtherMemberPTIA = new AgentDescription("M", nameof(AgentOtherMemberPTIA));
        public static AgentDescription IndividualPT = new AgentDescription("K", nameof(IndividualPT));
        public static AgentDescription AgencyPT = new AgentDescription("Y", nameof(AgencyPT));
        public static AgentDescription AgentOtherMemberPT = new AgentDescription("N", nameof(AgentOtherMemberPT));
        public static AgentDescription None = new AgentDescription("", nameof(None));

        public AgentDescription(string value, string name) : base(value, name)
        { }
    }
}
