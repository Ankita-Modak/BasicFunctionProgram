using System;
using BasicFunctionProgram.Even_Odd;
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
            Console.WriteLine("3. Check if number is even or odd");

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

                case "3":
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.evenodd();
                    break;

                default:
                    Console.WriteLine("Invalid input. Please select either 1 or 2.");
                    break;
            }
        }

        

        
    }
}