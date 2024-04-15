using System;
using Headspring;

namespace IBNet.Enums;

/// <summary>
/// Retail Customers are restricted to "SAME"
/// Institutional Customers may use "SAME", "OPEN", "CLOSE", "UNKNOWN"
/// </summary>
[Serializable] 
public class ComboOpenClose : Enumeration<ComboOpenClose, string>
{
    /// <summary>
    /// open/close leg value is same as combo
    /// This value is always used for retail accounts
    /// </summary>
    public static ComboOpenClose Same = new("SAME", nameof(Same));
    /// <summary>
    /// Institutional Accounts Only
    /// </summary>
    public static ComboOpenClose Open = new("OPEN", nameof(Open));
    /// <summary>
    /// Institutional Accounts Only
    /// </summary>
    public static ComboOpenClose Close = new("CLOSE", nameof(Close));
    /// <summary>
    /// Institutional Accounts Only
    /// </summary>
    public static ComboOpenClose Unknown = new("UNKNOWN", nameof(Unknown));

    public ComboOpenClose(string value, string name) : base(value, name)
    { }
}