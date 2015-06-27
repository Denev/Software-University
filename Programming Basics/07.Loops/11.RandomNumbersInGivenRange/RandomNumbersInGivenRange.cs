//Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. 

using System;
class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int minNumber = int.Parse(Console.ReadLine());
        int maxNumber = int.Parse(Console.ReadLine());
        maxNumber += 1; 
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            int randomNumber = rnd.Next(minNumber, maxNumber);
            Console.WriteLine(randomNumber);
        }
        Main();
    }
}