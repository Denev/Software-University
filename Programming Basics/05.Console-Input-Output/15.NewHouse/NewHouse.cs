using System;
class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int zero = 0;
        int one = 1;
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', n/2 - zero), new string('*', one));
            zero += 1;
            one += 2;
        }
        Console.WriteLine("{0}", new string('*', n));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("|{0}|", new string('*', n-2));
        }
    }
}

