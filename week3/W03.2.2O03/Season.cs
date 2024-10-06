class Season
{
    public readonly int Year;
    public readonly List<Race> Races;
    public readonly List<Team> Teams;
    public static readonly List<int> PointsForPositions = new List<int> { 25, 18, 15, 12, 10, 8, 6, 4, 2, 1 };
    public Season(int year, List<Race> races, List<Team> teams)
    {
        Year = year;
        Races = races;
        Teams = teams;
    }
    public void RunSeason()
    {
        List<Driver> drivers = new List<Driver>();
        foreach (var team in Teams)
        {
            foreach (var driver in team.Drivers)
            {
                drivers.Add(driver);
            }
        }
        foreach (var Race in Races)
        {
            List<Driver> raceResults = Race.GetRaceResults(drivers);
            Console.WriteLine($"{raceResults[0].Name} of {raceResults[0].TeamName} has won the {Race.Location} Grand Prix!");
        }
    }
    public void PrintSeasonResults()
    {
        List<Driver> drivers = new List<Driver>();
        foreach (var team in Teams)
        {
            foreach (var driver in team.Drivers)
            {
                drivers.Add(driver);
            }
        }
        drivers = drivers.OrderByDescending(o => o.DriverPoints).ToList();
        Console.WriteLine("Season results:");
        int position = 1;
        foreach (var driver in drivers)
        {
            Console.WriteLine($"{position}. {driver.Name}: {driver.DriverPoints}");
            position++;
        }
    }
}