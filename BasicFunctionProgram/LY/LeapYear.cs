using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram.LY
{
    internal class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Please enter a year:");

            string input = Console.ReadLine();

            int year;
            if (!int.TryParse(input, out year) || year < 1000 || year > 9999)
            {
                Console.WriteLine("Invalid input. Please enter a 4-digit year.");
                return;
            }

            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
    }
}
