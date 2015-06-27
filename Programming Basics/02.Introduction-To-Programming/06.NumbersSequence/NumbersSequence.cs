using System;
    class NumbersSequence
    {
        static void Main()
        {
            int n = 2;
            for (int i = 0; i < 10; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
                else Console.WriteLine(-n);
                n++;
            }
        }
    }

