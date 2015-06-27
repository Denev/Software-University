//Write an expression that checks if given integer is odd or even. 

using System;
class OddOrEvenIntegers
{
    static void Main()
    {
        long number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("False");    
        }
        else
        {
            Console.WriteLine("True");
        }
        //or this solution: 

        //if (number % 2 == 0)
        //{
        //    Console.WriteLine("Number {0} is an even number.", number);            
        //}
        //else
        //{
        //    Console.WriteLine("Number {0} is an odd number.", number);
        //}
    }
}