//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 
using System;
class SumOfFiveNumbers
{
    static void Main()
    {
        string arrString = Console.ReadLine();
        string[] items = arrString.Split(' ');
        double[] arr = new double[items.Length];
        double total = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = double.Parse(items[i]);
            total += arr[i];
        }
        Console.WriteLine(total);
    }
}

