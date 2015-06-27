/* 
In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: (no image)
For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.  */

using System;
using System.Numerics;
class Combinations
{
    static void Main()
    {
        
        long n = long.Parse(Console.ReadLine());
        long k = long.Parse(Console.ReadLine());
        long keepN = n;
        long keepK = k;
        BigInteger factN = new BigInteger(1);
        BigInteger factK = new BigInteger(1);
        BigInteger factNandK = new BigInteger(1);
        while (n != 1)
        {
            factN *= n;
            factK *= k;
            n--;
            k--;
            if (k <= 0)
            {
                k = 1;
            }
        }
        for (int i = 1; i <= keepN - keepK; i++)
        {
            factNandK *= i;
        }
        Console.WriteLine(factN / (factK * factNandK));
    }
}