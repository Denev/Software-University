using System;
class QuotesInStrings
{
    static void Main()
    {
        string firstText = "The \"use\" of quotations causes difficulties.";
        string secondText = @"The ""use"" of quotations causes difficulties."; 
        Console.WriteLine(firstText);
        Console.WriteLine(secondText);
    }
}

