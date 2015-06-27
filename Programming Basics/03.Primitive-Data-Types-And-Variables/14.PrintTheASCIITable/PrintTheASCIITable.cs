using System;
class PrintTheASCIITable
{
    static void Main()
    {
        char character = '\u0000';
        for (int i = 0; i < 255; i++)
        {
            Console.WriteLine("Number {0}: {1}", i,character);
            character++;
        }
    }
}

