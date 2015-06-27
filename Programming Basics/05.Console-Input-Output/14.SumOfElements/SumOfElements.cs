using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SumOfElements
{
    static void Main()
    {
        string arrString = Console.ReadLine();
        string[] items = arrString.Split(' ');
        double[] arr = new double[items.Length];
        double total = 0;
        long maxValue = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = double.Parse(items[i]);
            maxValue = (long)arr.Max();
            total += arr[i];
        }
        double lastTotal = total - maxValue;
        if (lastTotal == maxValue)
        {
           Console.WriteLine("Yes, sum={0}", lastTotal);
        }
        else
        {
            double otherTotal = Math.Abs(total - 2 * maxValue);
            Console.WriteLine("No, diff={0}", otherTotal);
        }
    }
}
