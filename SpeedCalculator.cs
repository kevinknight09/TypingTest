using System.Diagnostics;

namespace TypingTest
{
    public class SpeedCalculator : ISpeedCalculator
	{
		private Stopwatch stopwatch;

		public SpeedCalculator()
		{
			stopwatch = new Stopwatch();
		}

        public void StartTiming()
        {
            stopwatch.Start();
        }

        public void StopTiming()
        {
            stopwatch.Stop();
        }

        public double GetTotalSeconds()
        {
            return stopwatch.Elapsed.TotalSeconds;
        }
    }
}

