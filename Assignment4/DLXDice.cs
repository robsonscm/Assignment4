/*
***********************************************************************************************************************
Author	: Robson Miranda (stra0165)
Date	: 04/01/2017
Comments: Derived Class Dice DLX
***********************************************************************************************************************
*/
using System;
namespace Assignment4
{
	public class DLXDice : Dice
	{
		protected uint[] numbers = new uint[6];

		protected byte GenerateStatistics(byte inValue)
		{
			switch (inValue)
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
			return inValue;
		}

		//base is a reserved word that represent the Base class and which can access all attributes and methods from the Base class
		public DLXDice() : base()
		{
		}

		public DLXDice(byte value) : base(value)
		{
			byte min = 1;
			byte max = 6;
			base.value = (value < min) ? min : 
						 (value > max) ? max : value;
		}

		public override void Draw()
		{
			string ulCorner 	= "╔";
			string llCorner 	= "╚";
			string urCorner 	= "╗";
			string lrCorner 	= "╝";
			string vertical 	= "║";
			string horizontal 	= "═";
			string space 		= " ";
			//string tab 			= "\t";

			Console.WriteLine(ulCorner + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + urCorner);
			Console.WriteLine(vertical + space + space + space + space + space + space + space + vertical);
			Console.WriteLine(vertical + space + space + space + base.value + space + space + space + vertical);
			Console.WriteLine(vertical + space + space + space + space + space + space + space + vertical);
			Console.WriteLine(llCorner + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + lrCorner);
			//base.Draw();
		}

		public void DrawStatistics(uint[] statistics)
		{
			string ulCorner 	= "╔";
			string llCorner 	= "╚";
			string urCorner 	= "╗";
			string lrCorner 	= "╝";
			string vertical 	= "║";
			string horizontal 	= "═";
			string space 		= " ";
			//string tab 			= "\t";

			short side = 0;
			string[] lines = new string[7];

			lines[0] = vertical + space + space;
			lines[1] = vertical + space + space;
			lines[2] = vertical + space + space;
			lines[3] = vertical + space + space;
			lines[4] = vertical + space + space;
			lines[5] = vertical + space + space;
			lines[6] = vertical + space + space + space;

			foreach (uint n in statistics)
			{
				side++;
				lines[0] = lines[0] + ulCorner + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + urCorner + space;
				lines[1] = lines[1] + vertical + space + space + space + space + space + space + space + vertical + space;
				lines[2] = lines[2] + vertical + space + space + space + side + space + space + space + vertical + space;
				lines[3] = lines[3] + vertical + space + space + space + space + space + space + space + vertical + space;
				lines[4] = lines[4] + llCorner + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + lrCorner + space;
				lines[5] = (n > 1000000) ? (lines[5] + space + n + space + space) : (lines[5] + space + space + n + space + space);
				lines[6] = lines[6] + space + "Rolls!" + space + space + space;
			}

			lines[0] = lines[0] + space + vertical;
			lines[1] = lines[1] + space + vertical;
			lines[2] = lines[2] + space + vertical;
			lines[3] = lines[3] + space + vertical;
			lines[4] = lines[4] + space + vertical;
			lines[5] = lines[5] + space + vertical;
			lines[6] = lines[6] + vertical;

			Console.Write(ulCorner + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal);
			Console.Write(" STATISTICS AFTER 6,000,000 ROLLS ");
			Console.WriteLine(horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + urCorner);
			for (int i = 0; i < 7; i++)
			{
				Console.WriteLine(lines[i]);
			}
			Console.WriteLine(llCorner + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + 
			                  horizontal + horizontal + horizontal+ horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + 
			                  horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal +
							  horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal +
							  horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal +
							  horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + horizontal + lrCorner);

		}

		public override byte Roll()
		{
			return GenerateStatistics(base.Roll());
		}

		public uint[] GetStatistics() { return this.numbers; }

	}
}
