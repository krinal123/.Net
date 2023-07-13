using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Asgmt_1_8
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String : ");
            string input = Console.ReadLine();
            string output = TransformText(input);
            Console.WriteLine(output);
        }
        static string TransformText(string input)
        {
            string pattern = "<upcase>(.*?)</upcase>";
            string output = Regex.Replace(input, pattern, match => match.Groups[1].Value.ToUpper());
            return output;
            Console.Read();
        }
    }
}
