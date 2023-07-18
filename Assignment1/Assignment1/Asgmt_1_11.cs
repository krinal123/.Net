using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Asgmt_1_11
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine();

            Console.WriteLine("Enter the forbidden words separated by spaces: ");
            string[] forbiddenWords = Console.ReadLine().Split(' ');

            foreach (string forbiddenWord in forbiddenWords)
            {
                text = text.Replace(forbiddenWord, new string('*', forbiddenWord.Length), StringComparison.OrdinalIgnoreCase);
            }
            Console.WriteLine("Output is : " + text);
            Console.Read();
        }
    }
}
