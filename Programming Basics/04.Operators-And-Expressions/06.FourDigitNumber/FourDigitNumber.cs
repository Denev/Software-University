/* Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
•	Prints on the console the number in reversed order: dcba (in our example 1102).
•	Puts the last digit in the first position: dabc (in our example 1201).
•	Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0. 
*/

using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int notTouchedNumber = number;
        int keepNumber = number;
        int keepNumberOne = number;
        int keepNumberTwo = number;

        int sum = 0;
        while (number != 0) {
            sum += (number % 10);
            number /= 10;
        }
        Console.WriteLine("The sum of the digits of {0} is {1}.", notTouchedNumber, sum);

        string reversedNumber = "";
        int lastSymbol = 0;
        while (keepNumber != 0)
        {
            lastSymbol = (keepNumber % 10);
            lastSymbol.ToString();
            reversedNumber = reversedNumber + lastSymbol;
            keepNumber /= 10;
        }
        Console.WriteLine("The number {0} in reversed order is: {1}.",notTouchedNumber, reversedNumber);

        int lastDigit = keepNumberOne % 10;
        keepNumberOne /= 10;
        string lastDigitString = lastDigit.ToString();
        string keepNumberOneString = keepNumberOne.ToString();
        Console.WriteLine("The number {0} with last digit in first place is: {1}",notTouchedNumber, lastDigitString + keepNumberOneString);

        int secondDigit = (keepNumberTwo / 10) % 10;
        int thirdDigit = (keepNumberTwo / 100) % 10;
        string keepNumberTwoString = keepNumberTwo.ToString();
        char[] numberString = keepNumberTwoString.ToCharArray();
        char temp = ' ';
        temp = numberString[1];
        numberString[1] = numberString[2];
        numberString[2] = temp;
        string result = new string(numberString);
        Console.WriteLine("The number {0} with 2nd and 3rd digits exchanged is: {1}.", notTouchedNumber, result);
    }
}