﻿using System.Collections.Generic;
using Reporting;
using System;

namespace ScenarioMeasurement
{
    public interface IParser
    {
        void EnableUserProviders(ITraceSession user);
        void EnableKernelProvider(ITraceSession kernel);
        IEnumerable<Counter> Parse(string mergeTraceFile, string processName, IList<int> pids, string commandLine);
    }
}
