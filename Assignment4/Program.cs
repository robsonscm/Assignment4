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

			uint[] numbers = new uint[6];

			for (int i = 0; i < 1000000; i++)
			{
				switch (d1.Roll())
				{
					case 1:
						numbers[0]++;
						break;
					case 2:
						numbers[1]++;
						break;
					case 3:
						numbers[2]++;
						break;
					case 4:
						numbers[3]++;
						break;
					case 5:
						numbers[4]++;
						break;
					case 6:
						numbers[5]++;
						break;
					default:
						Console.WriteLine("DICE NUMBER HAS AN ERROR!!!");
						break;
				}
			}
			short side = 0;
			foreach (uint n in numbers)
			{
				side++;
				Console.WriteLine("Side " + side + " got "+ n + " times! \n");
			}
			//d1.Draw();

		}
	}
}
