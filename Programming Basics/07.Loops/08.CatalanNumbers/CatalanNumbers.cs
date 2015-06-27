/* In combinatorics, the Catalan numbers are calculated by the following formula: (no image)
Write a program to calculate the nth Catalan number by given n (1 < n < 100). */ 

using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        long n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            n = 1;
        }
        long multipliedN = n * 2;
        long nPlusOne = n + 1;
        BigInteger factN = new BigInteger(1);
        BigInteger factNMultiplied = new BigInteger(1);
        BigInteger factorialNPlusOne = new BigInteger(1);
        while (n != 1)
        {
            factN *= n;
            n--;
        }
        while (multipliedN != 1)
        {
            factNMultiplied *= multipliedN;
            multipliedN--;
        }
        while (nPlusOne != 1) 
        {
            factorialNPlusOne *= nPlusOne;
            nPlusOne--;
        }
        Console.WriteLine(factNMultiplied / (factorialNPlusOne * factN));
        
    }
}