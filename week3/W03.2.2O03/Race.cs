class Race
{
    public readonly string Location;
    public Race(string location)
    {
        Location = location;
    }
    public static List<Driver> GetRaceResults(List<Driver> _drivers)
    {
        Random rng = new();
        List<Driver> drivers = _drivers.OrderBy(x => rng.Next()).ToList();
        return drivers;
    }
}
