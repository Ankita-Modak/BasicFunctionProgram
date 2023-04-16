using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram.Even_Odd
{
    internal class EvenOdd
    {
        public void evenodd()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even.");
            }
            else
            {
                Console.WriteLine($"{num} is odd.");
            }
        }
    }
}
