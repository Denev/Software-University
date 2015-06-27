/*
Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers 
(displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
The output is like in the examples below. */

using System;
using System.Linq;
class MinMaxSumAverage
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[number]; //We create an array where to put the numbers
        int sum = 0;
        
        for (int i = 0; i < arrayOfNumbers.Length; i++) 
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            sum += arrayOfNumbers[i]; //We add the numbers to the sum
        }
        int minValue = arrayOfNumbers.Min(); //We get the min value in the array using the function Min();
        int maxValue = arrayOfNumbers.Max(); //We get the max value in the array using the function Max();
        double average = arrayOfNumbers.Average(); //We get the average value in the array using the function Average();
        Console.WriteLine("The min number is: {0}", minValue);
        Console.WriteLine("The max number is: {0}", maxValue);
        Console.WriteLine("The sum is: {0}", sum);
        Console.WriteLine("The average is: {0:F2}", average);
    }
}