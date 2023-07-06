using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1
{
    internal class Rem_count
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of A : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of B : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int ans = 0; 
            for(int i=a; i <= b; i++)
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
