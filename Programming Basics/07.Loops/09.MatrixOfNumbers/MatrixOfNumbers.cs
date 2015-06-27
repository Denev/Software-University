//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. 

using System;
class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int adder = 1;
        int adderPlusOne = 2;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(adder + " ");
                adder++;
            }
            adder = adderPlusOne;
            adderPlusOne++;
            Console.WriteLine();
        }
    }
}