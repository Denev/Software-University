using System;
class JoroTheFootballPlayer
{
    static void Main()
    {
        int total;
        string leapOrNotLeap = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        holidays /= 2;
        int hometownWeekends = int.Parse(Console.ReadLine());
        
        int normalWeekends = 52 - hometownWeekends;
        int normalWeekendsMultiplied = normalWeekends * 2 / 3;
         if (leapOrNotLeap == "t")
        {
            total = holidays + normalWeekendsMultiplied + hometownWeekends + 3;
        }
        else
        {
            total = holidays + normalWeekendsMultiplied + hometownWeekends;
        }
        Console.WriteLine(total);
        
    }
}

