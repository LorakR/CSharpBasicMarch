/*A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times.*/

using System;

class BeerTime
{
    static void Main()
    {
        string enteredTime = Console.ReadLine();
        DateTime beerTime;
        bool isValid = DateTime.TryParse(enteredTime, out beerTime);
        if (!isValid)
        {
            Console.WriteLine("invalid time");
        }
        //in this way I get AM/PM value from a DateTime
        string designator = beerTime.ToString("tt");
        if (isValid)
        {
            if (designator == "AM")
            {
                if (beerTime.Hour >= 3)
                {
                    Console.WriteLine("non-beer time");
                }
                else
                {
                    Console.WriteLine("beer time");
                }
            }
            else if (designator == "PM")
            {
                if (beerTime.Hour >= 1)
                {
                    Console.WriteLine("beer time");
                }
            }
        }
    }
}

