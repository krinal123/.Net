using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Asgmt_1_9
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your String : "); 
            string input = Console.ReadLine();
            if (input.Length > 20)
            {
                input = input.Substring(0, 20);
            }
            else if (input.Length < 20)
            {
                input = input.PadRight(20, '*');
            }
            Console.WriteLine("Result is : " + input);
            Console.Read();
        }
    }
}
