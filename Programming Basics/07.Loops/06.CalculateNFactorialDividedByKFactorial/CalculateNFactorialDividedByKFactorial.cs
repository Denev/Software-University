//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 

using System;
class CalculateNFactorialDividedByKFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int resultN = 1;
        int resultK = 1;
        while (n != 1)
        {
            resultN *= n;
            resultK *= k;
            n--;
            k--;
            if (k <= 0)
            {
                k = 1;
            }
        }
        Console.WriteLine(resultN/resultK);
    }
}