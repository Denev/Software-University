using System;
using System.Linq;
using System.Collections.Generic;
class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        System.Random rnd = new System.Random();
        var numbers = Enumerable.Range(1, n).OrderBy(r => rnd.Next()).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine((33 / 16) % 16);
    }
}