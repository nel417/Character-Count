using System;

namespace wordcount
{
	class Program
	{
		static void Main(string[] args)

		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;

			Console.WriteLine("Welcome to Character count. please enter your name to continue");
			string name = Console.ReadLine();


			Console.WriteLine("Hello {0}, Please paste the text from your document for a character count", name);
			Console.ResetColor();


			Console.ForegroundColor = ConsoleColor.Green;
			string input = Console.ReadLine();


			Console.WriteLine("your character count is {0}", input.Length);
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.DarkYellow;

			Console.WriteLine("Thank you for using Character Count, {0}, Hope to see you soon!", name);

		}

	}
}
