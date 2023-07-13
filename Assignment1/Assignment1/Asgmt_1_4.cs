using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Asgmt_1_4
    { 
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Value of A : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of B : ");
            int b = Convert.ToInt32(Console.ReadLine()); 
            if(a >= b)
            {
                Console.WriteLine("A is Greater");
            } 
            else
            {
                Console.WriteLine("B is Greater");
            }
            Console.Read();
            
        }
    }
}
