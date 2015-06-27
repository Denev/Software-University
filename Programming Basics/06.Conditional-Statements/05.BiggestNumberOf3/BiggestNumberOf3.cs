//Write a program that finds the biggest of three numbers. 

using System;
using System.Linq;
class BiggestNumberOf3
{
    static void Main()
    {
        decimal[] numbers = new decimal[3];
        numbers[0] = decimal.Parse(Console.ReadLine());
        numbers[1] = decimal.Parse(Console.ReadLine());
        numbers[2] = decimal.Parse(Console.ReadLine());
        decimal maxValue = numbers.Max();
        Console.WriteLine(maxValue);
    }
}
