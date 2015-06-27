using System;
class EmployeeData
{
    static void Main()
    {
        Console.Write("First name: ");
        string firstName = Console.ReadLine();

        Console.Write("Last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Gender (m or f): ");
        string gender = Console.ReadLine();

        Console.Write("Personal Number: ");
        long personalNumber = long.Parse(Console.ReadLine());

        Console.Write("Unique Employee Number: ");
        long employeeNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("\r\nName: {0} {1}", firstName, lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal number: {0}", personalNumber);
        Console.WriteLine("Employee number: {0}", employeeNumber);
    }
}

