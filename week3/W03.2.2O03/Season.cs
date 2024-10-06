class Season
{
    public int Year;
    public List<Race> Races;
    public List<Team> Teams;
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
        Race.GetRaceResults(drivers);
    }
    public static void PrintSeasonResults()
    {
        List<Driver> drivers = new List<Driver>();
        drivers = [.. drivers.OrderByDescending(o => o.DriverPoints)];
        Console.WriteLine("Season results:");
    }
}