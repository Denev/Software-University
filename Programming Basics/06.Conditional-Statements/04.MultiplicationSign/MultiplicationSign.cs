//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators. 

using System;
class MultiplicationSign
{
    static void Main()
    {
        decimal numberOne = decimal.Parse(Console.ReadLine());
        decimal numberTwo = decimal.Parse(Console.ReadLine());
        decimal numberThree = decimal.Parse(Console.ReadLine());
        char plus = '+';
        char minus = '-';
        int zero = 0;
        if (numberOne > 0 && numberTwo > 0 && numberThree > 0)
        {
            Console.WriteLine(plus);
        }
        else if (numberOne == 0 || numberTwo == 0 || numberThree == 0) 
        {
            Console.WriteLine(zero);
        }
        else if (numberOne < 0 && numberTwo > 0 && numberThree > 0)
        {
            Console.WriteLine(minus);
        }
        else if(numberOne > 0 && numberTwo < 0 && numberThree > 0)
        {
            Console.WriteLine(minus);
        }
        else if (numberOne > 0 && numberTwo > 0 && numberThree < 0)
        {
            Console.WriteLine(minus);
        }
        else if(numberOne < 0 && numberTwo < 0 && numberThree < 0)
        {
            Console.WriteLine(minus);
        }
        else if (numberOne > 0 && numberTwo < 0 && numberThree < 0)
        {
            Console.WriteLine(plus);
        }
        else if (numberOne < 0 && numberTwo < 0 && numberThree > 0)
        {
            Console.WriteLine(plus);
        }
        else if (numberOne < 0 && numberTwo > 0 && numberThree < 0)
        {
            Console.WriteLine(plus);
        }
    }
}

