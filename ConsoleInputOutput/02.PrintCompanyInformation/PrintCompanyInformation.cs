//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console
using System;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter fax");
        string fax = Console.ReadLine();
        bool bFax = fax != "";
        Console.WriteLine("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter web site :");
        string webSite = Console.ReadLine();
        bool bwebSite = webSite != "";
        Console.WriteLine("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Enter manager last name: ");
        string managertLastName = Console.ReadLine();
        Console.WriteLine("Enter manager age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine(bFax ? "Fax: " + fax : "Fax: (no fax)");
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine(bwebSite? "Web site: " + webSite : "Web site: (no web site)");
        Console.WriteLine("Manager: {0} {1} (age: {2} tel. {3}",managerFirstName, managertLastName, age, managerPhone);
        Console.WriteLine("-------------------------");
      }
}

