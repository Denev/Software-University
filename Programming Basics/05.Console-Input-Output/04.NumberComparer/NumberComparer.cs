//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. 

using System;
class NumberComparer
{
    static void Main()
    {
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        decimal result = (firstNumber > secondNumber) ? firstNumber : secondNumber;
        Console.WriteLine(result);
    }
}

