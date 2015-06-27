//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop. 
using System;
class SumOfSomeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] arr = new double[n];
        double total = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = double.Parse(Console.ReadLine());
            total += arr[i];
        }
        Console.WriteLine(total);
    }
}

