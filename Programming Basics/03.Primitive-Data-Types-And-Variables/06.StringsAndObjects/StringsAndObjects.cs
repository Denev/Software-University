using System;
class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object concatenation = hello + " " + world;
        string finalResult = concatenation.ToString();
        Console.WriteLine(finalResult);
    }
}

