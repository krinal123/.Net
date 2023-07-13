using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Asgmt_1_6
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Range : ");
            int n = Convert.ToInt32(Console.ReadLine()); 
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Number is : " + i);
            }
            Console.Read();
        }
    }
}
