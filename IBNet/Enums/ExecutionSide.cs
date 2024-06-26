using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Describes whether a security was bought or sold in an execution.
/// The past tense equivalent of ActionSide.
/// </summary>
[Serializable]
public class ExecutionSide : Enumeration<ExecutionSide, string>
{
    public static ExecutionSide Bought = new("BOT", nameof(Bought));
    public static ExecutionSide Sold   = new("SLD", nameof(Sold));

    public ExecutionSide(string value, string name) : base(value, name)
    {
    }
}