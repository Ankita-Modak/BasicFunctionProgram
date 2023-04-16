using System;
using BasicFunctionProgram.FC1;
using BasicFunctionProgram.LY;

namespace BasicFunctionProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Flip Coin and print percentage of Heads and Tails");
            Console.WriteLine("2. Check if a year is a Leap Year");

            string input = Console.ReadLine();

            switch (input)
            {
                //to flip a coin 
                case "1":
                    Flip flip = new Flip();
                    flip.FlipCoin();
                    break;
                case "2":
                    LeapYear leap = new LeapYear();
                    leap.CheckLeapYear();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please select either 1 or 2.");
                    break;
            }
        }

        

        
    }
}