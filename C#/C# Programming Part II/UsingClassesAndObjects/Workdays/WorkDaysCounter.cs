//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;

class WorkDaysCounter
{
    static void Main()
    {
        Console.Write("Enter end date: ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        int count = 0;

        for (DateTime i = DateTime.Now; i < endDate.AddDays(1); i = i.AddDays(1))
        {
            if (CheckHolidays(i))
            {
                if ((int)i.DayOfWeek == 0 || ((int)i.DayOfWeek == 6))
                {
                    continue;
                }

                count++;
            }
        }

        Console.WriteLine("There are {0} workdays from today until {1}", count, endDate);
    }

    static bool CheckHolidays(DateTime toCheck)
    {
        DateTime[] holidays = { new DateTime(0001, 03, 03), new DateTime(0001, 05, 24), new DateTime(0001, 09, 06), 
                                new DateTime(0001, 05, 01), new DateTime(0001, 05, 06), new DateTime(0001, 09, 22),
                                new DateTime(0001, 12, 24), new DateTime(0001, 12, 25), new DateTime(0001, 01, 01) };

        for (int i = 0; i < holidays.Length; i++)
        {
            if (toCheck.Day == holidays[i].Day && toCheck.Month == holidays[i].Month)
            {
                return false;
            }
        }

        return true;
    }
}

