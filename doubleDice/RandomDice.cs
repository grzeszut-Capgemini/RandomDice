using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace doubleDice
{
	class RandomDice
	{
		Random randomDice1 = new Random();
		int dice1, dice2;
		int counter = 0;
		public void Dice()
		{
			do
			{
				dice1 = randomDice1.Next(1, 7);
				Thread.Sleep(1000);
				dice2 = randomDice1.Next(1, 7);
				Console.WriteLine($"First dice: {dice1}\nSecond dice: {dice2}\n");
				counter++;
			}
			while (dice1 + dice2 != 12);
			Console.WriteLine($"First dice = second dice, after {counter} attempts");
		}

	}
}
