using System;
namespace Assignment4
{
	public class DLXDice : Dice
	{
		protected uint[] numbers = new uint[6];

		public uint[] GetStatistics() { return this.numbers; };

		public DLXDice()
		{
			
		}
	}
}
