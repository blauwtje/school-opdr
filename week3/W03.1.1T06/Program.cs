class Program
{
    static void Main()
    {
        const int spdOfLightInMperS = 299792458;
        const double daysInYear = 365.242199;
        const string planetName = "LP 890-9b";
        const double distanceFromEarthInLightYear = 100;
        Console.WriteLine($"The planet {planetName} is {distanceFromEarthInLightYear} light years away from Earth.\nIn meters this is {checked((long)spdOfLightInMperS * 60 * 60 * 24 * daysInYear * distanceFromEarthInLightYear)}");
    }
}