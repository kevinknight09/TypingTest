using System;
namespace TypingTest
{
	public interface IStringGenerator
	{
		/// <summary>
		/// Generates a random string for the user to type
		/// </summary>
		/// <returns></returns>
		string GetRandomStringToType();

		/// <summary>
		/// Sets the length of the string 
		/// </summary>
		/// <param name="length"></param>
		void SetLengthOfString(int length);
	}
}

