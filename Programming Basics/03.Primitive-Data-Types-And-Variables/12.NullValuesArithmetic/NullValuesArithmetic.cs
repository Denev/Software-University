using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? firstNumber = null;
        double? secondNumber = null;

        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);

        Console.WriteLine(firstNumber + 2);
        Console.WriteLine(secondNumber + 1.6);

        firstNumber = 11;
        secondNumber = 1.5;
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
    }
}

