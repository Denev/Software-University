//Using loops write a program that converts an integer number to its binary representation. The input is entered as long.
//The output should be a variable of type string. Do not use the built-in .NET functionality. 

using System;
using System.Globalization;
class DecimalToBinaryNumber
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long saveNumber = number;
        int counter = 0;
        while (number > 0)
        {
            number /= 2;
            counter++;
        }
        long[] remainder = new long[counter];
        for (int i = 0; i < counter; i++)
        {
            remainder[i] = saveNumber % 2;
            saveNumber /= 2;
        }
        long other = remainder.Length - 1;
        for (; other >= 0; other--)
        {
            Console.Write(remainder[other] + " ");
        }
        Console.WriteLine();
    }
}