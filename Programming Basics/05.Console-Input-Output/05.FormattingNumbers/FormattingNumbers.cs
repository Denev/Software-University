﻿//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. 
//Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes,
//then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. 

using System;
class FormattingNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        string firstNumberHex = firstNumber.ToString("X");
        string firstNumberBinary = Convert.ToString(firstNumber, 2);
        
        char zero = '0';
        char blankSpace = ' ';
        string secondNumberString = secondNumber.ToString();
        string thirdNumberString = thirdNumber.ToString();

        secondNumberString = String.Format("{0:0.00}", secondNumber);
        thirdNumberString = String.Format("{0:0.000}", thirdNumber);

        Console.WriteLine("|{0}|{1}|{2}|{3}|", firstNumberHex.PadRight(10, blankSpace),  
            firstNumberBinary.PadLeft(10, zero), secondNumberString.PadLeft(10, blankSpace),
            thirdNumberString.PadRight(10, blankSpace));
    }
}

