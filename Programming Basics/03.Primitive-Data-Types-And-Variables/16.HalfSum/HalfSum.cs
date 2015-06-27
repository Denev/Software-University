using System;
class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstSequence = new int[n];
        int[] secondSequence = new int [n];
        int totalFirstSequence = 0;
        int totalSecondSequence = 0;
        int m = 0;
        for (int i = 0; i < n; i++)
        {
            firstSequence[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            secondSequence[i] = int.Parse(Console.ReadLine());
        }

        foreach (var item in firstSequence)
        {
            m++;
            totalFirstSequence += item;
        }

        m = 0;

        foreach (var item in secondSequence)
        {
            m++;
            totalSecondSequence += item;
        }
        
        int ifDifference = Math.Abs(totalFirstSequence - totalSecondSequence);
        if (totalFirstSequence == totalSecondSequence)
        {
            Console.WriteLine("Yes, sum={0}", totalFirstSequence);
        }
        else Console.WriteLine("No, diff={0}", ifDifference);
          
    }
}

