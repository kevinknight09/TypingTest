using System;
namespace TypingTest
{
	public interface IStringGenerator
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		string GetRandomStringToType();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="length"></param>
		void SetLengthOfString(int length);
	}
}

