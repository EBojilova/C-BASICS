using System;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        //string faxNumber = string.IsNullOrEmpty(faxNumberRead) ? "(no fax)" : faxNumberRead;
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel: +{0}", phoneNumber);
        if (faxNumber != "") 
        {
            Console.WriteLine("Fax: {0}", faxNumber);
        }
        else
        {
            Console.WriteLine("Fax: (no fax)");
        }
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}), tel. +{3}", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}

