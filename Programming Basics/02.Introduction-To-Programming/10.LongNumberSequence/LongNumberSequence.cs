using System;
class NumbersSequence
{
    static void Main()
    {
        int n = 2;
        for (int i = 0; i < 1000; i++)
        {
            if (n % 2 == 0)
            {
                Console.Write(n + "  ");
            }
            else Console.Write(-n + "  ");
            n++;
        }
    }
}

