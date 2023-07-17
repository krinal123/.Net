using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Asgmt_1_7
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your String : ");
            string str = Console.ReadLine(); 
            string ans = string.Join("",str.Reverse()); 
            Console.WriteLine("Now your String is : " + ans);
            Console.Read();
        }
    }
}
