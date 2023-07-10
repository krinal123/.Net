using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Asgmt_1_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter number {0}:", i);
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine("Sum: " + sum);

            Console.WriteLine("Do you want to add more numbers? (Y/N)");
            string choice = Console.ReadLine();

            while (choice.ToUpper() == "Y")
            {
                Console.WriteLine("Enter the number:");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;

                Console.WriteLine("Sum: " + sum);

                Console.WriteLine("Do you want to add more numbers? (Y/N)");
                choice = Console.ReadLine();
            }
        }


    }
}
