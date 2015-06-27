//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 

using System;
class Program
{
    static void Main()
    {
       
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            int radius = 2;
            bool check = true;
            if (x * x + y * y <= radius * radius)
            {
                Console.WriteLine(check);
            }
            else
            {
                check = false;
                Console.WriteLine(check);
            }

    }
}