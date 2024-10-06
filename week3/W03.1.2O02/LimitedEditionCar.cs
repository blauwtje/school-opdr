class LimitedEditionCar
{
    public const string Model = "McLaren F1";
    public readonly string ChassisNumber;
    public static int Counter = 0;
    public LimitedEditionCar()
    {
        ChassisNumber = $"CHNO{Counter + 1}";
        Counter++;
    }
}