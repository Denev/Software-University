//Write a program that finds the biggest of five numbers by using only five if statements. 

using System;
using System.Linq;
class BiggestNumberOf5
{
    static void Main()
    {
        decimal numberOne = decimal.Parse(Console.ReadLine());
        decimal numberTwo = decimal.Parse(Console.ReadLine());
        decimal numberThree = decimal.Parse(Console.ReadLine());
        decimal numberFour = decimal.Parse(Console.ReadLine());
        decimal numberFive = decimal.Parse(Console.ReadLine());

        if (numberOne > numberTwo && numberOne > numberThree && numberOne > numberFour && numberOne > numberFive)
        {
            Console.WriteLine(numberOne);
        }
        else if (numberTwo > numberOne && numberTwo > numberThree && numberTwo > numberFour && numberTwo > numberFive)
        {
            Console.WriteLine(numberTwo);
        }
        else if (numberThree > numberTwo && numberThree > numberOne && numberThree > numberFour && numberThree > numberFive)
        {
            Console.WriteLine(numberThree);
        }
        else if (numberFour > numberTwo && numberFour > numberThree && numberFour > numberOne && numberFour > numberFive)
        {
            Console.WriteLine(numberFour);
        }
        else if (numberFive > numberTwo && numberFive > numberThree && numberFive > numberFour && numberFive > numberOne)
        {
            Console.WriteLine(numberFive);
        }
    }
}

