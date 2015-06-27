//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CheckForAPlayCard
{
    static void Main()
    {
        string[] cards = {
            "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
        };
        string input = Console.ReadLine();
        if (cards.Contains(input))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}