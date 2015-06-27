//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. 

using System;
class ExchangeIfGreater
{
    static void Main()
    {
        decimal variableOne = decimal.Parse(Console.ReadLine());
        decimal variableTwo = decimal.Parse(Console.ReadLine());
        if (variableOne > variableTwo)
        {
            decimal temp = 0;
            temp = variableOne;
            variableOne = variableTwo;
            variableTwo = temp;
            Console.WriteLine("{0} {1}", variableOne, variableTwo);
        }
        else
        {
            Console.WriteLine("{0} {1}", variableOne, variableTwo);
        }
    }
}