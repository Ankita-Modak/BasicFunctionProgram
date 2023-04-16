using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram.Swap
{
    internal class SwapTwoNum
    {
        public void Swapnum()
        {
            int a, b, temp;

            Console.WriteLine("Enter the value of a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of b: ");
            b = int.Parse(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After swapping, the value of a is {a} and the value of b is {b}.");
        }
    }
}
