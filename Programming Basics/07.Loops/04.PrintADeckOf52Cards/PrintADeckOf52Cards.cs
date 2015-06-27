/* Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. 
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement. */

using System;
class PrintADeckOf52Cards
{
    static void Main()
    {
        char[] symbols = { '\u2663', '\u2666', '\u2665', '\u2660' };
        int next = 0;
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (i)
                {
                    case 11:
                        string Jack = i.ToString();
                        Jack = "J";
                        Console.Write("{0}{1} ", Jack, symbols[next]);
                        next++;
                        break;
                    case 12:
                        string Queen = i.ToString();
                        Queen = "Q";
                        Console.Write("{0}{1} ", Queen, symbols[next]);
                        next++;
                        break;
                    case 13:
                        string King = i.ToString();
                        King = "K";
                        Console.Write("{0}{1} ", King, symbols[next]);
                        next++;
                        break;
                    case 14:
                        string Ace = i.ToString();
                        Ace = "A";
                        Console.Write("{0}{1} ", Ace, symbols[next]);
                        next++;
                        break;
                    default: 
                        Console.Write("{0}{1} ", i, symbols[next]);
                        next++;
                        break;
                }
                
            }
            Console.WriteLine();
            next = 0;
        }
    }
}