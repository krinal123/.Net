using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1
{
    internal class Case_Rev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string: ");
            string str = Console.ReadLine();

            string convertedStr = string.Join("", str.Select(ch => char.IsLower(ch) ? char.ToUpper(ch) : char.ToLower(ch)));
            string ans = string.Join(" ", convertedStr.Split(' ').Reverse());

            Console.WriteLine("Converted string: " + ans);
            Console.Read();
        }
    }
}
