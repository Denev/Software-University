//Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. 
//The output should be a variable of type long. Do not use the built-in .NET functionality. 

using System;
class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        char[] hexNumberChar = hexNumber.ToCharArray();
        double sum = 0;
        int powerIndex = hexNumberChar.Length - 1;
        for (int i = 0; i < hexNumberChar.Length; i++)
        {

            long hex = (int)(hexNumberChar[i] - '0');
            switch (hexNumberChar[i])
            {
                case 'A':
                    hex = 10;
                    sum += (hex * Math.Pow(16, powerIndex));
                    break;
                case 'B':
                    hex = 11;
                    sum += (hex * Math.Pow(16, powerIndex));
                    break;
                case 'C':
                    hex = 12;
                    sum += (hex * Math.Pow(16, powerIndex));
                    break;
                case 'D':
                    hex = 13;
                    sum += (hex * Math.Pow(16, powerIndex));
                    break;
                case 'E':
                    hex = 14;
                    sum += (hex * Math.Pow(16, powerIndex));
                    break;
                case 'F':
                    hex = 15;
                    sum += (hex * Math.Pow(16, powerIndex));
                    break;

                default:
                    sum += (hex * Math.Pow(16, powerIndex));
                    break;
            }
            powerIndex--;
        }
        Console.WriteLine(sum);
    }
}