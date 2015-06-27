//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, 
//age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.

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
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string companyWebSite = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhoneNumber = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("The company's name is {0}.\r\nIt is located on {1}.\r\nThe company's phone number is: {2}\r\nThe fax number is: {3}.\r\nWebiste: {4}\r\nThe manager's name is {5} {6} and he is {7} years old.\r\nHis phone number is: {8} ", 
                            companyName, companyAddress, companyPhoneNumber, companyFaxNumber, 
                            companyWebSite, managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}
