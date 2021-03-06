﻿namespace Imazen.Common.Instrumentation.Support.RateTracking
{
    /// <summary>
    /// A time duration over which to sample information - like 1 second, 1 minute, 5 minutes, etc.
    /// </summary>
    internal struct NamedInterval
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public long TicksDuration { get; set; }
    }
}