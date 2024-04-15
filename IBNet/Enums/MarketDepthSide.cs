using System;

namespace IBNet.Enums;

/// <summary>
/// Market Depth Side
/// </summary>
[Serializable] 
public enum MarketDepthSide
{
    /// <summary>
    /// Ask Price Side
    /// </summary>
    Ask = 0,
    /// <summary>
    /// Bid Price Side
    /// </summary>
    Bid = 1
}