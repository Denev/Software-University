//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 

using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        decimal r = decimal.Parse(Console.ReadLine());
        double pi = Math.PI;
        decimal perimeter = (decimal)pi * 2 * r;
        decimal area = (decimal)pi * r * r;
        Console.WriteLine("The perimeter is: {0:F2}", perimeter);
        Console.WriteLine("The area is: {0:F2}", area);
    }
}

