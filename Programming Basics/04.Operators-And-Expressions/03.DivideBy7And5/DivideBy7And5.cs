//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. 

using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool check = true;
        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine(check);            
        }
        else
        {
            Console.WriteLine(!check);
        }
    }
}