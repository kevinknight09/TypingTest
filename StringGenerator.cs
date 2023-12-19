using System;
namespace TypingTest
{
	public class StringGenerator : IStringGenerator
	{
        private const string listOfChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private int lengthOfString;

        public StringGenerator()
        {
        }

        public void SetLengthOfString(int length)
        {
            lengthOfString = length;
        }

        public string GetRandomStringToType()
        {
            var random = new Random();
            var stringToType = new char[lengthOfString];

            for (int i = 0; i < lengthOfString; i++)
            {
                stringToType[i] = listOfChars[random.Next(listOfChars.Length)];
            }

            return new string(stringToType);
        }
    }
}

