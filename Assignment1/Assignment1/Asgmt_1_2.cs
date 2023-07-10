using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Asgmt_1_2
    {
        static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter company information:");
                Console.Write("Name: ");
                string companyName = Console.ReadLine();
                Console.Write("Address: ");
                string companyAddress = Console.ReadLine();
                Console.Write("Phone number: ");
                string companyPhoneNumber = Console.ReadLine();
                Console.Write("Fax number: ");
                string companyFaxNumber = Console.ReadLine();
                Console.Write("Website: ");
                string companyWebsite = Console.ReadLine();

                Console.WriteLine("\nEnter manager information:");
                Console.Write("First name: ");
                string managerFirstName = Console.ReadLine();
                Console.Write("Last name: ");
                string managerLastName = Console.ReadLine();
                Console.Write("Age: ");
                int managerAge = Convert.ToInt32(Console.ReadLine());
                Console.Write("Phone number: ");
                string managerPhoneNumber = Console.ReadLine();

                Console.WriteLine("\nCompany Information:");
                Console.WriteLine("Name: " + companyName);
                Console.WriteLine("Address: " + companyAddress);
                Console.WriteLine("Phone number: " + companyPhoneNumber);
                Console.WriteLine("Fax number: " + companyFaxNumber);
                Console.WriteLine("Website: " + companyWebsite);
                Console.WriteLine("\nManager Information:");
                Console.WriteLine("First name: " + managerFirstName);
                Console.WriteLine("Last name: " + managerLastName);
                Console.WriteLine("Age: " + managerAge);
                Console.WriteLine("Phone number: " + managerPhoneNumber);

                Console.WriteLine("\nDo you want to enter another company? (Y/N)");
                string continueInput = Console.ReadLine();
                if (!continueInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
