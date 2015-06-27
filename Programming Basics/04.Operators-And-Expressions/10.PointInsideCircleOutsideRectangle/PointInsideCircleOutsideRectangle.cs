//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 

using System;
class Program
{
    static void Main()
    {

        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());
        decimal radius = 1.5m;
        
        if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= radius * radius && (y>1 && y<=2.5m && x > 0.5m && x<2.5m) )
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}