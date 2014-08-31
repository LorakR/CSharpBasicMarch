/*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.*/

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax: ");
        string faxNumber = Console.ReadLine();
        //if the user has not entered any info and the string is empty
        if (faxNumber == "")
        {
            faxNumber = "(no fax)";
        }
        Console.Write("Website: ");
        string website = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone number: ");
        string managerPhone = Console.ReadLine();
        //empty line for better visualisation
        Console.WriteLine();
        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}",companyName,companyAddress,phoneNumber);
        Console.WriteLine("Fax: {0}\nWeb site: {1}\nManager: {2} {3} (age: {4}, tel. {5})",faxNumber,website,managerFirstName,managerLastName,managerAge,managerPhone);
    }
}

