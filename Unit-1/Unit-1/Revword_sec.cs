using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1
{
    internal class Revword_sec
    {
        public static void Main()
        {
            Console.Write("Enter the String : "); 
            string str = Console.ReadLine();
            string ans = string.Join(" ",str.Split(' ').Reverse());
            Console.Write("Reversed String: " + ans);
            Console.WriteLine();

        }
    }
}
n