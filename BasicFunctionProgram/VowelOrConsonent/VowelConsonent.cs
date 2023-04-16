using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionProgram.VowelOrConsonent
{
    internal class VowelConsonent
    {
        public void VowCos()
        {
            Console.WriteLine("Enter an alphabet: ");
            char ch = Console.ReadLine().ToLower()[0];

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine($"{ch} is a vowel.");
            }
            else
            {
                Console.WriteLine($"{ch} is a consonant.");
            }
        }
    }
}
