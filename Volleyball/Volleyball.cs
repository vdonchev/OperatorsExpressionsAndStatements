using System;

class Volleyball
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int hollidays = int.Parse(Console.ReadLine());
        int homeTownVisits = int.Parse(Console.ReadLine());

        double totalGames = 0;
        double normalWeekends = 48 - homeTownVisits;
        
        double hollidayGames = (hollidays / 3d) * 2d;
        double weekendGames = (normalWeekends / 4d) * 3d;
        double homeTownGames = homeTownVisits;

        totalGames = hollidayGames + weekendGames + homeTownGames;
        totalGames += (yearType == "leap") ? totalGames * 0.15d : 0;

        Console.WriteLine((int)totalGames);
    }
}