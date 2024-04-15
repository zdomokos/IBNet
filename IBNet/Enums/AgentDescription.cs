using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Used for Rule 80A describes the type of trader.
/// </summary>
[Serializable]
public class AgentDescription : Enumeration<AgentDescription, string>
{
    public static AgentDescription Individual           = new("I", nameof(Individual));
    public static AgentDescription Agency               = new("A", nameof(Agency));
    public static AgentDescription AgentOtherMember     = new("W", nameof(AgentOtherMember));
    public static AgentDescription IndividualPTIA       = new("J", nameof(IndividualPTIA));
    public static AgentDescription AgencyPTIA           = new("U", nameof(AgencyPTIA));
    public static AgentDescription AgentOtherMemberPTIA = new("M", nameof(AgentOtherMemberPTIA));
    public static AgentDescription IndividualPT         = new("K", nameof(IndividualPT));
    public static AgentDescription AgencyPT             = new("Y", nameof(AgencyPT));
    public static AgentDescription AgentOtherMemberPT   = new("N", nameof(AgentOtherMemberPT));
    public static AgentDescription None                 = new("", nameof(None));

    public AgentDescription(string value, string name) : base(value, name)
    { }
}