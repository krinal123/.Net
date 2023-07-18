using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Asgmt_1_13
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String : "); 
            string str = Console.ReadLine();
            string ans = string.Join(" ",str.Split(' ').Reverse()); 
            Console.WriteLine("Reverse String is : " + ans);
            Console.Read();
        }
    }
}
