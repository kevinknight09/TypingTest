using System;
namespace TypingTest
{
	public interface ISpeedCalculator
	{
		/// <summary>
		/// 
		/// </summary>
		void StartTiming();

		/// <summary>
		/// 
		/// </summary>
		void StopTiming();

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		double GetTotalSeconds();
	}
}

