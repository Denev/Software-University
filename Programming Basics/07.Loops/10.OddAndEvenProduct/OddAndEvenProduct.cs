/* You are given n integers (given in a single line, separated by a space). 
Write a program that checks whether the product of the odd elements is equal to the product of the even elements. 
Elements are counted from 1 to n, so the first element is odd, the second is even, etc. */

using System;
class OddAndEvenProduct
{
    static void Main()
    {
        int evenSum = 1;
        int oddSum = 1;
        string[] userInput = Console.ReadLine().Split();
        int i = 0;
        foreach (var item in userInput)
        {
            int input = Int32.Parse(userInput[i]);
            if (i % 2 != 0)
            {
                evenSum *= input;
            }
            else
            {
                oddSum *= input;
            }
            i++;

        }
        if (evenSum == oddSum)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", evenSum);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddSum);
            Console.WriteLine("even_product = {0}", evenSum);
        }
    }
}