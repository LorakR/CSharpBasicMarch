/*Input :t 1 2         Output: 38
Comments

 * 52 weekends total in the year, split into:
2 hometown weekends  2 Sundays  2 plays
50 normal weekends  50 * 2 / 3  33.33 plays
1 holiday  0.5 plays
Leap years  additional 3 plays
Total plays = 38.83 plays  38 (rounded)
*/

using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        //Is the year leap? t/f
        string isLeap = Console.ReadLine();
        //Enter the number of holidays.
        int holidays = int.Parse(Console.ReadLine());
        //Enter the number of hometown weekends.
        int hometownWeekends = int.Parse(Console.ReadLine());
        decimal numberOfPlays=0m;
        //if the year is leap he plays 3 more times
        if (isLeap == "t")
        {
            numberOfPlays = numberOfPlays + 3;
        }
        //he plays only on 1/2 of the holidays
        decimal holidayPlays = holidays * 0.5m;
        numberOfPlays = numberOfPlays + holidayPlays;
        //when in hometown he plays once
        numberOfPlays = numberOfPlays + hometownWeekends;
        //In the year there are exactly 52 weekends. Those which he don't spend in hometown are considered normal.
        int normalWeekends = 52 - hometownWeekends;
        //He is tired 1/3 of the normal weekends
        decimal notTired = normalWeekends - normalWeekends * 1 / 3;
        //In the normal weekends when he is not tired he plays twice.
        numberOfPlays = numberOfPlays + 2 * notTired;
        //The total number of plays have to be rounded to the nearest integer number.
        int total = (int)Math.Round(numberOfPlays);
        Console.WriteLine(total);
    }
}

