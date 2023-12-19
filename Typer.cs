using System;
namespace TypingTest
{
	public class Typer : ITyper
	{
		private ISpeedCalculator mySpeedCalculator;
		private IStringGenerator myStringGenerator;
		private int myLength;
		private readonly string welcomeMessage = "Hello! Welcome to typing speed Game";
		private readonly string ChooseLevelsMessage = "You can choose Easy Medium and Hard levels, Press 'E' for easy 'M' for medium and 'H' for Hard \n Start Typing as soon as the Text appears";
		
		public Typer()
		{
			mySpeedCalculator = new SpeedCalculator();
			myStringGenerator = new StringGenerator();
		}

		public void StartTyping()
		{
			ShowInitialMessages();

			var difficultyInput = Console.ReadLine();

			SetLevel(difficultyInput.First());
			myStringGenerator.SetLengthOfString(myLength);

			var stringToType = myStringGenerator.GetRandomStringToType();

			OutputStringContent(stringToType,ConsoleColor.DarkGreen);

			TypeContent();
			
			var timeTakenToType = mySpeedCalculator.GetTotalSeconds();
			OutputStringContent($"You took {timeTakenToType} seconds to type the sentence");
		}


		private void SetLevel(char difficulty)
		{
			switch(difficulty)
			{
                case 'E':
					myLength = 20;
					break;

				case 'M':
					myLength = 40;
					break;

				case 'H':
					myLength = 60;
					break;
			}
		}

		private void ShowInitialMessages()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(welcomeMessage);
            Console.WriteLine(ChooseLevelsMessage);
			Console.ResetColor();
        }

		private void OutputStringContent(string stringToType, ConsoleColor consoleForegroundColor = ConsoleColor.White)
		{
			Console.ForegroundColor = consoleForegroundColor;
			Console.WriteLine(stringToType);
			Console.ResetColor();
		}

		private void TypeContent()
		{
            mySpeedCalculator.StartTiming();
            var typedContent = Console.ReadLine();
            mySpeedCalculator.StopTiming();
        }
	}
}

