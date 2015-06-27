//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. 
using System;
class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int numberOne = 0;
        int numberTwo = 1;
        if (n == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.Write("{0} {1}", numberOne, numberTwo);
            for (int i = 2; i < n; i++)
            {
                int numberThree = numberOne + numberTwo;
                Console.Write(" {0} ", numberThree);
                numberOne = numberTwo;
                numberTwo = numberThree;
            }
        }
        Console.WriteLine();
    }
}

