//The gravitational field of the Moon is approximately 17% of that on the Earth. 
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth. 

using System;
class Program
{
    static void Main()
    {
        Console.Write("Your weight on Earth: ");
        decimal weightOnEarth = decimal.Parse(Console.ReadLine());
        decimal weightOnMoon = (17 * weightOnEarth) / 100;
        Console.WriteLine("Your weight on the moon is: {0}", weightOnMoon);
    }
}