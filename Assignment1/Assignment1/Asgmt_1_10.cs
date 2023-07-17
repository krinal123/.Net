using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Asgmt_1_10
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();

            Console.WriteLine("Enter the word:");
            string word = Console.ReadLine();

            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Sentences containing the word '{0}':", word);
            foreach (string sentence in sentences)
            {
                if (sentence.Contains(word))
                {
                    Console.WriteLine(sentence.Trim());
                }

            }
            Console.ReadLine();

        }
    }
}
