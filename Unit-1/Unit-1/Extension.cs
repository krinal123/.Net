using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1
{
    internal class Extension
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the File Name: ");
            String s = Console.ReadLine();
            string result = s.Substring(s.LastIndexOf('.') + 1);
            Console.WriteLine("Your Extension is : " + result);
            Console.ReadLine();
        }
    }
}
