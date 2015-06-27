//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
class SumOfThreeNumbers
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal total = a + b + c;
        Console.WriteLine(total);
    }
}

