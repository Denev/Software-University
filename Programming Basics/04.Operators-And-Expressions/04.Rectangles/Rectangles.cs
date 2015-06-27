//Write an expression that calculates rectangle’s perimeter and area by given width and height. 

using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter width: ");
        decimal width = decimal.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        decimal height = decimal.Parse(Console.ReadLine());

        decimal perimeter = width * 2 + height * 2;
        decimal area = width * height;

        Console.WriteLine("\r\nThe Perimeter is: {0}", perimeter);
        Console.WriteLine("The Area is: {0}", area);
    }
}