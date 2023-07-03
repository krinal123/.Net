using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1
{
    internal class Revword_sec
    {
        public static void Main()
        {
            Console.Write("Enter the String : "); 
            string str = Console.ReadLine();
            string[] s =str.Split(' ');
            string ans = "";
            for (int i = s.Length - 1;i >= 0; i--)
            {
                ans += s[i] + " ";
            }
            Console.Write("Reversed String: ");
            Console.Write(ans.Substring(0,ans.Length - 1)); 
            Console.WriteLine();

        }
    }
}
