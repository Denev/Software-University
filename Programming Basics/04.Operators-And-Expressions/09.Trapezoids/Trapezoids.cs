//Write an expression that calculates trapezoid's area by given sides a and b and height h. 

using System;
class Trapezoids
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal h = decimal.Parse(Console.ReadLine());
        Console.WriteLine((a+b)*h/2);
    }
}