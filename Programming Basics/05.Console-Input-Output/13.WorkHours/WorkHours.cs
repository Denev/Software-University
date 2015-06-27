using System;
class WorkHours
{
    static void Main()
    {
        decimal requiredHours = decimal.Parse(Console.ReadLine());
        decimal daysToFinish = decimal.Parse(Console.ReadLine());
        decimal productivity = decimal.Parse(Console.ReadLine());

        decimal hoursPlusBiking = daysToFinish - (daysToFinish / 10);
        
        decimal workingHours = 12 * hoursPlusBiking;
        long total = (long)(productivity * workingHours) / 100;

         if (requiredHours > total)
        {
            Console.WriteLine("No");
            Console.WriteLine("-{0}", requiredHours - total);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine(total - requiredHours);
        }
         
    }
}

