using System;
class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int temp = 0;
        Console.WriteLine("Before swapping -> {0}", a);
        Console.WriteLine("Before swapping -> {0}", b);
        Console.WriteLine();
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After swapping -> {0}", a);
        Console.WriteLine("After swapping -> {0}", b);
        Console.WriteLine();
    }
}

