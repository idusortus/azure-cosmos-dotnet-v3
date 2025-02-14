﻿// This file isn't generated, but this comment is necessary to exclude it from StyleCop analysis.
// <auto-generated/>

using Xunit;

namespace HdrHistogram.UnitTests
{
    
    internal class IntConcurrentHistogramTests : ConcurrentHistogramTestBase
    {
        protected override int WordSize => sizeof(int);

        internal override HistogramBase Create(long highestTrackableValue, int numberOfSignificantValueDigits)
        {
            //return new IntConcurrentHistogram(1, highestTrackableValue, numberOfSignificantValueDigits);
            return HistogramFactory.With32BitBucketSize()
                .WithValuesUpTo(highestTrackableValue)
                .WithPrecisionOf(numberOfSignificantValueDigits)
                .WithThreadSafeWrites()
                .Create();
        }

        internal override HistogramBase Create(long lowestTrackableValue, long highestTrackableValue, int numberOfSignificantValueDigits)
        {
            //return new IntConcurrentHistogram(lowestTrackableValue, highestTrackableValue, numberOfSignificantValueDigits);
            return HistogramFactory.With32BitBucketSize()
                .WithValuesFrom(lowestTrackableValue)
                .WithValuesUpTo(highestTrackableValue)
                .WithPrecisionOf(numberOfSignificantValueDigits)
                .WithThreadSafeWrites()
                .Create();
        }
    }
}