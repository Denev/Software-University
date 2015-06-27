//Write an expression that extracts from given integer n the value of given bit at index p. 

using System;
class ExtractBitFromInteger
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine((number >> position) & 1);
    }
}