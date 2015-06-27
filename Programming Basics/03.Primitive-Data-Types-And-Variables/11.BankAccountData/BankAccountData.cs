using System;
class BankAccountData
{
    static void Main()
    {
        Console.Write("First name: ");
        string firstName = Console.ReadLine();

        Console.Write("Middle name: ");
        string middleName = Console.ReadLine();

        Console.Write("Last name: ");
        string LastName = Console.ReadLine();

        Console.Write("Current balance: ");
        decimal balance = decimal.Parse(Console.ReadLine());

        Console.Write("Bank name: ");
        string bankName = Console.ReadLine();

        Console.Write("IBAN: ");
        string IBAN = Console.ReadLine(); //"BG80BNBG96611020345678";

        Console.Write("First credit card number: ");
        string creditCardOne = Console.ReadLine(); //It doesn't matter whether the value of the credit cards is string, because we can always convert the value to integer

        Console.Write("Second credit card number: ");
        string creditCardTwo = Console.ReadLine();

        Console.Write("Third credit card number: ");
        string creditCardThree = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Thank you for entering your data!");
        Console.WriteLine();
    }
}
