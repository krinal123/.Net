using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1
{
    internal class Sum
    { 
        public static Main(string[] args)
        {
            Console.Write("Enter the Value of A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Value of B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.Write("Sum of Two Numbers is: " + sum);
            Console.ReadLine();
        }
    }
}
