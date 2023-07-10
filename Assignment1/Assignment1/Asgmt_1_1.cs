using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Asgmt_1_1
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Value of A : "); 
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of B : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of C : ");
            int c = Convert.ToInt32(Console.ReadLine()); 
            int sum = a + b + c;
            Console.WriteLine("Sum of all values is : " + sum);
            Console.Read();
        }
    }
}
