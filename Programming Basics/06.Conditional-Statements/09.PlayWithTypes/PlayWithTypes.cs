//Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. 

using System;
class PlayWithTypes
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int userInput = int.Parse(Console.ReadLine());
        switch (userInput)
        {
            case 1:
                Console.WriteLine("Please enter an integer:");
                int integerInput = int.Parse(Console.ReadLine());
                integerInput += 1;
                Console.WriteLine(integerInput);
                break;
            case 2:
                Console.WriteLine("Please enter a double:");
                double doubleInput = double.Parse(Console.ReadLine());
                doubleInput += 1;
                Console.WriteLine(doubleInput);
                break;
            case 3:
                Console.WriteLine("Please enter a string:");
                string stringInput = Console.ReadLine();
                stringInput += "*";
                Console.WriteLine(stringInput);
                break;
            default: Console.WriteLine("Not a correct number.");
                break;
        }
    }
}