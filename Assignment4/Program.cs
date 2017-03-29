using System;

namespace Assignment4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Clear();
			Console.Title = "Dice-Arama 2001";

			Dice d1 = new Dice();

			for (int i = 0; i < 50; i++)
			{
				d1.Roll();
				d1.Draw();
			}
		}
	}
}
