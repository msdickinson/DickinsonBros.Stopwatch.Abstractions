using System;

namespace DickinsonBros.Stopwatch.Abstractions
{
    public interface IStopwatchService
    {
        public void Start();
        public void Stop();
        public void Reset();
        public TimeSpan Elapsed { get; }
        public long ElapsedMilliseconds { get; }
    }
}
