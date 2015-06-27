//We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) 
//that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. 

using System;
class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int bitValue = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        if (bitValue == 0)
        {
            int mask = ~(1 << position);
            int result = number & mask;
            Console.WriteLine(result);
        }
        else
        {
            int mask = 1 << position;
            int result = number | mask;
            Console.WriteLine(result);
        }
    }
}