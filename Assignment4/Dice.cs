/*
***********************************************************************************************************************
Author	: Robson Miranda (stra0165)
Date	: 04/01/2017
Comments: Base Class Dice
***********************************************************************************************************************
*/

//using is a reserved word that imports external libraries into the code
using System;

namespace Assignment4
{
	public class Dice
	{
		protected byte value;
		private Random random;

		public Dice() //Default Constructor
		{
			value = 1;
			random = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber)); // seed it!
			//Guid, as the name says, is a global unique identifier that can be used across all computers and networks
			//Random is a class that generates random sequences of numbers to meet statistics pourposes.
			//ToString is a Static Method that converts a set of chars into string.
			//int.Parse converts a set of chars that represents a number into a number.
		}
	
		public Dice(byte value) //Overload Constructor
		{
			//this is a reserved word that provides access to every attribute or method the class has.
			this.value = value;
			random = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber)); // seed it!
		}

		public virtual void Draw()
		{
			Console.WriteLine("You've got " + this.value);
		}

		public virtual byte Roll()
		{
			//Convert is a class that encapsule Static Method to handle conversion of different types in C#
			this.value = Convert.ToByte(random.Next(1, 7));
			return this.value;
		}

		public byte GetByte() { return value; }
	}
}
