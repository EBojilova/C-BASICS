using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02PrintCompanyInformation
{
    class Problem02PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Company phone number: ");
            int companyPhoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Company fax number: ");
            int companyFaxNumber = int.Parse(Console.ReadLine());
            Console.Write("Company web site: ");
            string companyWebSite = Console.ReadLine();
            Console.Write("Manager: ");
            string companyManager = Console.ReadLine();

            Console.Clear();

            
            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            int managerAge = int.Parse(Console.ReadLine());
            Console.Write("Manager phone number: ");
            int managerPhoneNumber = int.Parse(Console.ReadLine());

            Console.Clear();

          
            Console.WriteLine("Company Information");
            Console.WriteLine("Name: " + companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Phone number: " + companyPhoneNumber);
            Console.WriteLine("Fax number: " + companyFaxNumber);
            Console.WriteLine("Web site: " + companyWebSite);
            Console.WriteLine("Manager: " + companyManager);
            Console.WriteLine();
            Console.WriteLine("Manager Information");
            Console.WriteLine("First name: " + managerFirstName);
            Console.WriteLine("Last name: " + managerLastName);
            Console.WriteLine("Age: " + managerAge);
            Console.WriteLine("Phone number: " + managerPhoneNumber);
        }
    }
}
