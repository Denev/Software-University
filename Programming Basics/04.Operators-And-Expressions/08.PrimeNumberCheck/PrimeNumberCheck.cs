//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). 

using System;
class Program
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        bool isPrime = true;
        int counter = 1;
        if (numberN <= 1)
        {
            Console.WriteLine(!isPrime);
        }
        else 
        {
            while (counter <= Math.Sqrt(numberN))
            {
                if (numberN % counter == 0 && counter > 1)
                {
                    isPrime = false;
                }
                counter++;
            }
            Console.WriteLine(isPrime);
        }
    }
}
