using System;
class BinaryToDecimalNumber
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        long[] convertedValue = new long[binaryNumber.Length];
        char[] binaryNumberChar = binaryNumber.ToCharArray();
        double sum = 0;
        int powerIndex = binaryNumber.Length - 1; //110 -> 
        //int i = (int)(c - '0');
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            convertedValue[i] = (int)(binaryNumberChar[i] - '0');
            sum += (convertedValue[i] * Math.Pow(2, powerIndex));
            powerIndex--;
        }
        
        Console.WriteLine(sum);
    }
}