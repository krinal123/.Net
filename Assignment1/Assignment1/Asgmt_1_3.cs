using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Asgmt_1_3
    { 
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Value of A : "); 
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of B : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            for (int i = a; i <= b; i++)
            {
                if(i % 5 == 0)
                {
                    ans++;
                }
            }
            Console.WriteLine("Remainder of Count is : " + ans);
            Console.Read();
        }
    }
}
