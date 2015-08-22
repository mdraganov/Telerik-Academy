//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time
//according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

using System;

class IsItTimeForBeer
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter time in hh:mm tt format: ");
            string timeInput = Console.ReadLine();
            DateTime beerTimeStart = DateTime.Parse("1:00 PM");
            DateTime beerTimeEnd = DateTime.Parse("3:00 AM");
            DateTime time;
            if (DateTime.TryParse(timeInput, out time))
            {
                if (time >= beerTimeStart && time < beerTimeEnd.AddDays(1) || time < beerTimeEnd)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}