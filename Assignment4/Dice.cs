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
		}
	
		public Dice(byte value) //Overload Constructor
		{
			this.value = value;
			random = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber)); // seed it!
		}

		public void Draw()
		{
			Console.WriteLine(this.value);
		}

		public byte Roll()
		{
			//this.value = (byte) random.Next(1,7);
			this.value = Convert.ToByte(random.Next(1, 7));
			return this.value;
		}

		public byte GetByte() { return value; }
	}
}
