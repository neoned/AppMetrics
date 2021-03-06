﻿// <copyright file="NullMeter.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;
using App.Metrics.Meter;

namespace App.Metrics.Internal.NoOp
{
    [ExcludeFromCodeCoverage]
    public struct NullMeter : IMeter
    {
        public void Mark() { }

        public void Mark(MetricSetItem setItem, long amount) { }

        public void Mark(long amount) { }

        public void Mark(string item) { }

        public void Mark(MetricSetItem setItem) { }

        public void Mark(string item, long amount) { }

        public void Reset() { }
    }
}