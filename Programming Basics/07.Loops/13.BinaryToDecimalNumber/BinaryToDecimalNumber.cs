//Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. 
//The output should be a variable of type long. Do not use the built-in .NET functionality. 

using System;
class BinaryToDecimalNumber
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        long[] convertedValue = new long[binaryNumber.Length];
        char[] binaryNumberChar = binaryNumber.ToCharArray();
        double sum = 0;
        int powerIndex = binaryNumber.Length - 1;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            convertedValue[i] = (int)(binaryNumberChar[i] - '0');
            sum += (convertedValue[i] * Math.Pow(2, powerIndex));
            powerIndex--;
        }
        
        Console.WriteLine(sum);
    }
}