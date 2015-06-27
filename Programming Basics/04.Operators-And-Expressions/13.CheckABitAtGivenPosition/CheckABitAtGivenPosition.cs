//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. 

using System;
class CheckABitAtGivenPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int fixedBitNumber = 1;
        bool check = true;
        if (((number >> position) & 1) == fixedBitNumber)
        {
            Console.WriteLine(check);
        }
        else
        {
            Console.WriteLine(!check);
        }
    }
}