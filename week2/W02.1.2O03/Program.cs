public class Program
{
    public static void Main()
    {
        Player p1 = ...;
        Player p2 = ...;
        Player winner = ...;
        Console.WriteLine($"{p1.Name}: {p1.Power} Power; {p1.HealthPoints} Healthpoints");
        Console.WriteLine($"{p2.Name}: {p2.Power} Power; {p2.HealthPoints} Healthpoints");
        while (...)
        {
            p1.TakeDamage(...);
            p2.TakeDamage(...);
            if (...)
                winner = p2;
            else if (...)
                winner = p1;
            Console.WriteLine($"{p1.Name}: {p1.Power} Power; {p1.HealthPoints} Healthpoints");
            Console.WriteLine($"{p2.Name}: {p2.Power} Power; {p2.HealthPoints} Healthpoints");
        }

        Console.WriteLine($"-----The winner is:-----\n{winner.Name}: {winner.Power} Power; {winner.HealthPoints} Healthpoints");
    }
}