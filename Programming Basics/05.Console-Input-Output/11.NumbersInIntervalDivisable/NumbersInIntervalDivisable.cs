﻿//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. 
using System;
class NumbersInIntervalDivisable
{
    static void Main()
    {
        int integerOne = int.Parse(Console.ReadLine());
        int integerTwo = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = integerOne; i <= integerTwo; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

