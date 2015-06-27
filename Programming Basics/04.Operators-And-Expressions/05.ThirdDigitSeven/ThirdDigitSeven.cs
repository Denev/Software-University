//Write an expression that checks for given integer if its third digit from right-to-left is 7. 

using System;
class Program
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        bool check = true;
        if ((number / 100) % 10 == 7)
        {
            Console.WriteLine(check);
        }
        else
        {
            Console.WriteLine(!check);
        }
    }
}