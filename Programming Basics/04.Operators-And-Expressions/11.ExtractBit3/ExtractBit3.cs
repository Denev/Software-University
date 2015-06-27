//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 

using System;
class ExtractBit3
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine()); //Enter "3".
        Console.WriteLine((number >> position) & 1);
    }
    
}