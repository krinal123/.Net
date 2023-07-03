using System;

namespace Unit_1
{
    internal class CaseConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string: ");
            string str = Console.ReadLine();

            string convertedStr = string.Join("", str.Select(ch => char.IsLower(ch) ? char.ToUpper(ch) : char.ToLower(ch)));

            Console.WriteLine("Converted string: " + convertedStr);
            Console.Read();
        }
    }
}
