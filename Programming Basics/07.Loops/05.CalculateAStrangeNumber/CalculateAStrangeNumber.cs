//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits after the decimal point.

using System;
class CalculateAStrangeNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        int number = 1;
        int fact = 1;
        double xPowered = 0;
        for (int i = 1; i <= n; i++)
        {
            fact *= number; 
            number++;
            xPowered = Math.Pow(x, i);
            sum += fact/xPowered;
        }
        Console.WriteLine("{0:F5}", sum);
    }
}