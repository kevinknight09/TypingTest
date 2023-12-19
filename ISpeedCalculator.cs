using System;
namespace TypingTest
{
	public interface ISpeedCalculator
	{
		/// <summary>
		/// Starts the stopwatch for calculating the total seconds
		/// </summary>
		void StartTiming();

		/// <summary>
		/// Stops the stopwatch
		/// </summary>
		void StopTiming();

		/// <summary>
		/// Gets the total seconds required for writing the sentence
		/// </summary>
		/// <returns></returns>
		double GetTotalSeconds();
	}
}

