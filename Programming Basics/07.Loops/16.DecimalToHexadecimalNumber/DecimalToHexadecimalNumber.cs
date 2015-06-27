using System;
class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long saveNumber = number;
        int counter = 0;
        while (number > 0)
        {
            number /= 16;
            counter++;
        }
        string[] remainderArray = new string[counter];
        long remainder = 0;
        for (int i = 0; i < counter; i++)
        {
            remainder = saveNumber % 16;
            switch (remainder)
            {
                case 10:
                    remainderArray[i] = "A";
                    break;
                case 11:
                    remainderArray[i] = "B";
                    break;
                case 12:
                    remainderArray[i] = "C";
                    break;
                case 13:
                    remainderArray[i] = "D";
                    break;
                case 14:
                    remainderArray[i] = "E";
                    break;
                case 15:
                    remainderArray[i] = "F";
                    break;

                default: remainderArray[i] = remainder.ToString();
                    break;
            }
            saveNumber /= 16;
        }
        for (int i = remainderArray.Length - 1; i >= 0; i--)
        {
            Console.Write(remainderArray[i]);
        }
        Console.WriteLine();
    }
}