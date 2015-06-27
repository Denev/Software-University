using System;
class AgeAfter10Years
{
    static void Main()
    {
        
        DateTime birthday = new DateTime();
        birthday = DateTime.Parse(Console.ReadLine()); //Enter the year/month/day I was born.
        DateTime today = DateTime.Now; //The date today.
        int age = today.Year - birthday.Year; //My age now.
        if (birthday.Month < today.Month)
        {
            Console.WriteLine(age); 
            Console.WriteLine(age + 10);
        }
        else if (birthday.Month > today.Month)
        {
            Console.WriteLine(age - 1);
            Console.WriteLine(age + 9);
        }
        else if (birthday.Month == today.Month)
        {
            if (birthday.Day <= today.Day) 
            {
                Console.WriteLine(age);
                Console.WriteLine(age + 10);
            }
            else 
            {
                Console.WriteLine(age - 1);
                Console.WriteLine(age + 9);
            }
        }
    }
}
