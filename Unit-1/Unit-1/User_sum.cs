using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1
{
    internal class User_sum
    {
        static void Main()
        {
            Console.WriteLine("Enter the Desire Number to Sum:"); 
            int dsum = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0; 
            while (sum < dsum)
            {
                Console.WriteLine("Enter the Numbers:"); 
                int num = Convert.ToInt32(Console.ReadLine()); 
                sum += num; 
                count++;
            }
            Console.WriteLine("Sum reached : "+ sum);
            Console.WriteLine("Number of Inputs : "+ count);
            Console.WriteLine();
            
        }
    }
}
