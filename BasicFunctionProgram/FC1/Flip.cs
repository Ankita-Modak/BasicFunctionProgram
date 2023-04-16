using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram.FC1
{
    internal class Flip
    {
        public void FlipCoin()
        {
            Console.WriteLine("Please enter the number of times to flip the coin:");
            string input = Console.ReadLine();

            int flips;
            if (!int.TryParse(input, out flips) || flips <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            int heads = 0;
            int tails = 0;

            Random rand = new Random();
            for (int i = 0; i < flips; i++)
            {
                int result = rand.Next(2);
                if (result == 0)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }

            double headsPercent = (double)heads / flips * 100;
            double tailsPercent = (double)tails / flips * 100;

            Console.WriteLine($"Heads: {heads} ({headsPercent}%)");
            Console.WriteLine($"Tails: {tails} ({tailsPercent}%)");
        }
    }
}
