/*
***********************************************************************************************************************
Author	: Robson Miranda (stra0165)
Date	: 04/01/2017
Comments: Main Class that execute all the other classes
***********************************************************************************************************************
*/
using System;

namespace Assignment4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Console is a class to control all the Console interactions.
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.Clear();
			Console.Title = "Dice-Arama 2001";

			Console.WriteLine();
			Console.WriteLine();
			DLXDice dlxDice = new DLXDice();

			int rolls = 6000000;
			for (int i = 0; i < rolls; i++)
			{
				dlxDice.Roll();
			}

			dlxDice.DrawStatistics(dlxDice.GetStatistics());
			Console.WriteLine();
			Console.WriteLine();

			//new is a reserved word to initiate a new Object 
			Dice dice = new Dice();
			DLXDice dlsxDice2 = new DLXDice();

			Console.WriteLine("Draw Base Class Dice");
			dice.Roll();
			dice.Draw();
			Console.WriteLine();
			Console.WriteLine();


			Console.WriteLine("Draw Derived Class Dice");
			dlsxDice2.Roll();
			dlsxDice2.Draw();
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Press Any Key to finish it!!");
			Console.ReadKey();

		}
	}
}
/*
************************************************************************************************************************
- Comparing C# and Java is very straightforward. I see both have the same structure, although their particularities
  make their strengthener points slight differents.
- I like the close way it treats and calls OS elements. This is much closer to C/C++.
- The same about every single MS language. When you need to build a simple Console Aplication it needs to bring together
  tons of libraries and Dlls.
- Both classes use simple concepts of inheritance found in OPP's concepts.
- I think about having a bit more knowledge in C# to improve my Mobile Developtment options.
************************************************************************************************************************
*/