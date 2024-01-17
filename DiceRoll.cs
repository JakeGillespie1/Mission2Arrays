using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Part2
{
    internal class DiceRoll
    {
        public int[] RollDice(int number)
        {
            /*Initialize the roll and the array to store the rolls*/
            System.Random rnd = new Random();
            int[] array = new int[11];

            /*Loop to simulate a roll and return the arry to be printed*/
            for (int i = 0; i < number; i++)
            {
                int randomInt = rnd.Next(2, 13);
                array[randomInt - 2]++;
            }

            return array;
        }
    }
}
