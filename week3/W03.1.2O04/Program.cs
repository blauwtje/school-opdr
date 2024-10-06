class Program
{
    public static void Main()
    {
        GameTools.ReturnCount = true;
        Console.WriteLine(GameTools.DiceRoll(6, 100));
    }
}