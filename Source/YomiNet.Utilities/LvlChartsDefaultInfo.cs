using System;

namespace YomiNet.Utilities;

public class LvlChartsDefaultInfo(DateTime dateTime, double value)
{
    public DateTime DateTime { get; } = dateTime;
    public double Value { get; } = value;
}